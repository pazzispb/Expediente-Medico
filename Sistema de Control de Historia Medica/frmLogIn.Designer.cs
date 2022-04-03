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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecuperarContrasena = new System.Windows.Forms.LinkLabel();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogIn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRecuperarContrasena
            // 
            this.lbRecuperarContrasena.AutoSize = true;
            this.lbRecuperarContrasena.LinkColor = System.Drawing.Color.Black;
            this.lbRecuperarContrasena.Location = new System.Drawing.Point(189, 378);
            this.lbRecuperarContrasena.Name = "lbRecuperarContrasena";
            this.lbRecuperarContrasena.Size = new System.Drawing.Size(113, 13);
            this.lbRecuperarContrasena.TabIndex = 5;
            this.lbRecuperarContrasena.TabStop = true;
            this.lbRecuperarContrasena.Text = "Recuperar contraseña";
            this.lbRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRecuperarContrasena_LinkClicked);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(541, 415);
            this.Controls.Add(this.lbRecuperarContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbRecuperarContrasena;
    }
}