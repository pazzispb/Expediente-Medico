namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmRegistrarPadecimientos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoPadecimiento = new System.Windows.Forms.ComboBox();
            this.dtpPadecimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.txtDescripcionPadecimiento = new System.Windows.Forms.TextBox();
            this.chbEstadoFecha = new System.Windows.Forms.CheckBox();
            this.btnGuardarPadecimiento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardarPadecimiento);
            this.panel2.Controls.Add(this.chbEstadoFecha);
            this.panel2.Controls.Add(this.txtDescripcionPadecimiento);
            this.panel2.Controls.Add(this.txtPadecimiento);
            this.panel2.Controls.Add(this.dtpPadecimiento);
            this.panel2.Controls.Add(this.cmbTipoPadecimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 216);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Padecimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datos del Padecimiento";
            // 
            // cmbTipoPadecimiento
            // 
            this.cmbTipoPadecimiento.FormattingEnabled = true;
            this.cmbTipoPadecimiento.Location = new System.Drawing.Point(187, 26);
            this.cmbTipoPadecimiento.Name = "cmbTipoPadecimiento";
            this.cmbTipoPadecimiento.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoPadecimiento.TabIndex = 4;
            // 
            // dtpPadecimiento
            // 
            this.dtpPadecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPadecimiento.Location = new System.Drawing.Point(187, 122);
            this.dtpPadecimiento.Name = "dtpPadecimiento";
            this.dtpPadecimiento.Size = new System.Drawing.Size(150, 20);
            this.dtpPadecimiento.TabIndex = 8;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(187, 73);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(150, 20);
            this.txtPadecimiento.TabIndex = 9;
            // 
            // txtDescripcionPadecimiento
            // 
            this.txtDescripcionPadecimiento.Location = new System.Drawing.Point(415, 54);
            this.txtDescripcionPadecimiento.Multiline = true;
            this.txtDescripcionPadecimiento.Name = "txtDescripcionPadecimiento";
            this.txtDescripcionPadecimiento.Size = new System.Drawing.Size(272, 86);
            this.txtDescripcionPadecimiento.TabIndex = 10;
            // 
            // chbEstadoFecha
            // 
            this.chbEstadoFecha.AutoSize = true;
            this.chbEstadoFecha.Location = new System.Drawing.Point(187, 148);
            this.chbEstadoFecha.Name = "chbEstadoFecha";
            this.chbEstadoFecha.Size = new System.Drawing.Size(72, 17);
            this.chbEstadoFecha.TabIndex = 11;
            this.chbEstadoFecha.Text = "No Aplica";
            this.chbEstadoFecha.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPadecimiento
            // 
            this.btnGuardarPadecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPadecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnGuardarPadecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPadecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPadecimiento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPadecimiento.Location = new System.Drawing.Point(415, 158);
            this.btnGuardarPadecimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPadecimiento.Name = "btnGuardarPadecimiento";
            this.btnGuardarPadecimiento.Size = new System.Drawing.Size(173, 33);
            this.btnGuardarPadecimiento.TabIndex = 34;
            this.btnGuardarPadecimiento.Text = "Guardar datos";
            this.btnGuardarPadecimiento.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(592, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarPadecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmRegistrarPadecimientos";
            this.Text = "Registro de Padecimientos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPadecimiento;
        private System.Windows.Forms.CheckBox chbEstadoFecha;
        private System.Windows.Forms.TextBox txtDescripcionPadecimiento;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.DateTimePicker dtpPadecimiento;
        private System.Windows.Forms.Button btnGuardarPadecimiento;
        private System.Windows.Forms.Button btnCancelar;
    }
}