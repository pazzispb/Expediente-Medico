﻿namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmRegistrarPadecimientos
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
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.chbEstadoFecha = new System.Windows.Forms.CheckBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.cmbTipoPadecimiento = new System.Windows.Forms.ComboBox();
            this.dtpFechaPadecimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarPadecimiento = new System.Windows.Forms.Button();
            this.txtDescripcionPadecimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.pnContenedor.Controls.Add(this.chbEstadoFecha);
            this.pnContenedor.Controls.Add(this.txtPadecimiento);
            this.pnContenedor.Controls.Add(this.cmbTipoPadecimiento);
            this.pnContenedor.Controls.Add(this.dtpFechaPadecimiento);
            this.pnContenedor.Controls.Add(this.btnCancelar);
            this.pnContenedor.Controls.Add(this.btnGuardarPadecimiento);
            this.pnContenedor.Controls.Add(this.txtDescripcionPadecimiento);
            this.pnContenedor.Controls.Add(this.label5);
            this.pnContenedor.Controls.Add(this.label4);
            this.pnContenedor.Controls.Add(this.label3);
            this.pnContenedor.Controls.Add(this.label2);
            this.pnContenedor.Location = new System.Drawing.Point(16, 68);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(897, 266);
            this.pnContenedor.TabIndex = 16;
            // 
            // chbEstadoFecha
            // 
            this.chbEstadoFecha.AutoSize = true;
            this.chbEstadoFecha.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEstadoFecha.Location = new System.Drawing.Point(211, 199);
            this.chbEstadoFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbEstadoFecha.Name = "chbEstadoFecha";
            this.chbEstadoFecha.Size = new System.Drawing.Size(113, 28);
            this.chbEstadoFecha.TabIndex = 39;
            this.chbEstadoFecha.Text = "No aplica";
            this.chbEstadoFecha.UseVisualStyleBackColor = true;
            this.chbEstadoFecha.CheckedChanged += new System.EventHandler(this.chbEstadoFecha_CheckedChanged);
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPadecimiento.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadecimiento.Location = new System.Drawing.Point(211, 108);
            this.txtPadecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(184, 28);
            this.txtPadecimiento.TabIndex = 38;
            // 
            // cmbTipoPadecimiento
            // 
            this.cmbTipoPadecimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoPadecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPadecimiento.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPadecimiento.FormattingEnabled = true;
            this.cmbTipoPadecimiento.Items.AddRange(new object[] {
            "Enfermedad",
            "Cirugía",
            "Emergencia",
            "Alergia",
            "Condición"});
            this.cmbTipoPadecimiento.Location = new System.Drawing.Point(211, 55);
            this.cmbTipoPadecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPadecimiento.Name = "cmbTipoPadecimiento";
            this.cmbTipoPadecimiento.Size = new System.Drawing.Size(184, 32);
            this.cmbTipoPadecimiento.TabIndex = 37;
            // 
            // dtpFechaPadecimiento
            // 
            this.dtpFechaPadecimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaPadecimiento.Checked = false;
            this.dtpFechaPadecimiento.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPadecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPadecimiento.Location = new System.Drawing.Point(211, 167);
            this.dtpFechaPadecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaPadecimiento.Name = "dtpFechaPadecimiento";
            this.dtpFechaPadecimiento.Size = new System.Drawing.Size(184, 28);
            this.dtpFechaPadecimiento.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(709, 185);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 41);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarPadecimiento
            // 
            this.btnGuardarPadecimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarPadecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.btnGuardarPadecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarPadecimiento.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPadecimiento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPadecimiento.Location = new System.Drawing.Point(473, 185);
            this.btnGuardarPadecimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPadecimiento.Name = "btnGuardarPadecimiento";
            this.btnGuardarPadecimiento.Size = new System.Drawing.Size(231, 41);
            this.btnGuardarPadecimiento.TabIndex = 34;
            this.btnGuardarPadecimiento.Text = "Guardar datos";
            this.btnGuardarPadecimiento.UseVisualStyleBackColor = false;
            this.btnGuardarPadecimiento.Click += new System.EventHandler(this.btnGuardarPadecimiento_Click);
            // 
            // txtDescripcionPadecimiento
            // 
            this.txtDescripcionPadecimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcionPadecimiento.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPadecimiento.Location = new System.Drawing.Point(473, 68);
            this.txtDescripcionPadecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPadecimiento.Multiline = true;
            this.txtDescripcionPadecimiento.Name = "txtDescripcionPadecimiento";
            this.txtDescripcionPadecimiento.Size = new System.Drawing.Size(361, 105);
            this.txtDescripcionPadecimiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Padecimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datos del Padecimiento";
            // 
            // frmRegistrarPadecimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistrarPadecimientos";
            this.Text = " Registro de Padecimeinto";
            this.Load += new System.EventHandler(this.frmRegistrarPadecimientos_Load);
            this.pnContenedor.ResumeLayout(false);
            this.pnContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionPadecimiento;
        private System.Windows.Forms.Button btnGuardarPadecimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaPadecimiento;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.ComboBox cmbTipoPadecimiento;
        private System.Windows.Forms.CheckBox chbEstadoFecha;
    }
}