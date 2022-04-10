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
            this.txtNombre.Location = new System.Drawing.Point(84, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // labTitulo
            // 
            this.labTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTitulo.CausesValidation = false;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(269, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labTitulo.Size = new System.Drawing.Size(184, 25);
            this.labTitulo.TabIndex = 5;
            this.labTitulo.Text = "Registrar Doctor";
            this.labTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTitulo.Click += new System.EventHandler(this.labTitulo_Click);
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
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnModificarDoctor);
            this.panel1.Controls.Add(this.btnEliminarDoctor);
            this.panel1.Controls.Add(this.btnAñadirDoctor);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnVerDoctores);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 415);
            this.panel1.TabIndex = 7;
            // 
            // btnModificarDoctor
            // 
            this.btnModificarDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnModificarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarDoctor.Location = new System.Drawing.Point(247, 374);
            this.btnModificarDoctor.Name = "btnModificarDoctor";
            this.btnModificarDoctor.Size = new System.Drawing.Size(114, 35);
            this.btnModificarDoctor.TabIndex = 38;
            this.btnModificarDoctor.Text = "Modificar";
            this.btnModificarDoctor.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(97, 374);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(114, 35);
            this.btnEliminarDoctor.TabIndex = 37;
            this.btnEliminarDoctor.Text = "Eliminar";
            this.btnEliminarDoctor.UseVisualStyleBackColor = false;
            this.btnEliminarDoctor.Click += new System.EventHandler(this.btnEliminarDoctor_Click);
            // 
            // btnAñadirDoctor
            // 
            this.btnAñadirDoctor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAñadirDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAñadirDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirDoctor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirDoctor.Location = new System.Drawing.Point(540, 374);
            this.btnAñadirDoctor.Name = "btnAñadirDoctor";
            this.btnAñadirDoctor.Size = new System.Drawing.Size(114, 35);
            this.btnAñadirDoctor.TabIndex = 36;
            this.btnAñadirDoctor.Text = "Añadir";
            this.btnAñadirDoctor.UseVisualStyleBackColor = false;
            this.btnAñadirDoctor.Click += new System.EventHandler(this.btnAñadirDoctor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(746, 199);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnVerDoctores
            // 
            this.btnVerDoctores.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerDoctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnVerDoctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDoctores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerDoctores.Location = new System.Drawing.Point(394, 374);
            this.btnVerDoctores.Name = "btnVerDoctores";
            this.btnVerDoctores.Size = new System.Drawing.Size(114, 35);
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
            this.pnRegistrarDoctor.Location = new System.Drawing.Point(0, 49);
            this.pnRegistrarDoctor.Name = "pnRegistrarDoctor";
            this.pnRegistrarDoctor.Size = new System.Drawing.Size(746, 108);
            this.pnRegistrarDoctor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 14;
            // 
            // labCentroDeSalud
            // 
            this.labCentroDeSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labCentroDeSalud.AutoSize = true;
            this.labCentroDeSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCentroDeSalud.Location = new System.Drawing.Point(420, 69);
            this.labCentroDeSalud.Name = "labCentroDeSalud";
            this.labCentroDeSalud.Size = new System.Drawing.Size(120, 16);
            this.labCentroDeSalud.TabIndex = 15;
            this.labCentroDeSalud.Text = "Centro de salud:";
            // 
            // txtCentroDeSalud
            // 
            this.txtCentroDeSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCentroDeSalud.Location = new System.Drawing.Point(546, 66);
            this.txtCentroDeSalud.Name = "txtCentroDeSalud";
            this.txtCentroDeSalud.Size = new System.Drawing.Size(173, 20);
            this.txtCentroDeSalud.TabIndex = 13;
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 8;
            // 
            // labEspecialidad
            // 
            this.labEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labEspecialidad.AutoSize = true;
            this.labEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspecialidad.Location = new System.Drawing.Point(441, 22);
            this.labEspecialidad.Name = "labEspecialidad";
            this.labEspecialidad.Size = new System.Drawing.Size(103, 16);
            this.labEspecialidad.TabIndex = 9;
            this.labEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEspecialidad.Location = new System.Drawing.Point(546, 21);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(173, 20);
            this.txtEspecialidad.TabIndex = 7;
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
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.pnRegistrarDoctor);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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