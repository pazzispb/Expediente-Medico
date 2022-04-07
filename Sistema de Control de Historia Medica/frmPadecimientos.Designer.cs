namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmPadecimientos
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
            this.btnCargarPadecimientos = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpPadecimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionPadecimiento = new System.Windows.Forms.TextBox();
            this.txtTipoPadecimiento = new System.Windows.Forms.TextBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPadecimientos = new System.Windows.Forms.DataGridView();
            this.btnIngresarPadecimientos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadecimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarPadecimientos
            // 
            this.btnCargarPadecimientos.BackColor = System.Drawing.Color.Gray;
            this.btnCargarPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarPadecimientos.Location = new System.Drawing.Point(404, 13);
            this.btnCargarPadecimientos.Name = "btnCargarPadecimientos";
            this.btnCargarPadecimientos.Size = new System.Drawing.Size(99, 34);
            this.btnCargarPadecimientos.TabIndex = 11;
            this.btnCargarPadecimientos.Text = "Cargar";
            this.btnCargarPadecimientos.UseVisualStyleBackColor = false;
            this.btnCargarPadecimientos.Click += new System.EventHandler(this.btnCargarPadecimientos_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(12, 15);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(166, 25);
            this.labTitulo.TabIndex = 14;
            this.labTitulo.Text = "Padecimientos";
            this.labTitulo.Click += new System.EventHandler(this.labTitulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.dtpPadecimiento);
            this.panel2.Controls.Add(this.txtDescripcionPadecimiento);
            this.panel2.Controls.Add(this.txtTipoPadecimiento);
            this.panel2.Controls.Add(this.txtPadecimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 156);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpPadecimiento
            // 
            this.dtpPadecimiento.Enabled = false;
            this.dtpPadecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPadecimiento.Location = new System.Drawing.Point(139, 113);
            this.dtpPadecimiento.Name = "dtpPadecimiento";
            this.dtpPadecimiento.Size = new System.Drawing.Size(156, 20);
            this.dtpPadecimiento.TabIndex = 7;
            // 
            // txtDescripcionPadecimiento
            // 
            this.txtDescripcionPadecimiento.AcceptsReturn = true;
            this.txtDescripcionPadecimiento.Enabled = false;
            this.txtDescripcionPadecimiento.Location = new System.Drawing.Point(355, 49);
            this.txtDescripcionPadecimiento.Multiline = true;
            this.txtDescripcionPadecimiento.Name = "txtDescripcionPadecimiento";
            this.txtDescripcionPadecimiento.Size = new System.Drawing.Size(361, 80);
            this.txtDescripcionPadecimiento.TabIndex = 6;
            this.txtDescripcionPadecimiento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTipoPadecimiento
            // 
            this.txtTipoPadecimiento.Enabled = false;
            this.txtTipoPadecimiento.Location = new System.Drawing.Point(139, 63);
            this.txtTipoPadecimiento.Name = "txtTipoPadecimiento";
            this.txtTipoPadecimiento.Size = new System.Drawing.Size(156, 20);
            this.txtTipoPadecimiento.TabIndex = 5;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Enabled = false;
            this.txtPadecimiento.Location = new System.Drawing.Point(139, 21);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(156, 20);
            this.txtPadecimiento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Padecimiento:";
            // 
            // dgvPadecimientos
            // 
            this.dgvPadecimientos.AllowUserToAddRows = false;
            this.dgvPadecimientos.AllowUserToDeleteRows = false;
            this.dgvPadecimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPadecimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadecimientos.Location = new System.Drawing.Point(12, 55);
            this.dgvPadecimientos.Name = "dgvPadecimientos";
            this.dgvPadecimientos.ReadOnly = true;
            this.dgvPadecimientos.RowHeadersVisible = false;
            this.dgvPadecimientos.Size = new System.Drawing.Size(745, 150);
            this.dgvPadecimientos.TabIndex = 16;
            // 
            // btnIngresarPadecimientos
            // 
            this.btnIngresarPadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnIngresarPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngresarPadecimientos.Location = new System.Drawing.Point(520, 12);
            this.btnIngresarPadecimientos.Name = "btnIngresarPadecimientos";
            this.btnIngresarPadecimientos.Size = new System.Drawing.Size(237, 34);
            this.btnIngresarPadecimientos.TabIndex = 13;
            this.btnIngresarPadecimientos.Text = "Ingresar Nuevo Padecimiento";
            this.btnIngresarPadecimientos.UseVisualStyleBackColor = false;
            this.btnIngresarPadecimientos.Click += new System.EventHandler(this.btnIngresarPadecimientos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Detalles del Padecimiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPadecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPadecimientos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnIngresarPadecimientos);
            this.Controls.Add(this.btnCargarPadecimientos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmPadecimientos";
            this.Text = "Padecimientos";
            this.Load += new System.EventHandler(this.frmPadecimientos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadecimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPadecimientos;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPadecimientos;
        private System.Windows.Forms.Button btnIngresarPadecimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionPadecimiento;
        private System.Windows.Forms.TextBox txtTipoPadecimiento;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPadecimiento;
    }
}