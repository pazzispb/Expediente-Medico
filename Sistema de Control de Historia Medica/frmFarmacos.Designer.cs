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
            this.txtDosisFarmaco = new System.Windows.Forms.TextBox();
            this.cmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.cmbFrecuenciaFarmaco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionFarmaco = new System.Windows.Forms.TextBox();
            this.txtFarmaco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFarmacos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargarFarmacos = new System.Windows.Forms.Button();
            this.btnIngresarFarmacos = new System.Windows.Forms.Button();
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
            this.panel2.Location = new System.Drawing.Point(24, 297);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 217);
            this.panel2.TabIndex = 18;
            // 
            // txtDosisFarmaco
            // 
            this.txtDosisFarmaco.Enabled = false;
            this.txtDosisFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosisFarmaco.Location = new System.Drawing.Point(167, 160);
            this.txtDosisFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosisFarmaco.Name = "txtDosisFarmaco";
            this.txtDosisFarmaco.Size = new System.Drawing.Size(333, 28);
            this.txtDosisFarmaco.TabIndex = 59;
            // 
            // cmbFrecuencia
            // 
            this.cmbFrecuencia.Enabled = false;
            this.cmbFrecuencia.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbFrecuencia.Location = new System.Drawing.Point(391, 96);
            this.cmbFrecuencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFrecuencia.Name = "cmbFrecuencia";
            this.cmbFrecuencia.Size = new System.Drawing.Size(109, 32);
            this.cmbFrecuencia.TabIndex = 58;
            // 
            // cmbFrecuenciaFarmaco
            // 
            this.cmbFrecuenciaFarmaco.Enabled = false;
            this.cmbFrecuenciaFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrecuenciaFarmaco.FormattingEnabled = true;
            this.cmbFrecuenciaFarmaco.Items.AddRange(new object[] {
            "Diaria",
            "Interdiaria",
            "Semanal",
            "Mensual"});
            this.cmbFrecuenciaFarmaco.Location = new System.Drawing.Point(167, 96);
            this.cmbFrecuenciaFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFrecuenciaFarmaco.Name = "cmbFrecuenciaFarmaco";
            this.cmbFrecuenciaFarmaco.Size = new System.Drawing.Size(199, 32);
            this.cmbFrecuenciaFarmaco.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Dosis:";
            // 
            // txtDescripcionFarmaco
            // 
            this.txtDescripcionFarmaco.Enabled = false;
            this.txtDescripcionFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionFarmaco.Location = new System.Drawing.Point(571, 60);
            this.txtDescripcionFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionFarmaco.Multiline = true;
            this.txtDescripcionFarmaco.Name = "txtDescripcionFarmaco";
            this.txtDescripcionFarmaco.Size = new System.Drawing.Size(361, 105);
            this.txtDescripcionFarmaco.TabIndex = 53;
            // 
            // txtFarmaco
            // 
            this.txtFarmaco.Enabled = false;
            this.txtFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarmaco.Location = new System.Drawing.Point(167, 34);
            this.txtFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFarmaco.Name = "txtFarmaco";
            this.txtFarmaco.Size = new System.Drawing.Size(333, 28);
            this.txtFarmaco.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Frecuencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fármaco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Fármacos";
            // 
            // dgvFarmacos
            // 
            this.dgvFarmacos.AllowUserToAddRows = false;
            this.dgvFarmacos.AllowUserToDeleteRows = false;
            this.dgvFarmacos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacos.Location = new System.Drawing.Point(25, 79);
            this.dgvFarmacos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFarmacos.Name = "dgvFarmacos";
            this.dgvFarmacos.ReadOnly = true;
            this.dgvFarmacos.RowHeadersVisible = false;
            this.dgvFarmacos.RowHeadersWidth = 51;
            this.dgvFarmacos.Size = new System.Drawing.Size(984, 185);
            this.dgvFarmacos.TabIndex = 36;
            this.dgvFarmacos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFarmacos_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Detalles del Fármaco";
            // 
            // btnCargarFarmacos
            // 
            this.btnCargarFarmacos.BackColor = System.Drawing.Color.Gray;
            this.btnCargarFarmacos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarFarmacos.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFarmacos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarFarmacos.Location = new System.Drawing.Point(551, 30);
            this.btnCargarFarmacos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarFarmacos.Name = "btnCargarFarmacos";
            this.btnCargarFarmacos.Size = new System.Drawing.Size(132, 42);
            this.btnCargarFarmacos.TabIndex = 38;
            this.btnCargarFarmacos.Text = "Cargar";
            this.btnCargarFarmacos.UseVisualStyleBackColor = false;
            this.btnCargarFarmacos.Click += new System.EventHandler(this.btnCargarFarmacos_Click);
            // 
            // btnIngresarFarmacos
            // 
            this.btnIngresarFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnIngresarFarmacos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarFarmacos.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarFarmacos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarFarmacos.Location = new System.Drawing.Point(693, 30);
            this.btnIngresarFarmacos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresarFarmacos.Name = "btnIngresarFarmacos";
            this.btnIngresarFarmacos.Size = new System.Drawing.Size(316, 42);
            this.btnIngresarFarmacos.TabIndex = 39;
            this.btnIngresarFarmacos.Text = "Ingresar Nuevo Fármaco";
            this.btnIngresarFarmacos.UseVisualStyleBackColor = false;
            this.btnIngresarFarmacos.Click += new System.EventHandler(this.btnIngresarFarmacos_Click);
            // 
            // frmFarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 527);
            this.Controls.Add(this.btnIngresarFarmacos);
            this.Controls.Add(this.btnCargarFarmacos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvFarmacos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnCargarFarmacos;
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