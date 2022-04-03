namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmLogIn
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
            this.lblCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lbLogIn = new System.Windows.Forms.Label();
            this.lblRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.LinkColor = System.Drawing.Color.Black;
            this.lblCrearCuenta.Location = new System.Drawing.Point(212, 358);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(68, 13);
            this.lblCrearCuenta.TabIndex = 0;
            this.lblCrearCuenta.TabStop = true;
            this.lblCrearCuenta.Text = "Crear cuenta";
            this.lblCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCrearCuenta_LinkClicked);
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(201, 320);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(92, 23);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(125, 200);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(249, 31);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(125, 247);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(249, 31);
            this.txtContrasena.TabIndex = 3;
            // 
            // lbLogIn
            // 
            this.lbLogIn.AutoSize = true;
            this.lbLogIn.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogIn.ForeColor = System.Drawing.Color.White;
            this.lbLogIn.Location = new System.Drawing.Point(147, 84);
            this.lbLogIn.Name = "lbLogIn";
            this.lbLogIn.Size = new System.Drawing.Size(227, 88);
            this.lbLogIn.TabIndex = 4;
            this.lbLogIn.Text = "LogIn";
            // 
            // lblRecuperarContrasena
            // 
            this.lblRecuperarContrasena.AutoSize = true;
            this.lblRecuperarContrasena.LinkColor = System.Drawing.Color.Black;
            this.lblRecuperarContrasena.Location = new System.Drawing.Point(189, 378);
            this.lblRecuperarContrasena.Name = "lblRecuperarContrasena";
            this.lblRecuperarContrasena.Size = new System.Drawing.Size(113, 13);
            this.lblRecuperarContrasena.TabIndex = 5;
            this.lblRecuperarContrasena.TabStop = true;
            this.lblRecuperarContrasena.Text = "Recuperar contraseña";
            this.lblRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperarContrasena_LinkClicked);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(541, 415);
            this.Controls.Add(this.lblRecuperarContrasena);
            this.Controls.Add(this.lbLogIn);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblCrearCuenta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblCrearCuenta;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lbLogIn;
        private System.Windows.Forms.LinkLabel lblRecuperarContrasena;
    }
}