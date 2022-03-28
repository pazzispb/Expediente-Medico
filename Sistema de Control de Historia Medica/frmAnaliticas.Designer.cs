namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmAnaliticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaliticas));
            this.dgvAnaliticas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pdfVisorAnalitica = new AxAcroPDFLib.AxAcroPDF();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarAnalitica = new System.Windows.Forms.Button();
            this.txtPropositoAnalitica = new System.Windows.Forms.TextBox();
            this.txtTipoAnalitica = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisorAnalitica)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnaliticas
            // 
            this.dgvAnaliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnaliticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnaliticas.Location = new System.Drawing.Point(0, 53);
            this.dgvAnaliticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAnaliticas.Name = "dgvAnaliticas";
            this.dgvAnaliticas.RowHeadersWidth = 51;
            this.dgvAnaliticas.RowTemplate.Height = 24;
            this.dgvAnaliticas.Size = new System.Drawing.Size(638, 129);
            this.dgvAnaliticas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoAnalitica);
            this.groupBox1.Controls.Add(this.txtPropositoAnalitica);
            this.groupBox1.Controls.Add(this.pdfVisorAnalitica);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(638, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de la analítica";
            // 
            // pdfVisorAnalitica
            // 
            this.pdfVisorAnalitica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdfVisorAnalitica.Enabled = true;
            this.pdfVisorAnalitica.Location = new System.Drawing.Point(2, 166);
            this.pdfVisorAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfVisorAnalitica.Name = "pdfVisorAnalitica";
            this.pdfVisorAnalitica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfVisorAnalitica.OcxState")));
            this.pdfVisorAnalitica.Size = new System.Drawing.Size(634, 259);
            this.pdfVisorAnalitica.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(141, 100);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(481, 55);
            this.txtObservaciones.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(144, 33);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(138, 23);
            this.dtpFecha.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Propósito del análisis";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de analítica";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(52, 36);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de analíticas";
            // 
            // btnRegistrarAnalitica
            // 
            this.btnRegistrarAnalitica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarAnalitica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnRegistrarAnalitica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAnalitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAnalitica.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAnalitica.Location = new System.Drawing.Point(310, 12);
            this.btnRegistrarAnalitica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarAnalitica.Name = "btnRegistrarAnalitica";
            this.btnRegistrarAnalitica.Size = new System.Drawing.Size(312, 30);
            this.btnRegistrarAnalitica.TabIndex = 3;
            this.btnRegistrarAnalitica.Text = "Registrar nueva analítica";
            this.btnRegistrarAnalitica.UseVisualStyleBackColor = false;
            // 
            // txtPropositoAnalitica
            // 
            this.txtPropositoAnalitica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPropositoAnalitica.Enabled = false;
            this.txtPropositoAnalitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropositoAnalitica.Location = new System.Drawing.Point(189, 67);
            this.txtPropositoAnalitica.Margin = new System.Windows.Forms.Padding(2);
            this.txtPropositoAnalitica.Multiline = true;
            this.txtPropositoAnalitica.Name = "txtPropositoAnalitica";
            this.txtPropositoAnalitica.Size = new System.Drawing.Size(432, 23);
            this.txtPropositoAnalitica.TabIndex = 12;
            // 
            // txtTipoAnalitica
            // 
            this.txtTipoAnalitica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoAnalitica.Enabled = false;
            this.txtTipoAnalitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnalitica.Location = new System.Drawing.Point(423, 32);
            this.txtTipoAnalitica.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoAnalitica.Multiline = true;
            this.txtTipoAnalitica.Name = "txtTipoAnalitica";
            this.txtTipoAnalitica.Size = new System.Drawing.Size(198, 23);
            this.txtTipoAnalitica.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegistrarAnalitica);
            this.panel1.Controls.Add(this.dgvAnaliticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 182);
            this.panel1.TabIndex = 4;
            // 
            // frmAnaliticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmAnaliticas";
            this.Text = "Registro de Analíticas";
            this.Load += new System.EventHandler(this.frmAnaliticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisorAnalitica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnaliticas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarAnalitica;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private AxAcroPDFLib.AxAcroPDF pdfVisorAnalitica;
        private System.Windows.Forms.TextBox txtPropositoAnalitica;
        private System.Windows.Forms.TextBox txtTipoAnalitica;
        private System.Windows.Forms.Panel panel1;
    }
}