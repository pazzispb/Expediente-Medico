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
            this.gbDetalleAnalitica = new System.Windows.Forms.GroupBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pdfVisualizador = new AxAcroPDFLib.AxAcroPDF();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropositoAnalitica = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarAnalitica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).BeginInit();
            this.gbDetalleAnalitica.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisualizador)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnaliticas
            // 
            this.dgvAnaliticas.AllowUserToAddRows = false;
            this.dgvAnaliticas.AllowUserToDeleteRows = false;
            this.dgvAnaliticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnaliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnaliticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnaliticas.Location = new System.Drawing.Point(0, 65);
            this.dgvAnaliticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAnaliticas.Name = "dgvAnaliticas";
            this.dgvAnaliticas.ReadOnly = true;
            this.dgvAnaliticas.RowHeadersVisible = false;
            this.dgvAnaliticas.RowHeadersWidth = 51;
            this.dgvAnaliticas.RowTemplate.Height = 24;
            this.dgvAnaliticas.Size = new System.Drawing.Size(851, 159);
            this.dgvAnaliticas.TabIndex = 0;
            this.dgvAnaliticas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnaliticas_CellDoubleClick);
            // 
            // gbDetalleAnalitica
            // 
            this.gbDetalleAnalitica.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalleAnalitica.Controls.Add(this.pnContenedor);
            this.gbDetalleAnalitica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetalleAnalitica.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleAnalitica.Location = new System.Drawing.Point(0, 243);
            this.gbDetalleAnalitica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleAnalitica.Name = "gbDetalleAnalitica";
            this.gbDetalleAnalitica.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalleAnalitica.Size = new System.Drawing.Size(851, 513);
            this.gbDetalleAnalitica.TabIndex = 1;
            this.gbDetalleAnalitica.TabStop = false;
            this.gbDetalleAnalitica.Text = "Detalle de la analítica";
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.pnContenedor.Controls.Add(this.btnBorrar);
            this.pnContenedor.Controls.Add(this.pdfVisualizador);
            this.pnContenedor.Controls.Add(this.txtObservaciones);
            this.pnContenedor.Controls.Add(this.label8);
            this.pnContenedor.Controls.Add(this.label2);
            this.pnContenedor.Controls.Add(this.txtPropositoAnalitica);
            this.pnContenedor.Controls.Add(this.lblID);
            this.pnContenedor.Controls.Add(this.label4);
            this.pnContenedor.Controls.Add(this.label7);
            this.pnContenedor.Controls.Add(this.dtpFecha);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContenedor.Location = new System.Drawing.Point(3, 18);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(845, 493);
            this.pnContenedor.TabIndex = 30;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Gray;
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(0, 216);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(845, 37);
            this.btnBorrar.TabIndex = 36;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pdfVisualizador
            // 
            this.pdfVisualizador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdfVisualizador.Enabled = true;
            this.pdfVisualizador.Location = new System.Drawing.Point(0, 253);
            this.pdfVisualizador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfVisualizador.Name = "pdfVisualizador";
            this.pdfVisualizador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfVisualizador.OcxState")));
            this.pdfVisualizador.Size = new System.Drawing.Size(845, 240);
            this.pdfVisualizador.TabIndex = 13;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(165, 109);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(660, 86);
            this.txtObservaciones.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // txtPropositoAnalitica
            // 
            this.txtPropositoAnalitica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPropositoAnalitica.Enabled = false;
            this.txtPropositoAnalitica.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropositoAnalitica.Location = new System.Drawing.Point(251, 66);
            this.txtPropositoAnalitica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPropositoAnalitica.Multiline = true;
            this.txtPropositoAnalitica.Name = "txtPropositoAnalitica";
            this.txtPropositoAnalitica.Size = new System.Drawing.Size(575, 27);
            this.txtPropositoAnalitica.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(67, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Propósito de la Analítica";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(643, 24);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(183, 28);
            this.dtpFecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de analíticas";
            // 
            // btnRegistrarAnalitica
            // 
            this.btnRegistrarAnalitica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarAnalitica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnRegistrarAnalitica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarAnalitica.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAnalitica.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAnalitica.Location = new System.Drawing.Point(488, 18);
            this.btnRegistrarAnalitica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarAnalitica.Name = "btnRegistrarAnalitica";
            this.btnRegistrarAnalitica.Size = new System.Drawing.Size(341, 37);
            this.btnRegistrarAnalitica.TabIndex = 3;
            this.btnRegistrarAnalitica.Text = "Registrar nueva analítica";
            this.btnRegistrarAnalitica.UseVisualStyleBackColor = false;
            this.btnRegistrarAnalitica.Click += new System.EventHandler(this.btnRegistrarAnalitica_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegistrarAnalitica);
            this.panel1.Controls.Add(this.dgvAnaliticas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 224);
            this.panel1.TabIndex = 4;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.BackColor = System.Drawing.Color.Gray;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(352, 18);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(131, 37);
            this.btnCargar.TabIndex = 35;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmAnaliticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(851, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDetalleAnalitica);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmAnaliticas";
            this.Text = "Registro de Analíticas";
            this.Load += new System.EventHandler(this.frmAnaliticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnaliticas)).EndInit();
            this.gbDetalleAnalitica.ResumeLayout(false);
            this.pnContenedor.ResumeLayout(false);
            this.pnContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfVisualizador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnaliticas;
        private System.Windows.Forms.GroupBox gbDetalleAnalitica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarAnalitica;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPropositoAnalitica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Button btnCargar;
        private AxAcroPDFLib.AxAcroPDF pdfVisualizador;
        private System.Windows.Forms.Button btnBorrar;
    }
}