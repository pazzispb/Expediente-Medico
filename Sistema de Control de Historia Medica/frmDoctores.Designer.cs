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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificarDoctor = new System.Windows.Forms.Button();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.btnAñadirDoctor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerDoctores = new System.Windows.Forms.Button();
            this.pnRegistrarDoctor = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnRegistrarDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(112, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 28);
            this.txtNombre.TabIndex = 4;
            // 
            // labTitulo
            // 
            this.labTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitulo.CausesValidation = false;
            this.labTitulo.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(375, 9);
            this.labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labTitulo.Size = new System.Drawing.Size(361, 45);
            this.labTitulo.TabIndex = 5;
            this.labTitulo.Text = "Registrar Doctor";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(16, 26);
            this.labNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(87, 24);
            this.labNombre.TabIndex = 6;
            this.labNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnModificarDoctor);
            this.panel1.Controls.Add(this.btnEliminarDoctor);
            this.panel1.Controls.Add(this.btnAñadirDoctor);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnVerDoctores);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 511);
            this.panel1.TabIndex = 7;
            // 
            // btnModificarDoctor
            // 
            this.btnModificarDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnModificarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarDoctor.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarDoctor.Location = new System.Drawing.Point(381, 460);
            this.btnModificarDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDoctor.Name = "btnModificarDoctor";
            this.btnModificarDoctor.Size = new System.Drawing.Size(152, 43);
            this.btnModificarDoctor.TabIndex = 38;
            this.btnModificarDoctor.Text = "Modificar";
            this.btnModificarDoctor.UseVisualStyleBackColor = false;
            this.btnModificarDoctor.Click += new System.EventHandler(this.btnModificarDoctor_Click);
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEliminarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(181, 460);
            this.btnEliminarDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(152, 43);
            this.btnEliminarDoctor.TabIndex = 37;
            this.btnEliminarDoctor.Text = "Eliminar";
            this.btnEliminarDoctor.UseVisualStyleBackColor = false;
            this.btnEliminarDoctor.Click += new System.EventHandler(this.btnEliminarDoctor_Click);
            // 
            // btnAñadirDoctor
            // 
            this.btnAñadirDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAñadirDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAñadirDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirDoctor.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirDoctor.Location = new System.Drawing.Point(772, 460);
            this.btnAñadirDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirDoctor.Name = "btnAñadirDoctor";
            this.btnAñadirDoctor.Size = new System.Drawing.Size(152, 43);
            this.btnAñadirDoctor.TabIndex = 36;
            this.btnAñadirDoctor.Text = "Añadir";
            this.btnAñadirDoctor.UseVisualStyleBackColor = false;
            this.btnAñadirDoctor.Click += new System.EventHandler(this.btnAñadirDoctor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 245);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnVerDoctores
            // 
            this.btnVerDoctores.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerDoctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnVerDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDoctores.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDoctores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerDoctores.Location = new System.Drawing.Point(577, 460);
            this.btnVerDoctores.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDoctores.Name = "btnVerDoctores";
            this.btnVerDoctores.Size = new System.Drawing.Size(152, 43);
            this.btnVerDoctores.TabIndex = 35;
            this.btnVerDoctores.Text = "Ver doctores";
            this.btnVerDoctores.UseVisualStyleBackColor = false;
            this.btnVerDoctores.Click += new System.EventHandler(this.btnVerDoctores_Click_1);
            // 
            // pnRegistrarDoctor
            // 
            this.pnRegistrarDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRegistrarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.pnRegistrarDoctor.Controls.Add(this.label2);
            this.pnRegistrarDoctor.Controls.Add(this.labCentroDeSalud);
            this.pnRegistrarDoctor.Controls.Add(this.txtCentroDeSalud);
            this.pnRegistrarDoctor.Controls.Add(this.label1);
            this.pnRegistrarDoctor.Controls.Add(this.labTelefono);
            this.pnRegistrarDoctor.Controls.Add(this.txtTelefono);
            this.pnRegistrarDoctor.Controls.Add(this.label4);
            this.pnRegistrarDoctor.Controls.Add(this.labEspecialidad);
            this.pnRegistrarDoctor.Controls.Add(this.txtEspecialidad);
            this.pnRegistrarDoctor.Controls.Add(this.label3);
            this.pnRegistrarDoctor.Controls.Add(this.labNombre);
            this.pnRegistrarDoctor.Controls.Add(this.txtNombre);
            this.pnRegistrarDoctor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRegistrarDoctor.Location = new System.Drawing.Point(0, 60);
            this.pnRegistrarDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.pnRegistrarDoctor.Name = "pnRegistrarDoctor";
            this.pnRegistrarDoctor.Size = new System.Drawing.Size(1097, 133);
            this.pnRegistrarDoctor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(976, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 14;
            // 
            // labCentroDeSalud
            // 
            this.labCentroDeSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCentroDeSalud.AutoSize = true;
            this.labCentroDeSalud.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCentroDeSalud.Location = new System.Drawing.Point(663, 85);
            this.labCentroDeSalud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCentroDeSalud.Name = "labCentroDeSalud";
            this.labCentroDeSalud.Size = new System.Drawing.Size(155, 24);
            this.labCentroDeSalud.TabIndex = 15;
            this.labCentroDeSalud.Text = "Centro de salud:";
            // 
            // txtCentroDeSalud
            // 
            this.txtCentroDeSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCentroDeSalud.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroDeSalud.Location = new System.Drawing.Point(831, 81);
            this.txtCentroDeSalud.Margin = new System.Windows.Forms.Padding(4);
            this.txtCentroDeSalud.Name = "txtCentroDeSalud";
            this.txtCentroDeSalud.Size = new System.Drawing.Size(229, 28);
            this.txtCentroDeSalud.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 11;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(13, 81);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(92, 24);
            this.labTelefono.TabIndex = 12;
            this.labTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(112, 80);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 28);
            this.txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(976, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 8;
            // 
            // labEspecialidad
            // 
            this.labEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labEspecialidad.AutoSize = true;
            this.labEspecialidad.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspecialidad.Location = new System.Drawing.Point(691, 27);
            this.labEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEspecialidad.Name = "labEspecialidad";
            this.labEspecialidad.Size = new System.Drawing.Size(126, 24);
            this.labEspecialidad.TabIndex = 9;
            this.labEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEspecialidad.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(831, 26);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(229, 28);
            this.txtEspecialidad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 5;
            // 
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1099, 511);
            this.Controls.Add(this.pnRegistrarDoctor);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmDoctores";
            this.Text = "Registro de Doctores";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnRegistrarDoctor.ResumeLayout(false);
            this.pnRegistrarDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRegistrarDoctor;
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
        private System.Windows.Forms.Button btnVerDoctores;
        private System.Windows.Forms.Button btnAñadirDoctor;
        private System.Windows.Forms.Button btnModificarDoctor;
        private System.Windows.Forms.Button btnEliminarDoctor;
    }
}