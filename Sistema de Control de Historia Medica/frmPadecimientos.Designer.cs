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
            this.labTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcionPadecimiento = new System.Windows.Forms.TextBox();
            this.txtTipoPadecimiento = new System.Windows.Forms.TextBox();
            this.txtNombrePadecimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarPadecimiento = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvPadecimientos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadecimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(12, 12);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(294, 25);
            this.labTitulo.TabIndex = 14;
            this.labTitulo.Text = "Registro de Padecimientos";
            this.labTitulo.Click += new System.EventHandler(this.labTitulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.txtDescripcionPadecimiento);
            this.panel2.Controls.Add(this.txtTipoPadecimiento);
            this.panel2.Controls.Add(this.txtNombrePadecimiento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Location = new System.Drawing.Point(17, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 248);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDescripcionPadecimiento
            // 
            this.txtDescripcionPadecimiento.Location = new System.Drawing.Point(97, 139);
            this.txtDescripcionPadecimiento.Multiline = true;
            this.txtDescripcionPadecimiento.Name = "txtDescripcionPadecimiento";
            this.txtDescripcionPadecimiento.Size = new System.Drawing.Size(389, 65);
            this.txtDescripcionPadecimiento.TabIndex = 16;
            // 
            // txtTipoPadecimiento
            // 
            this.txtTipoPadecimiento.Location = new System.Drawing.Point(97, 72);
            this.txtTipoPadecimiento.Name = "txtTipoPadecimiento";
            this.txtTipoPadecimiento.Size = new System.Drawing.Size(136, 20);
            this.txtTipoPadecimiento.TabIndex = 15;
            // 
            // txtNombrePadecimiento
            // 
            this.txtNombrePadecimiento.Location = new System.Drawing.Point(97, 28);
            this.txtNombrePadecimiento.Name = "txtNombrePadecimiento";
            this.txtNombrePadecimiento.Size = new System.Drawing.Size(136, 20);
            this.txtNombrePadecimiento.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(414, 28);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(138, 23);
            this.dtpFecha.TabIndex = 10;
            // 
            // btnRegistrarPadecimiento
            // 
            this.btnRegistrarPadecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnRegistrarPadecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPadecimiento.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPadecimiento.Location = new System.Drawing.Point(431, 10);
            this.btnRegistrarPadecimiento.Name = "btnRegistrarPadecimiento";
            this.btnRegistrarPadecimiento.Size = new System.Drawing.Size(229, 34);
            this.btnRegistrarPadecimiento.TabIndex = 30;
            this.btnRegistrarPadecimiento.Text = "Registrar Nuevo Padecimiento";
            this.btnRegistrarPadecimiento.UseVisualStyleBackColor = false;
            this.btnRegistrarPadecimiento.Click += new System.EventHandler(this.btnRegistrarPadecimiento_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Gray;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(326, 10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(99, 34);
            this.btnCargar.TabIndex = 31;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // dgvPadecimientos
            // 
            this.dgvPadecimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadecimientos.Location = new System.Drawing.Point(17, 60);
            this.dgvPadecimientos.Name = "dgvPadecimientos";
            this.dgvPadecimientos.Size = new System.Drawing.Size(643, 181);
            this.dgvPadecimientos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Detalle de Padecimiento";
            // 
            // frmPadecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPadecimientos);
            this.Controls.Add(this.btnRegistrarPadecimiento);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmPadecimientos";
            this.Text = "Registro de Padecimientos";
            this.Load += new System.EventHandler(this.frmPadecimientos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadecimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarPadecimiento;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvPadecimientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDescripcionPadecimiento;
        private System.Windows.Forms.TextBox txtTipoPadecimiento;
        private System.Windows.Forms.TextBox txtNombrePadecimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}