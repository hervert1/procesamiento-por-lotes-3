namespace Procesamiento_por_lotes
{
    partial class BCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCP));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TL,
            this.TF,
            this.TME,
            this.TR,
            this.TRes,
            this.TE,
            this.TS});
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TL
            // 
            this.TL.HeaderText = "Tiempo Llegada";
            this.TL.Name = "TL";
            // 
            // TF
            // 
            this.TF.HeaderText = "Tiempo Finalización";
            this.TF.Name = "TF";
            // 
            // TME
            // 
            this.TME.HeaderText = "Tiempo Maximo";
            this.TME.Name = "TME";
            // 
            // TR
            // 
            this.TR.HeaderText = "Tiempo de Retorno";
            this.TR.Name = "TR";
            // 
            // TRes
            // 
            this.TRes.HeaderText = "Tiempo de Respuesta";
            this.TRes.Name = "TRes";
            // 
            // TE
            // 
            this.TE.HeaderText = "Tiempo de Espera";
            this.TE.Name = "TE";
            // 
            // TS
            // 
            this.TS.HeaderText = "Tiempo de Servicio";
            this.TS.Name = "TS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BCP";
            // 
            // BCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BCP";
            this.Text = "BCP";
            this.Load += new System.EventHandler(this.BCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TS;
    }
}