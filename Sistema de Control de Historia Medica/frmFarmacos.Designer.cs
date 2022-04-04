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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbFrecuenciaDias = new System.Windows.Forms.CheckedListBox();
            this.txtDescripcionPadecimiento = new System.Windows.Forms.TextBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.dtpPadecimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargarPadecimientos = new System.Windows.Forms.Button();
            this.btnIngresarFarmacos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chbFrecuenciaDias);
            this.panel2.Controls.Add(this.txtDescripcionPadecimiento);
            this.panel2.Controls.Add(this.txtPadecimiento);
            this.panel2.Controls.Add(this.dtpPadecimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 269);
            this.panel2.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4 o más"});
            this.comboBox1.Location = new System.Drawing.Point(150, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 45;
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
            // chbFrecuenciaDias
            // 
            this.chbFrecuenciaDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.chbFrecuenciaDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chbFrecuenciaDias.CheckOnClick = true;
            this.chbFrecuenciaDias.Enabled = false;
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
            // 
            // txtDescripcionPadecimiento
            // 
            this.txtDescripcionPadecimiento.Enabled = false;
            this.txtDescripcionPadecimiento.Location = new System.Drawing.Point(382, 66);
            this.txtDescripcionPadecimiento.Multiline = true;
            this.txtDescripcionPadecimiento.Name = "txtDescripcionPadecimiento";
            this.txtDescripcionPadecimiento.Size = new System.Drawing.Size(272, 86);
            this.txtDescripcionPadecimiento.TabIndex = 10;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Enabled = false;
            this.txtPadecimiento.Location = new System.Drawing.Point(150, 41);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(150, 20);
            this.txtPadecimiento.TabIndex = 9;
            // 
            // dtpPadecimiento
            // 
            this.dtpPadecimiento.Enabled = false;
            this.dtpPadecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPadecimiento.Location = new System.Drawing.Point(150, 79);
            this.dtpPadecimiento.Name = "dtpPadecimiento";
            this.dtpPadecimiento.Size = new System.Drawing.Size(150, 20);
            this.dtpPadecimiento.TabIndex = 8;
            this.dtpPadecimiento.Value = new System.DateTime(2022, 4, 4, 10, 25, 0, 0);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
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
            this.label1.Text = "Farmacos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 36;
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
            this.btnCargarPadecimientos.Location = new System.Drawing.Point(446, 24);
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
            this.btnIngresarFarmacos.Location = new System.Drawing.Point(551, 24);
            this.btnIngresarFarmacos.Name = "btnIngresarFarmacos";
            this.btnIngresarFarmacos.Size = new System.Drawing.Size(237, 34);
            this.btnIngresarFarmacos.TabIndex = 39;
            this.btnIngresarFarmacos.Text = "Ingresar Nuevo Fármaco";
            this.btnIngresarFarmacos.UseVisualStyleBackColor = false;
            // 
            // frmFarmacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnIngresarFarmacos);
            this.Controls.Add(this.btnCargarPadecimientos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmFarmacos";
            this.Text = "Fármacos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chbFrecuenciaDias;
        private System.Windows.Forms.TextBox txtDescripcionPadecimiento;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.DateTimePicker dtpPadecimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargarPadecimientos;
        private System.Windows.Forms.Button btnIngresarFarmacos;
    }
}