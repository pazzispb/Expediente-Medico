namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmCalendarioCitas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDatosCita = new System.Windows.Forms.Panel();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAñadirCita = new System.Windows.Forms.Button();
            this.cmbDesplegarHorario = new System.Windows.Forms.ComboBox();
            this.cmbCentro = new System.Windows.Forms.ComboBox();
            this.cmbDesplegarDoctor = new System.Windows.Forms.ComboBox();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labcondiciones = new System.Windows.Forms.Label();
            this.btnCitasAgendadas = new System.Windows.Forms.Button();
            this.dgvInfoCitas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(325, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(126, 25);
            this.labTitulo.TabIndex = 15;
            this.labTitulo.Text = "Calendario";
            this.labTitulo.Click += new System.EventHandler(this.labTitulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.dgvInfoCitas);
            this.panel1.Controls.Add(this.pnDatosCita);
            this.panel1.Controls.Add(this.MonthCalendar);
            this.panel1.Controls.Add(this.btnAñadirCita);
            this.panel1.Location = new System.Drawing.Point(2, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 338);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnDatosCita
            // 
            this.pnDatosCita.Controls.Add(this.cmbCentro);
            this.pnDatosCita.Location = new System.Drawing.Point(5, 5);
            this.pnDatosCita.Name = "pnDatosCita";
            this.pnDatosCita.Size = new System.Drawing.Size(323, 132);
            this.pnDatosCita.TabIndex = 28;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(517, 9);
            this.MonthCalendar.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.ShowToday = false;
            this.MonthCalendar.TabIndex = 26;
            // 
            // btnAñadirCita
            // 
            this.btnAñadirCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAñadirCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirCita.Location = new System.Drawing.Point(328, 143);
            this.btnAñadirCita.Name = "btnAñadirCita";
            this.btnAñadirCita.Size = new System.Drawing.Size(136, 34);
            this.btnAñadirCita.TabIndex = 27;
            this.btnAñadirCita.Text = "Añadir cita";
            this.btnAñadirCita.UseVisualStyleBackColor = false;
            this.btnAñadirCita.Click += new System.EventHandler(this.btnAñadirCita_Click_1);
            // 
            // cmbDesplegarHorario
            // 
            this.cmbDesplegarHorario.FormattingEnabled = true;
            this.cmbDesplegarHorario.Items.AddRange(new object[] {
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM"});
            this.cmbDesplegarHorario.Location = new System.Drawing.Point(84, 109);
            this.cmbDesplegarHorario.Name = "cmbDesplegarHorario";
            this.cmbDesplegarHorario.Size = new System.Drawing.Size(184, 21);
            this.cmbDesplegarHorario.TabIndex = 36;
            // 
            // cmbCentro
            // 
            this.cmbCentro.FormattingEnabled = true;
            this.cmbCentro.Location = new System.Drawing.Point(125, 96);
            this.cmbCentro.Name = "cmbCentro";
            this.cmbCentro.Size = new System.Drawing.Size(184, 21);
            this.cmbCentro.TabIndex = 35;
            // 
            // cmbDesplegarDoctor
            // 
            this.cmbDesplegarDoctor.FormattingEnabled = true;
            this.cmbDesplegarDoctor.Location = new System.Drawing.Point(78, 68);
            this.cmbDesplegarDoctor.Name = "cmbDesplegarDoctor";
            this.cmbDesplegarDoctor.Size = new System.Drawing.Size(184, 21);
            this.cmbDesplegarDoctor.TabIndex = 34;
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEditarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarCita.Location = new System.Drawing.Point(330, 406);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(99, 34);
            this.btnEditarCita.TabIndex = 32;
            this.btnEditarCita.Text = "Editar";
            this.btnEditarCita.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCita.Location = new System.Drawing.Point(158, 406);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(110, 34);
            this.btnEliminarCita.TabIndex = 31;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Centro médico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Horario:";
            // 
            // labcondiciones
            // 
            this.labcondiciones.AutoSize = true;
            this.labcondiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.labcondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcondiciones.Location = new System.Drawing.Point(15, 68);
            this.labcondiciones.Name = "labcondiciones";
            this.labcondiciones.Size = new System.Drawing.Size(57, 16);
            this.labcondiciones.TabIndex = 27;
            this.labcondiciones.Text = "Doctor:";
            // 
            // btnCitasAgendadas
            // 
            this.btnCitasAgendadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnCitasAgendadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasAgendadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCitasAgendadas.Location = new System.Drawing.Point(483, 399);
            this.btnCitasAgendadas.Name = "btnCitasAgendadas";
            this.btnCitasAgendadas.Size = new System.Drawing.Size(145, 48);
            this.btnCitasAgendadas.TabIndex = 34;
            this.btnCitasAgendadas.Text = "Ver Citas Agendadas";
            this.btnCitasAgendadas.UseVisualStyleBackColor = false;
            this.btnCitasAgendadas.Click += new System.EventHandler(this.btnCitasAgendadas_Click);
            // 
            // dgvInfoCitas
            // 
            this.dgvInfoCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoCitas.Location = new System.Drawing.Point(1, 187);
            this.dgvInfoCitas.Name = "dgvInfoCitas";
            this.dgvInfoCitas.Size = new System.Drawing.Size(785, 150);
            this.dgvInfoCitas.TabIndex = 29;
            // 
            // frmCalendarioCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.btnCitasAgendadas);
            this.Controls.Add(this.cmbDesplegarHorario);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.cmbDesplegarDoctor);
            this.Controls.Add(this.labcondiciones);
            this.Controls.Add(this.btnEditarCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmCalendarioCitas";
            this.Text = "Calendario de Citas Médicas";
            this.Load += new System.EventHandler(this.frmCalendarioCitas_Load);
            this.panel1.ResumeLayout(false);
            this.pnDatosCita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDesplegarHorario;
        private System.Windows.Forms.ComboBox cmbCentro;
        private System.Windows.Forms.ComboBox cmbDesplegarDoctor;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labcondiciones;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Button btnCitasAgendadas;
        private System.Windows.Forms.Button btnAñadirCita;
        private System.Windows.Forms.Panel pnDatosCita;
        private System.Windows.Forms.DataGridView dgvInfoCitas;
    }
}