namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmPerfilPersonal
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
            this.frmPerfilPersonalbox = new System.Data.SQLite.SQLiteCommand();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSeguroMedico = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSeguroM = new System.Windows.Forms.Label();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblFechaNa = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMiCuenta = new System.Windows.Forms.Label();
            this.pnContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmPerfilPersonalbox
            // 
            this.frmPerfilPersonalbox.CommandText = null;
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.pnContenedor.Controls.Add(this.btnEditarPerfil);
            this.pnContenedor.Controls.Add(this.txtUsuario);
            this.pnContenedor.Controls.Add(this.txtTelefono);
            this.pnContenedor.Controls.Add(this.txtSeguroMedico);
            this.pnContenedor.Controls.Add(this.label15);
            this.pnContenedor.Controls.Add(this.label14);
            this.pnContenedor.Controls.Add(this.txtAltura);
            this.pnContenedor.Controls.Add(this.txtPeso);
            this.pnContenedor.Controls.Add(this.cmbTipoSangre);
            this.pnContenedor.Controls.Add(this.label13);
            this.pnContenedor.Controls.Add(this.dtpFecha);
            this.pnContenedor.Controls.Add(this.txtCedula);
            this.pnContenedor.Controls.Add(this.txtApellido);
            this.pnContenedor.Controls.Add(this.txtNombre);
            this.pnContenedor.Controls.Add(this.label12);
            this.pnContenedor.Controls.Add(this.lblNumero);
            this.pnContenedor.Controls.Add(this.lblSeguroM);
            this.pnContenedor.Controls.Add(this.lblSangre);
            this.pnContenedor.Controls.Add(this.lblPeso);
            this.pnContenedor.Controls.Add(this.lblAltura);
            this.pnContenedor.Controls.Add(this.lblFechaNa);
            this.pnContenedor.Controls.Add(this.lblCedula);
            this.pnContenedor.Controls.Add(this.lblApellido);
            this.pnContenedor.Controls.Add(this.lblNombre);
            this.pnContenedor.Controls.Add(this.lblUsuario);
            this.pnContenedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContenedor.Location = new System.Drawing.Point(11, 46);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(578, 299);
            this.pnContenedor.TabIndex = 30;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Location = new System.Drawing.Point(154, 261);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(238, 27);
            this.btnEditarPerfil.TabIndex = 53;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(400, 221);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtUsuario.TabIndex = 52;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(156, 218);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 23);
            this.txtTelefono.TabIndex = 51;
            // 
            // txtSeguroMedico
            // 
            this.txtSeguroMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguroMedico.Location = new System.Drawing.Point(128, 166);
            this.txtSeguroMedico.Name = "txtSeguroMedico";
            this.txtSeguroMedico.Size = new System.Drawing.Size(432, 23);
            this.txtSeguroMedico.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(330, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "kg.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(165, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "m.";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(78, 111);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(86, 23);
            this.txtAltura.TabIndex = 47;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(248, 111);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(80, 23);
            this.txtPeso.TabIndex = 46;
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoSangre.FormattingEnabled = true;
            this.cmbTipoSangre.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cmbTipoSangre.Location = new System.Drawing.Point(488, 111);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(73, 25);
            this.cmbTipoSangre.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(275, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 44;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(446, 61);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(114, 23);
            this.dtpFecha.TabIndex = 43;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(78, 61);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(191, 23);
            this.txtCedula.TabIndex = 42;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(367, 20);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(194, 23);
            this.txtApellido.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(78, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 23);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 39;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(6, 221);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(135, 18);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Número telefónico";
            // 
            // lblSeguroM
            // 
            this.lblSeguroM.AutoSize = true;
            this.lblSeguroM.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguroM.Location = new System.Drawing.Point(6, 166);
            this.lblSeguroM.Name = "lblSeguroM";
            this.lblSeguroM.Size = new System.Drawing.Size(108, 18);
            this.lblSeguroM.TabIndex = 37;
            this.lblSeguroM.Text = "Seguro Médico";
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.Location = new System.Drawing.Point(364, 113);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(108, 18);
            this.lblSangre.TabIndex = 36;
            this.lblSangre.Text = "Tipo de sangre";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(198, 113);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 18);
            this.lblPeso.TabIndex = 35;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(6, 113);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 18);
            this.lblAltura.TabIndex = 34;
            this.lblAltura.Text = "Altura";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.AutoSize = true;
            this.lblFechaNa.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNa.Location = new System.Drawing.Point(275, 61);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(152, 18);
            this.lblFechaNa.TabIndex = 33;
            this.lblFechaNa.Text = "Fecha de nacimiento";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(6, 63);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(55, 18);
            this.lblCedula.TabIndex = 32;
            this.lblCedula.Text = "Cédula";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(286, 26);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 18);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 18);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(330, 221);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 18);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblMiCuenta
            // 
            this.lblMiCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMiCuenta.AutoSize = true;
            this.lblMiCuenta.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.lblMiCuenta.ForeColor = System.Drawing.Color.Black;
            this.lblMiCuenta.Location = new System.Drawing.Point(236, 9);
            this.lblMiCuenta.Name = "lblMiCuenta";
            this.lblMiCuenta.Size = new System.Drawing.Size(128, 30);
            this.lblMiCuenta.TabIndex = 53;
            this.lblMiCuenta.Text = "Mi Cuenta";
            this.lblMiCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPerfilPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.lblMiCuenta);
            this.Controls.Add(this.pnContenedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmPerfilPersonal";
            this.Text = "Perfil Personal";
            this.Load += new System.EventHandler(this.frmPerfilPersonal_Load);
            this.pnContenedor.ResumeLayout(false);
            this.pnContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommand frmPerfilPersonalbox;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSeguroMedico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbTipoSangre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblSeguroM;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblFechaNa;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMiCuenta;
        private System.Windows.Forms.Button btnEditarPerfil;
    }
}