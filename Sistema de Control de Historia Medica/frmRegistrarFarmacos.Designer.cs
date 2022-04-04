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
            this.dtpHoraFarmaco = new System.Windows.Forms.DateTimePicker();
            this.txtFarmaco = new System.Windows.Forms.TextBox();
            this.txtDescripcionFarmaco = new System.Windows.Forms.TextBox();
            this.btnGuardarFarmaco = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbFrecuenciaDias = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFrecuenciaDiaFarmaco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(277, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Datos del Farmaco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fármaco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Frecuencia:";
            // 
            // dtpHoraFarmaco
            // 
            this.dtpHoraFarmaco.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFarmaco.Location = new System.Drawing.Point(150, 79);
            this.dtpHoraFarmaco.Name = "dtpHoraFarmaco";
            this.dtpHoraFarmaco.Size = new System.Drawing.Size(150, 20);
            this.dtpHoraFarmaco.TabIndex = 8;
            this.dtpHoraFarmaco.Value = new System.DateTime(2022, 4, 4, 10, 25, 0, 0);
            // 
            // txtFarmaco
            // 
            this.txtFarmaco.Location = new System.Drawing.Point(150, 41);
            this.txtFarmaco.Name = "txtFarmaco";
            this.txtFarmaco.Size = new System.Drawing.Size(150, 20);
            this.txtFarmaco.TabIndex = 9;
            // 
            // txtDescripcionFarmaco
            // 
            this.txtDescripcionFarmaco.Location = new System.Drawing.Point(396, 67);
            this.txtDescripcionFarmaco.Multiline = true;
            this.txtDescripcionFarmaco.Name = "txtDescripcionFarmaco";
            this.txtDescripcionFarmaco.Size = new System.Drawing.Size(272, 86);
            this.txtDescripcionFarmaco.TabIndex = 10;
            // 
            // btnGuardarFarmaco
            // 
            this.btnGuardarFarmaco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarFarmaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnGuardarFarmaco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarFarmaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFarmaco.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFarmaco.Location = new System.Drawing.Point(396, 168);
            this.btnGuardarFarmaco.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarFarmaco.Name = "btnGuardarFarmaco";
            this.btnGuardarFarmaco.Size = new System.Drawing.Size(173, 33);
            this.btnGuardarFarmaco.TabIndex = 34;
            this.btnGuardarFarmaco.Text = "Guardar datos";
            this.btnGuardarFarmaco.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(573, 168);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // chbFrecuenciaDias
            // 
            this.chbFrecuenciaDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.chbFrecuenciaDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chbFrecuenciaDias.CheckOnClick = true;
            this.chbFrecuenciaDias.FormattingEnabled = true;
            this.chbFrecuenciaDias.HorizontalScrollbar = true;
            this.chbFrecuenciaDias.Items.AddRange(new object[] {
            "Lun",
            "Mar",
            "Mie",
            "Jue",
            "Vie",
            "Sab",
            "Dom"});
            this.chbFrecuenciaDias.Location = new System.Drawing.Point(150, 111);
            this.chbFrecuenciaDias.Margin = new System.Windows.Forms.Padding(1);
            this.chbFrecuenciaDias.Name = "chbFrecuenciaDias";
            this.chbFrecuenciaDias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFrecuenciaDias.Size = new System.Drawing.Size(91, 105);
            this.chbFrecuenciaDias.TabIndex = 43;
            this.chbFrecuenciaDias.SelectedIndexChanged += new System.EventHandler(this.chbFrecuenciaDias_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.cmbFrecuenciaDiaFarmaco);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chbFrecuenciaDias);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardarFarmaco);
            this.panel2.Controls.Add(this.txtDescripcionFarmaco);
            this.panel2.Controls.Add(this.txtFarmaco);
            this.panel2.Controls.Add(this.dtpHoraFarmaco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 276);
            this.panel2.TabIndex = 17;
            // 
            // cmbFrecuenciaDiaFarmaco
            // 
            this.cmbFrecuenciaDiaFarmaco.FormattingEnabled = true;
            this.cmbFrecuenciaDiaFarmaco.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4 o más"});
            this.cmbFrecuenciaDiaFarmaco.Location = new System.Drawing.Point(150, 230);
            this.cmbFrecuenciaDiaFarmaco.Name = "cmbFrecuenciaDiaFarmaco";
            this.cmbFrecuenciaDiaFarmaco.Size = new System.Drawing.Size(150, 21);
            this.cmbFrecuenciaDiaFarmaco.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Al día:";
            // 
            // frmRegistrarFarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmRegistrarFarmacos";
            this.Text = "Farmacos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFarmaco;
        private System.Windows.Forms.TextBox txtFarmaco;
        private System.Windows.Forms.TextBox txtDescripcionFarmaco;
        private System.Windows.Forms.Button btnGuardarFarmaco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox chbFrecuenciaDias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFrecuenciaDiaFarmaco;
        private System.Windows.Forms.Label label3;
    }
}