namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmRegistrarFarmacos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFarmaco = new System.Windows.Forms.TextBox();
            this.txtDescripcionFarmaco = new System.Windows.Forms.TextBox();
            this.btnGuardarFarmaco = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.txtDosisFarmaco = new System.Windows.Forms.TextBox();
            this.cmbVeces = new System.Windows.Forms.ComboBox();
            this.cmbFrecuenciaFarmaco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(345, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Datos del Farmaco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fármaco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Frecuencia:";
            // 
            // txtFarmaco
            // 
            this.txtFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarmaco.Location = new System.Drawing.Point(137, 43);
            this.txtFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFarmaco.Name = "txtFarmaco";
            this.txtFarmaco.Size = new System.Drawing.Size(333, 28);
            this.txtFarmaco.TabIndex = 9;
            // 
            // txtDescripcionFarmaco
            // 
            this.txtDescripcionFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionFarmaco.Location = new System.Drawing.Point(528, 57);
            this.txtDescripcionFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionFarmaco.Multiline = true;
            this.txtDescripcionFarmaco.Name = "txtDescripcionFarmaco";
            this.txtDescripcionFarmaco.Size = new System.Drawing.Size(361, 105);
            this.txtDescripcionFarmaco.TabIndex = 10;
            // 
            // btnGuardarFarmaco
            // 
            this.btnGuardarFarmaco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarFarmaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnGuardarFarmaco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFarmaco.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFarmaco.Location = new System.Drawing.Point(528, 171);
            this.btnGuardarFarmaco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarFarmaco.Name = "btnGuardarFarmaco";
            this.btnGuardarFarmaco.Size = new System.Drawing.Size(231, 41);
            this.btnGuardarFarmaco.TabIndex = 34;
            this.btnGuardarFarmaco.Text = "Guardar datos";
            this.btnGuardarFarmaco.UseVisualStyleBackColor = false;
            this.btnGuardarFarmaco.Click += new System.EventHandler(this.btnGuardarFarmaco_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(764, 171);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 41);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.pnContenedor.Controls.Add(this.txtDosisFarmaco);
            this.pnContenedor.Controls.Add(this.cmbVeces);
            this.pnContenedor.Controls.Add(this.cmbFrecuenciaFarmaco);
            this.pnContenedor.Controls.Add(this.label3);
            this.pnContenedor.Controls.Add(this.btnCancelar);
            this.pnContenedor.Controls.Add(this.btnGuardarFarmaco);
            this.pnContenedor.Controls.Add(this.txtDescripcionFarmaco);
            this.pnContenedor.Controls.Add(this.txtFarmaco);
            this.pnContenedor.Controls.Add(this.label5);
            this.pnContenedor.Controls.Add(this.label4);
            this.pnContenedor.Controls.Add(this.label2);
            this.pnContenedor.Location = new System.Drawing.Point(24, 79);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(921, 255);
            this.pnContenedor.TabIndex = 17;
            // 
            // txtDosisFarmaco
            // 
            this.txtDosisFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosisFarmaco.Location = new System.Drawing.Point(137, 169);
            this.txtDosisFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosisFarmaco.Name = "txtDosisFarmaco";
            this.txtDosisFarmaco.Size = new System.Drawing.Size(333, 28);
            this.txtDosisFarmaco.TabIndex = 48;
            // 
            // cmbVeces
            // 
            this.cmbVeces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeces.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeces.FormattingEnabled = true;
            this.cmbVeces.Items.AddRange(new object[] {
            "1 vez",
            "2 veces",
            "3 veces",
            "4 veces",
            "5 veces",
            "6 veces",
            "8 veces",
            "9 veces",
            "10 veces"});
            this.cmbVeces.Location = new System.Drawing.Point(361, 105);
            this.cmbVeces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVeces.Name = "cmbVeces";
            this.cmbVeces.Size = new System.Drawing.Size(109, 32);
            this.cmbVeces.TabIndex = 47;
            // 
            // cmbFrecuenciaFarmaco
            // 
            this.cmbFrecuenciaFarmaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuenciaFarmaco.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrecuenciaFarmaco.FormattingEnabled = true;
            this.cmbFrecuenciaFarmaco.Items.AddRange(new object[] {
            "Diaria",
            "Interdiaria",
            "Semanal",
            "Mensual"});
            this.cmbFrecuenciaFarmaco.Location = new System.Drawing.Point(137, 105);
            this.cmbFrecuenciaFarmaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFrecuenciaFarmaco.Name = "cmbFrecuenciaFarmaco";
            this.cmbFrecuenciaFarmaco.Size = new System.Drawing.Size(199, 32);
            this.cmbFrecuenciaFarmaco.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Dosis:";
            // 
            // frmRegistrarFarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistrarFarmacos";
            this.Text = "Registro de Farmacos";
            this.Load += new System.EventHandler(this.frmRegistrarFarmacos_Load);
            this.pnContenedor.ResumeLayout(false);
            this.pnContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFarmaco;
        private System.Windows.Forms.TextBox txtDescripcionFarmaco;
        private System.Windows.Forms.Button btnGuardarFarmaco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDosisFarmaco;
        private System.Windows.Forms.ComboBox cmbVeces;
        private System.Windows.Forms.ComboBox cmbFrecuenciaFarmaco;
    }
}