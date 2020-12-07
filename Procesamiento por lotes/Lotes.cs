using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Procesamiento_por_lotes
{
    public partial class Lotes : Form
    {
        int procesos = 0;
        int act = 0;
        double tiempo_usado = 0, tiempo_restante = 0;
        string lastchar = "C";                           // Variable para detectar teclas

        List<process> nuevo = new List<process>();
        List<process> lista = new List<process>();
        List<process> bloqueado = new List<process>();
        List<process> terminado = new List<process>();

        public Lotes(){
            InitializeComponent();
            start.Enabled = false;
            string sr = "Proceso.txt";
            if (!File.Exists(sr)){
                execute_btn.Enabled = false;
            }
        }

        private void add_process_Click(object sender, EventArgs e){
            try{
                int id = 1;
                File.Delete("Proceso.txt");
                int cant = int.Parse(cantidad.Text);
                string result = "";

                //Generación Random
                var value = 0;
                var value2 = 1;
                var seed = Environment.TickCount;
                var random = new Random(seed);

                for(int i = 0; i < cant; i++) { 
                    //Recuperar contenido previo
                    string sr = "Proceso.txt";
                    string previous = "";
                    if (File.Exists(sr)){
                        previous = File.ReadAllText(sr);
                    }

                    //Crear el archivo y el Writer
                    StreamWriter sw = new StreamWriter("Proceso.txt");
                    sw.Write(previous);

                    //Iniciar nueva escritura
                    sw.WriteLine("#JOB");                       // Escribir inicio de proceso

                    result = Convert.ToString(id);              // Pasar a string el valor
                    sw.WriteLine(result);                       // Escribir el ID

                    value = random.Next(7, 16);
                    result = Convert.ToString(value);           // Pasar a string el valor
                    sw.WriteLine(result);                       // Escribir Tiempo Máximo Estimado

                    value = random.Next(0, 4);                  // Generar la operación aritmetica
                    string operador = "";
                    if (value == 0){ operador = "+"; }          // Comparar el signo correspondiente
                    else if (value == 1) { operador = "-"; }    //
                    else if (value == 2) { operador = "*"; }    //
                    else if (value == 3) { operador = "/"; }    //
                    else if (value == 4) { operador = "%"; }    //

                    value = random.Next(0, 10000);              // Generar operador 1
                    value2 = random.Next(1, 10000);             // Generar operador 2
                    sw.WriteLine(value + operador + value2);    // Escribir la operación

                    float num1, num2, res = 0;                    // Variables para hacer la operación
                    num1 = value;                               // Operador 1 a variable
                    num2 = value2;                              // Operador 2 a variable

                    if (operador == "+"){                       // Comparaciones de operaciones, suma
                        res = num1 + num2;
                    }
                    else if (operador == "-"){                  // Comparaciones de operaciones, resta
                        res = num1 - num2;
                    }
                    else if (operador == "*"){                  // Comparaciones de operaciones, multiplicación
                        res = num1 * num2;
                    }
                    else if (operador == "/"){                  // Comparaciones de operaciones, división
                        res = num1 / num2;
                    }
                    else if (operador == "%"){                  // Comparaciones de operaciones, residuo
                        res = num1 % num2;
                    }

                    result = Convert.ToString(res);             // Escribir resultado de operación
                    sw.WriteLine(result);                       //
                    sw.WriteLine("#END");                       // Final del proceso

                    sw.Close();                                 //Cerrar el archivo
                    id++;
                }
            }
            finally { }
        }

        private void reset_Click(object sender, EventArgs e) {
            Lotes lot = new Lotes();
            lot.Show();
            this.Hide();
        }

        private void cantidad_TextChanged(object sender, EventArgs e){
            if (cantidad.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(cantidad.Text, "^[0]+$")){
                add_process.Enabled = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(cantidad.Text, "^[0-9]+$")){
                add_process.Enabled = true;
            }
            else{
                cantidad.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo, debe ser mayor que 0");
            }
        }

        private void Lotes_KeyDown(object sender, KeyEventArgs e){
            
            // Detectar teclas presionadas
            if(e.KeyValue.ToString() == "80"){
                state.Text = "PAUSE";
                clock.Stop();
                lastchar = "P";
            }
            else if (e.KeyValue.ToString() == "67"){
                state.Text = "RUNNING";
                clock.Start();
                lastchar = "C";
            }
            else if (e.KeyValue.ToString() == "69" && lastchar != "P"){
                state.Text = "Process " + lista[act].getNum() + " INTERRUPTED";
                lastchar = "E";

                tiempo_usado = tiempo_usado + lista[act].getTT();

                lista[0].setEstado(8);
                bloqueado.Add(lista[0]);
                lista.RemoveAt(0);

                dataGridView1.Rows.RemoveAt(0);
            }
            else if (e.KeyValue.ToString() == "87" && lastchar != "P")
            {
                state.Text = "ERROR in process " + lista[act].getNum();
                lastchar = "W";

                lista[act].setTT(lista[act].getTME());
                tiempo_usado = tiempo_usado + lista[act].getTT();
                lista[act].setResultado("Error");
            }
        }

        private void clock_Tick(object sender, EventArgs e){

            // Variables de tiempo
            Double tiempo = Convert.ToDouble(time_label.Text);      // Obtener el tiempo anterior desde el label
            tiempo = tiempo + 1;                                    // Sumar 1 al tiempo
            time_label.Text = tiempo.ToString();                    // Reimprimir el tiempo
            int row = 0;

            id_label.Text = "ID:";
            op_label.Text = "Operación: ";
            tme_label.Text = "Tiempo Máximo Estimado: ";
            tt_label.Text = "Tiempo Trasncurrido: ";
            tr_label.Text = "Tiempo restante: ";

            // Actualizar la ventana de proceso actual
            if (lista.Count != 0){
                if (lista[act].getEstado() == 0){
                    if(lista[act].getTT() != lista[act].getTME()){
                        lista[act].setTT(lista[act].getTT() + 1);
                    }
                    if(lista[act].getTRES() == -1)
                    {
                        lista[act].setTRES(tiempo - lista[act].getTL() -1);
                    }
                    id_label.Text = "ID:" + lista[act].getNum().ToString();
                    op_label.Text = "Operación: " + lista[act].getOperacion();
                    tme_label.Text = "Tiempo Máximo Estimado: " + lista[act].getTME().ToString();
                    tt_label.Text = "Tiempo Trasncurrido: " + lista[act].getTT();

                    if (lastchar != "W")
                    {
                        lista[act].setTS(lista[act].getTT());
                    }
                    tiempo_restante = (lista[act].getTME() - lista[act].getTT());
                    tr_label.Text = "Tiempo restante: " + tiempo_restante;
                    if(lastchar == "W")
                    {
                        lastchar = "C";
                    }
                }
            }

            if(bloqueado.Count != 0)
            {
                row = 0;
                dataGridView3.Rows.Clear();
                foreach (process a in bloqueado){
                    dataGridView3.Rows.Add();
                    a.setEstado(a.getEstado() - 1);

                    if(a.getEstado() == 0){
                        lista.Add(a);
                        bloqueado.Remove(a);
                        ImprimirListo();
                        break;
                    }
                    dataGridView3.Rows[row].Cells[0].Value = a.getNum();
                    dataGridView3.Rows[row].Cells[1].Value = a.getEstado();
                    row++;
                }
            }
            
            if (tiempo_restante == 0 && lista.Count != 0){
                // Si TR == 0, un proceso termino
                lista[0].setTF(tiempo);
                lista[0].setTRET(lista[0].getTF() - lista[0].getTL());
                lista[act].setTE(lista[act].getTRET() - lista[act].getTS());

                terminado.Add(lista[0]);
                lista.RemoveAt(act);

                // Impresion de terminados
                dataGridView2.Rows.Clear();
                row = 0;
                foreach(process a in terminado){
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[row].Cells[0].Value = a.getNum();
                    dataGridView2.Rows[row].Cells[1].Value = a.getOperacion();
                    dataGridView2.Rows[row].Cells[2].Value = a.getResultado();
                    row++;
                }

                // Agregar a listo los nuevos
                if(nuevo.Count != 0 && (lista.Count + bloqueado.Count) < 4){
                    nuevo[0].setTL(tiempo);
                    lista.Add(nuevo[0]);
                    nuevo.RemoveAt(0);
                }
                wait_lot_label.Text = "Procesos Nuevos: " + nuevo.Count;

                // Imprimir Listo
                ImprimirListo();

                // Condicion de paro
                if (lista.Count == 0 && bloqueado.Count == 0){
                    clock.Stop();
                    start.Enabled = false;

                    BCP bcp = new BCP();

                    row = 0;
                    bcp.dataGridView1.Rows.Clear();
                    row = 0;
                    foreach (process a in terminado)
                    {
                        bcp.dataGridView1.Rows.Add();
                        bcp.dataGridView1.Rows[row].Cells[0].Value = a.getNum();
                        bcp.dataGridView1.Rows[row].Cells[1].Value = a.getTL();
                        bcp.dataGridView1.Rows[row].Cells[2].Value = a.getTF();
                        bcp.dataGridView1.Rows[row].Cells[3].Value = a.getTME();
                        bcp.dataGridView1.Rows[row].Cells[4].Value = a.getTRET();
                        bcp.dataGridView1.Rows[row].Cells[5].Value = a.getTRES();
                        bcp.dataGridView1.Rows[row].Cells[6].Value = a.getTE();
                        bcp.dataGridView1.Rows[row].Cells[7].Value = a.getTS();
                        row++;
                    }

                    bcp.Show();

                }
            }
        }

        private void ImprimirListo(){
            // Impresion de Listo
            dataGridView1.Rows.Clear();
            if (lista.Count > 0){
                if (lista[act].getEstado() == 0) {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[act].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[act].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[act].getTME() - lista[act].getTT());
                }
                if (lista.Count > 1){
                    if (lista[act + 1].getEstado() == 0){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[act + 1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[act + 1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[act + 1].getTME() - lista[act + 1].getTT());
                    }
                    if (lista.Count > 2){
                        if (lista[act].getEstado() == 0){
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[2].Cells[0].Value = lista[act + 2].getNum();
                            dataGridView1.Rows[2].Cells[1].Value = lista[act + 2].getTME();
                            dataGridView1.Rows[2].Cells[2].Value = (lista[act + 2].getTME() - lista[act + 2].getTT());
                        }
                        if (lista.Count > 3){
                            if (lista[act].getEstado() == 0){
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[3].Cells[0].Value = lista[act + 3].getNum();
                                dataGridView1.Rows[3].Cells[1].Value = lista[act + 3].getTME();
                                dataGridView1.Rows[3].Cells[2].Value = (lista[act + 3].getTME() - lista[act + 3].getTT());
                            }
                        }
                    }
                }
            }
        }

        private void start_Click(object sender, EventArgs e){
            clock.Start();
            start.Enabled = false;
            execute_btn.Enabled = false;
        }

        private void execute_btn_Click(object sender, EventArgs e){
            String line;
            lista.Clear();
            try{
                StreamReader sr = new StreamReader("Proceso.txt");
                int num1;
                line = sr.ReadLine();

                while (line != null){

                    process pro = new process();
                    if (line == "#JOB"){
                        procesos++;
                    }
                    // Avanzar linea, convertir a int y guardar el numero de programa
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setNum(num1);

                    // Avanzar linea, convertir a int y guardar el TME
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setTME(num1);

                    // Asignar la operación
                    line = sr.ReadLine();
                    pro.setOperacion(line);

                    // Avanzar linea, convertir a int y guardar el resultado
                    line = sr.ReadLine();
                    pro.setResultado(line);

                    // Avanzar la linea de #END
                    line = sr.ReadLine();

                    nuevo.Add(pro);
                    // Avanzar una linea adicional para encontrar otro #JOB
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            finally{
                for(int a = 0; a < 4; a++){
                    if(nuevo.Count > 0){
                        nuevo[0].setTL(0);
                        lista.Add(nuevo[0]);
                        nuevo.RemoveAt(0);
                    }
                }

                dataGridView1.Rows.Clear();
                wait_lot_label.Text = "Procesos Nuevos: " + nuevo.Count;

                if(lista.Count > 0)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[0].getNum();
                    dataGridView1.Rows[0].Cells[1].Value = lista[0].getTME();
                    dataGridView1.Rows[0].Cells[2].Value = (lista[0].getTME() - lista[0].getTT());
                    if (lista.Count > 1)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[1].getNum();
                        dataGridView1.Rows[1].Cells[1].Value = lista[1].getTME();
                        dataGridView1.Rows[1].Cells[2].Value = (lista[1].getTME() - lista[1].getTT());
                        if (lista.Count > 2)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[2].Cells[0].Value = lista[2].getNum();
                            dataGridView1.Rows[2].Cells[1].Value = lista[2].getTME();
                            dataGridView1.Rows[2].Cells[2].Value = (lista[2].getTME() - lista[2].getTT());
                            if (lista.Count > 3)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[3].Cells[0].Value = lista[3].getNum();
                                dataGridView1.Rows[3].Cells[1].Value = lista[3].getTME();
                                dataGridView1.Rows[3].Cells[2].Value = (lista[3].getTME() - lista[3].getTT());
                            }
                        }
                    }
                }
                start.Enabled = true;
            }
        }

    }
}
