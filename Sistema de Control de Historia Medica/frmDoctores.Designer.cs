namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmDoctores
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
            this.btnAñadirDoctor = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labCentroDeSalud = new System.Windows.Forms.Label();
            this.txtCentroDeSalud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroDeSalud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarDoctor = new System.Windows.Forms.Button();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadirDoctor
            // 
            this.btnAñadirDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAñadirDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirDoctor.Location = new System.Drawing.Point(399, 325);
            this.btnAñadirDoctor.Name = "btnAñadirDoctor";
            this.btnAñadirDoctor.Size = new System.Drawing.Size(136, 34);
            this.btnAñadirDoctor.TabIndex = 1;
            this.btnAñadirDoctor.Text = "Añadir Doctor/a";
            this.btnAñadirDoctor.UseVisualStyleBackColor = false;
            this.btnAñadirDoctor.Click += new System.EventHandler(this.btnAñadirDoctor_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(209, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(184, 25);
            this.labTitulo.TabIndex = 5;
            this.labTitulo.Text = "Registrar Doctor";
            this.labTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(12, 21);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(66, 16);
            this.labNombre.TabIndex = 6;
            this.labNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 55);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labCentroDeSalud);
            this.panel2.Controls.Add(this.txtCentroDeSalud);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labTelefono);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labEspecialidad);
            this.panel2.Controls.Add(this.txtEspecialidad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labNombre);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 108);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labCentroDeSalud
            // 
            this.labCentroDeSalud.AutoSize = true;
            this.labCentroDeSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCentroDeSalud.Location = new System.Drawing.Point(273, 69);
            this.labCentroDeSalud.Name = "labCentroDeSalud";
            this.labCentroDeSalud.Size = new System.Drawing.Size(120, 16);
            this.labCentroDeSalud.TabIndex = 15;
            this.labCentroDeSalud.Text = "Centro de salud:";
            this.labCentroDeSalud.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtCentroDeSalud
            // 
            this.txtCentroDeSalud.Location = new System.Drawing.Point(399, 66);
            this.txtCentroDeSalud.Multiline = true;
            this.txtCentroDeSalud.Name = "txtCentroDeSalud";
            this.txtCentroDeSalud.Size = new System.Drawing.Size(173, 20);
            this.txtCentroDeSalud.TabIndex = 13;
            this.txtCentroDeSalud.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 11;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(10, 66);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(73, 16);
            this.labTelefono.TabIndex = 12;
            this.labTelefono.Text = "Teléfono:";
            this.labTelefono.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 65);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(173, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labEspecialidad
            // 
            this.labEspecialidad.AutoSize = true;
            this.labEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspecialidad.Location = new System.Drawing.Point(294, 22);
            this.labEspecialidad.Name = "labEspecialidad";
            this.labEspecialidad.Size = new System.Drawing.Size(103, 16);
            this.labEspecialidad.TabIndex = 9;
            this.labEspecialidad.Text = "Especialidad:";
            this.labEspecialidad.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(399, 21);
            this.txtEspecialidad.Multiline = true;
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(173, 20);
            this.txtEspecialidad.TabIndex = 7;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Especialidad,
            this.Teléfono,
            this.CentroDeSalud});
            this.dataGridView1.Location = new System.Drawing.Point(0, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(599, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 140;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 144;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 6;
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            this.Teléfono.Width = 130;
            // 
            // CentroDeSalud
            // 
            this.CentroDeSalud.HeaderText = "Centro de salud";
            this.CentroDeSalud.MinimumWidth = 6;
            this.CentroDeSalud.Name = "CentroDeSalud";
            this.CentroDeSalud.ReadOnly = true;
            this.CentroDeSalud.Width = 140;
            // 
            // btnEditarDoctor
            // 
            this.btnEditarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEditarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarDoctor.Location = new System.Drawing.Point(252, 325);
            this.btnEditarDoctor.Name = "btnEditarDoctor";
            this.btnEditarDoctor.Size = new System.Drawing.Size(99, 34);
            this.btnEditarDoctor.TabIndex = 10;
            this.btnEditarDoctor.Text = "Editar";
            this.btnEditarDoctor.UseVisualStyleBackColor = false;
            this.btnEditarDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(70, 325);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(136, 34);
            this.btnEliminarDoctor.TabIndex = 11;
            this.btnEliminarDoctor.Text = "Eliminar";
            this.btnEliminarDoctor.UseVisualStyleBackColor = false;
            // 
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEliminarDoctor);
            this.Controls.Add(this.btnEditarDoctor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAñadirDoctor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmDoctores";
            this.Text = "Registro de Doctores";
            this.Load += new System.EventHandler(this.frmDoctores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAñadirDoctor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCentroDeSalud;
        private System.Windows.Forms.TextBox txtCentroDeSalud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroDeSalud;
        private System.Windows.Forms.Button btnEditarDoctor;
        private System.Windows.Forms.Button btnEliminarDoctor;
    }
}