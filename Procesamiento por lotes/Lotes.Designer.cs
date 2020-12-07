namespace Procesamiento_por_lotes
{
    partial class Lotes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotes));
            this.add_process = new System.Windows.Forms.Button();
            this.wait_lot_label = new System.Windows.Forms.Label();
            this.lot_label = new System.Windows.Forms.Label();
            this.execute_groupbox = new System.Windows.Forms.GroupBox();
            this.tr_label = new System.Windows.Forms.Label();
            this.tt_label = new System.Windows.Forms.Label();
            this.tme_label = new System.Windows.Forms.Label();
            this.op_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.end_lot_label = new System.Windows.Forms.Label();
            this.crono_label = new System.Windows.Forms.Label();
            this.execute_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.state = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.execute_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // add_process
            // 
            this.add_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add_process.Location = new System.Drawing.Point(132, 17);
            this.add_process.Name = "add_process";
            this.add_process.Size = new System.Drawing.Size(94, 39);
            this.add_process.TabIndex = 0;
            this.add_process.Text = "Agregar Procesos";
            this.add_process.UseVisualStyleBackColor = false;
            this.add_process.Click += new System.EventHandler(this.add_process_Click);
            // 
            // wait_lot_label
            // 
            this.wait_lot_label.AutoSize = true;
            this.wait_lot_label.BackColor = System.Drawing.Color.Green;
            this.wait_lot_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wait_lot_label.ForeColor = System.Drawing.Color.White;
            this.wait_lot_label.Location = new System.Drawing.Point(12, 90);
            this.wait_lot_label.Name = "wait_lot_label";
            this.wait_lot_label.Size = new System.Drawing.Size(94, 13);
            this.wait_lot_label.TabIndex = 1;
            this.wait_lot_label.Text = "Procesos Nuevos:";
            // 
            // lot_label
            // 
            this.lot_label.AutoSize = true;
            this.lot_label.BackColor = System.Drawing.Color.Green;
            this.lot_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lot_label.ForeColor = System.Drawing.Color.White;
            this.lot_label.Location = new System.Drawing.Point(12, 108);
            this.lot_label.Name = "lot_label";
            this.lot_label.Size = new System.Drawing.Size(32, 13);
            this.lot_label.TabIndex = 2;
            this.lot_label.Text = "Listo:";
            // 
            // execute_groupbox
            // 
            this.execute_groupbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.execute_groupbox.Controls.Add(this.tr_label);
            this.execute_groupbox.Controls.Add(this.tt_label);
            this.execute_groupbox.Controls.Add(this.tme_label);
            this.execute_groupbox.Controls.Add(this.op_label);
            this.execute_groupbox.Controls.Add(this.id_label);
            this.execute_groupbox.ForeColor = System.Drawing.Color.Black;
            this.execute_groupbox.Location = new System.Drawing.Point(381, 108);
            this.execute_groupbox.Name = "execute_groupbox";
            this.execute_groupbox.Size = new System.Drawing.Size(190, 201);
            this.execute_groupbox.TabIndex = 3;
            this.execute_groupbox.TabStop = false;
            this.execute_groupbox.Text = "Ejecución";
            // 
            // tr_label
            // 
            this.tr_label.AutoSize = true;
            this.tr_label.Location = new System.Drawing.Point(15, 170);
            this.tr_label.Name = "tr_label";
            this.tr_label.Size = new System.Drawing.Size(91, 13);
            this.tr_label.TabIndex = 5;
            this.tr_label.Text = "Tiempo Restante:";
            // 
            // tt_label
            // 
            this.tt_label.AutoSize = true;
            this.tt_label.Location = new System.Drawing.Point(12, 134);
            this.tt_label.Name = "tt_label";
            this.tt_label.Size = new System.Drawing.Size(107, 13);
            this.tt_label.TabIndex = 4;
            this.tt_label.Text = "Tiempo Transcurrido:";
            // 
            // tme_label
            // 
            this.tme_label.AutoSize = true;
            this.tme_label.Location = new System.Drawing.Point(12, 101);
            this.tme_label.Name = "tme_label";
            this.tme_label.Size = new System.Drawing.Size(130, 13);
            this.tme_label.TabIndex = 3;
            this.tme_label.Text = "Tiempo Máximo Estimado:";
            // 
            // op_label
            // 
            this.op_label.AutoSize = true;
            this.op_label.Location = new System.Drawing.Point(15, 65);
            this.op_label.Name = "op_label";
            this.op_label.Size = new System.Drawing.Size(59, 13);
            this.op_label.TabIndex = 2;
            this.op_label.Text = "Operación:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(15, 31);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            // 
            // end_lot_label
            // 
            this.end_lot_label.AutoSize = true;
            this.end_lot_label.BackColor = System.Drawing.Color.Green;
            this.end_lot_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_lot_label.ForeColor = System.Drawing.Color.White;
            this.end_lot_label.Location = new System.Drawing.Point(587, 123);
            this.end_lot_label.Name = "end_lot_label";
            this.end_lot_label.Size = new System.Drawing.Size(65, 13);
            this.end_lot_label.TabIndex = 4;
            this.end_lot_label.Text = "Terminados:";
            // 
            // crono_label
            // 
            this.crono_label.AutoSize = true;
            this.crono_label.BackColor = System.Drawing.Color.Green;
            this.crono_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crono_label.ForeColor = System.Drawing.Color.White;
            this.crono_label.Location = new System.Drawing.Point(488, 35);
            this.crono_label.Name = "crono_label";
            this.crono_label.Size = new System.Drawing.Size(110, 13);
            this.crono_label.TabIndex = 5;
            this.crono_label.Text = "Tiempo Transcurrido: ";
            // 
            // execute_btn
            // 
            this.execute_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.execute_btn.Location = new System.Drawing.Point(6, 18);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(95, 39);
            this.execute_btn.TabIndex = 6;
            this.execute_btn.Text = "Cargar";
            this.execute_btn.UseVisualStyleBackColor = false;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TME,
            this.TT});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 138);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TME
            // 
            this.TME.HeaderText = "TME";
            this.TME.Name = "TME";
            // 
            // TT
            // 
            this.TT.HeaderText = "TR";
            this.TT.Name = "TT";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Operacion,
            this.Resultado});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(590, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(342, 281);
            this.dataGridView2.TabIndex = 8;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operación";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Yellow;
            this.start.Location = new System.Drawing.Point(117, 17);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(95, 39);
            this.start.TabIndex = 9;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Green;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(604, 35);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(13, 13);
            this.time_label.TabIndex = 10;
            this.time_label.Text = "0";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(819, 17);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(82, 48);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reiniciar";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(6, 28);
            this.cantidad.MaxLength = 3;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(96, 20);
            this.cantidad.TabIndex = 12;
            this.cantidad.Text = "1";
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.add_process);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevos Lotes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.execute_btn);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Location = new System.Drawing.Point(264, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejecutar";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.Green;
            this.state.ForeColor = System.Drawing.Color.White;
            this.state.Location = new System.Drawing.Point(495, 57);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 13);
            this.state.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.Enabled = false;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView3.Location = new System.Drawing.Point(7, 294);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(246, 126);
            this.dataGridView3.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Transcurrido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bloqueado";
            // 
            // Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.state);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crono_label);
            this.Controls.Add(this.end_lot_label);
            this.Controls.Add(this.execute_groupbox);
            this.Controls.Add(this.lot_label);
            this.Controls.Add(this.wait_lot_label);
            this.KeyPreview = true;
            this.Name = "Lotes";
            this.Text = "Procesamiento por Lotes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lotes_KeyDown);
            this.execute_groupbox.ResumeLayout(false);
            this.execute_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_process;
        private System.Windows.Forms.Label wait_lot_label;
        private System.Windows.Forms.Label lot_label;
        private System.Windows.Forms.GroupBox execute_groupbox;
        private System.Windows.Forms.Label tr_label;
        private System.Windows.Forms.Label tt_label;
        private System.Windows.Forms.Label tme_label;
        private System.Windows.Forms.Label op_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label end_lot_label;
        private System.Windows.Forms.Label crono_label;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
    }
}

