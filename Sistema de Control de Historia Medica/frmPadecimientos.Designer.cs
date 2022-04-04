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
            this.btnEditarPadecimientos = new System.Windows.Forms.Button();
            this.btnAñadirPadecimientos = new System.Windows.Forms.Button();
            this.btnEliminarPadecimientos = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labantecedentes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCirugias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labcondiciones = new System.Windows.Forms.Label();
            this.listboxCondiciones = new System.Windows.Forms.ListBox();
            this.listBoxCirugias = new System.Windows.Forms.ListBox();
            this.checkedListBoxAntecedentes = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditarPadecimientos
            // 
            this.btnEditarPadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEditarPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarPadecimientos.Location = new System.Drawing.Point(355, 417);
            this.btnEditarPadecimientos.Name = "btnEditarPadecimientos";
            this.btnEditarPadecimientos.Size = new System.Drawing.Size(99, 34);
            this.btnEditarPadecimientos.TabIndex = 11;
            this.btnEditarPadecimientos.Text = "Editar";
            this.btnEditarPadecimientos.UseVisualStyleBackColor = false;
            // 
            // btnAñadirPadecimientos
            // 
            this.btnAñadirPadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnAñadirPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAñadirPadecimientos.Location = new System.Drawing.Point(540, 417);
            this.btnAñadirPadecimientos.Name = "btnAñadirPadecimientos";
            this.btnAñadirPadecimientos.Size = new System.Drawing.Size(104, 34);
            this.btnAñadirPadecimientos.TabIndex = 12;
            this.btnAñadirPadecimientos.Text = "Añadir ";
            this.btnAñadirPadecimientos.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPadecimientos
            // 
            this.btnEliminarPadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnEliminarPadecimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPadecimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPadecimientos.Location = new System.Drawing.Point(166, 417);
            this.btnEliminarPadecimientos.Name = "btnEliminarPadecimientos";
            this.btnEliminarPadecimientos.Size = new System.Drawing.Size(110, 34);
            this.btnEliminarPadecimientos.TabIndex = 13;
            this.btnEliminarPadecimientos.Text = "Eliminar";
            this.btnEliminarPadecimientos.UseVisualStyleBackColor = false;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(266, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(267, 25);
            this.labTitulo.TabIndex = 14;
            this.labTitulo.Text = "Registrar padecimientos";
            this.labTitulo.Click += new System.EventHandler(this.labTitulo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.checkedListBoxAntecedentes);
            this.panel2.Controls.Add(this.listBoxCirugias);
            this.panel2.Controls.Add(this.listboxCondiciones);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labantecedentes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labCirugias);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labcondiciones);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 341);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 14;
            // 
            // labantecedentes
            // 
            this.labantecedentes.AutoSize = true;
            this.labantecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labantecedentes.Location = new System.Drawing.Point(560, 21);
            this.labantecedentes.Name = "labantecedentes";
            this.labantecedentes.Size = new System.Drawing.Size(178, 16);
            this.labantecedentes.TabIndex = 15;
            this.labantecedentes.Text = "Antecedentes familiares:";
            this.labantecedentes.Click += new System.EventHandler(this.labCentroDeSalud_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 8;
            // 
            // labCirugias
            // 
            this.labCirugias.AutoSize = true;
            this.labCirugias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCirugias.Location = new System.Drawing.Point(321, 21);
            this.labCirugias.Name = "labCirugias";
            this.labCirugias.Size = new System.Drawing.Size(68, 16);
            this.labCirugias.TabIndex = 9;
            this.labCirugias.Text = "Cirugias:";
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
            // labcondiciones
            // 
            this.labcondiciones.AutoSize = true;
            this.labcondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcondiciones.Location = new System.Drawing.Point(12, 21);
            this.labcondiciones.Name = "labcondiciones";
            this.labcondiciones.Size = new System.Drawing.Size(178, 16);
            this.labcondiciones.TabIndex = 6;
            this.labcondiciones.Text = "Condiciones especiales:";
            this.labcondiciones.Click += new System.EventHandler(this.labNombre_Click);
            // 
            // listboxCondiciones
            // 
            this.listboxCondiciones.FormattingEnabled = true;
            this.listboxCondiciones.Location = new System.Drawing.Point(15, 40);
            this.listboxCondiciones.Name = "listboxCondiciones";
            this.listboxCondiciones.Size = new System.Drawing.Size(172, 82);
            this.listboxCondiciones.TabIndex = 16;
            // 
            // listBoxCirugias
            // 
            this.listBoxCirugias.FormattingEnabled = true;
            this.listBoxCirugias.Location = new System.Drawing.Point(270, 40);
            this.listBoxCirugias.Name = "listBoxCirugias";
            this.listBoxCirugias.Size = new System.Drawing.Size(172, 82);
            this.listBoxCirugias.TabIndex = 17;
            // 
            // checkedListBoxAntecedentes
            // 
            this.checkedListBoxAntecedentes.FormattingEnabled = true;
            this.checkedListBoxAntecedentes.Items.AddRange(new object[] {
            "Tuberculosis",
            "Diabetes",
            "Hipertensión"});
            this.checkedListBoxAntecedentes.Location = new System.Drawing.Point(563, 40);
            this.checkedListBoxAntecedentes.Name = "checkedListBoxAntecedentes";
            this.checkedListBoxAntecedentes.Size = new System.Drawing.Size(178, 79);
            this.checkedListBoxAntecedentes.TabIndex = 18;
            // 
            // frmPadecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnEliminarPadecimientos);
            this.Controls.Add(this.btnAñadirPadecimientos);
            this.Controls.Add(this.btnEditarPadecimientos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmPadecimientos";
            this.Text = "Registro de Padecimientos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarPadecimientos;
        private System.Windows.Forms.Button btnAñadirPadecimientos;
        private System.Windows.Forms.Button btnEliminarPadecimientos;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labantecedentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCirugias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labcondiciones;
        private System.Windows.Forms.ListBox listboxCondiciones;
        private System.Windows.Forms.ListBox listBoxCirugias;
        private System.Windows.Forms.CheckedListBox checkedListBoxAntecedentes;
    }
}