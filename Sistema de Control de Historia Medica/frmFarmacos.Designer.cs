namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmFarmacos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFarmacos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargarPadecimientos = new System.Windows.Forms.Button();
            this.btnIngresarFarmacos = new System.Windows.Forms.Button();
            this.txtDosisFarmaco = new System.Windows.Forms.TextBox();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.cmbFrecuenciaFarmaco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionFarmaco = new System.Windows.Forms.TextBox();
            this.txtFarmaco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.txtDosisFarmaco);
            this.panel2.Controls.Add(this.cmbFrecuencia);
            this.panel2.Controls.Add(this.cmbFrecuenciaFarmaco);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescripcionFarmaco);
            this.panel2.Controls.Add(this.txtFarmaco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 176);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fármacos";
            // 
            // dgvFarmacos
            // 
            this.dgvFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacos.Location = new System.Drawing.Point(19, 64);
            this.dgvFarmacos.Name = "dgvFarmacos";
            this.dgvFarmacos.Size = new System.Drawing.Size(738, 150);
            this.dgvFarmacos.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Detalles del Fármaco";
            // 
            // btnCargarPadecimientos
            // 
            this.btnCargarPadecimientos.BackColor = System.Drawing.Color.Gray;
            this.btnCargarPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarPadecimientos.Location = new System.Drawing.Point(413, 24);
            this.btnCargarPadecimientos.Name = "btnCargarPadecimientos";
            this.btnCargarPadecimientos.Size = new System.Drawing.Size(99, 34);
            this.btnCargarPadecimientos.TabIndex = 38;
            this.btnCargarPadecimientos.Text = "Cargar";
            this.btnCargarPadecimientos.UseVisualStyleBackColor = false;
            // 
            // btnIngresarFarmacos
            // 
            this.btnIngresarFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnIngresarFarmacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarFarmacos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarFarmacos.Location = new System.Drawing.Point(520, 24);
            this.btnIngresarFarmacos.Name = "btnIngresarFarmacos";
            this.btnIngresarFarmacos.Size = new System.Drawing.Size(237, 34);
            this.btnIngresarFarmacos.TabIndex = 39;
            this.btnIngresarFarmacos.Text = "Ingresar Nuevo Fármaco";
            this.btnIngresarFarmacos.UseVisualStyleBackColor = false;
            this.btnIngresarFarmacos.Click += new System.EventHandler(this.btnIngresarFarmacos_Click);
            // 
            // txtDosisFarmaco
            // 
            this.txtDosisFarmaco.Location = new System.Drawing.Point(125, 130);
            this.txtDosisFarmaco.Name = "txtDosisFarmaco";
            this.txtDosisFarmaco.Size = new System.Drawing.Size(251, 20);
            this.txtDosisFarmaco.TabIndex = 59;
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.FormattingEnabled = true;
            this.cmbFrecuencia.Items.AddRange(new object[] {
            "1 vez",
            "2 veces",
            "3 veces",
            "4 veces",
            "5 veces",
            "6 veces",
            "8 veces",
            "9 veces",
            "10 veces"});
            this.cmbFrecuencia.Location = new System.Drawing.Point(293, 78);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(83, 21);
            this.cmbFrecuencia.TabIndex = 58;
            // 
            // cmbFrecuenciaFarmaco
            // 
            this.cmbFrecuenciaFarmaco.FormattingEnabled = true;
            this.cmbFrecuenciaFarmaco.Items.AddRange(new object[] {
            "Diaria",
            "Interdiaria",
            "Semanal",
            "Mensual"});
            this.cmbFrecuenciaFarmaco.Location = new System.Drawing.Point(125, 78);
            this.cmbFrecuenciaFarmaco.Name = "cmbFrecuenciaFarmaco";
            this.cmbFrecuenciaFarmaco.Size = new System.Drawing.Size(150, 21);
            this.cmbFrecuenciaFarmaco.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Dosis:";
            // 
            // txtDescripcionFarmaco
            // 
            this.txtDescripcionFarmaco.Location = new System.Drawing.Point(428, 49);
            this.txtDescripcionFarmaco.Multiline = true;
            this.txtDescripcionFarmaco.Name = "txtDescripcionFarmaco";
            this.txtDescripcionFarmaco.Size = new System.Drawing.Size(272, 86);
            this.txtDescripcionFarmaco.TabIndex = 53;
            // 
            // txtFarmaco
            // 
            this.txtFarmaco.Location = new System.Drawing.Point(125, 28);
            this.txtFarmaco.Name = "txtFarmaco";
            this.txtFarmaco.Size = new System.Drawing.Size(251, 20);
            this.txtFarmaco.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Frecuencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fármaco:";
            // 
            // frmFarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 428);
            this.Controls.Add(this.btnIngresarFarmacos);
            this.Controls.Add(this.btnCargarPadecimientos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvFarmacos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmFarmacos";
            this.Text = "Fármacos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFarmacos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargarPadecimientos;
        private System.Windows.Forms.Button btnIngresarFarmacos;
        private System.Windows.Forms.TextBox txtDosisFarmaco;
        private System.Windows.Forms.ComboBox cmbFrecuencia;
        private System.Windows.Forms.ComboBox cmbFrecuenciaFarmaco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionFarmaco;
        private System.Windows.Forms.TextBox txtFarmaco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}