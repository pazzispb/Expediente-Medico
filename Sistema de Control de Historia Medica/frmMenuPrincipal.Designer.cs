namespace Sistema_de_Control_de_Historia_Medica
{
    partial class frmMenuPrincipal
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
            this.ms_BarraMenu = new System.Windows.Forms.MenuStrip();
            this.tsMiPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_BarraMenu
            // 
            this.ms_BarraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMiPerfil});
            this.ms_BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_BarraMenu.Name = "ms_BarraMenu";
            this.ms_BarraMenu.Size = new System.Drawing.Size(1118, 28);
            this.ms_BarraMenu.TabIndex = 1;
            this.ms_BarraMenu.Text = "menuStrip1";
            // 
            // tsMiPerfil
            // 
            this.tsMiPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem1});
            this.tsMiPerfil.Name = "tsMiPerfil";
            this.tsMiPerfil.Size = new System.Drawing.Size(79, 24);
            this.tsMiPerfil.Text = "Mi perfil";
            this.tsMiPerfil.Click += new System.EventHandler(this.tsMiPerfil_Click);
            // 
            // pruebaToolStripMenuItem1
            // 
            this.pruebaToolStripMenuItem1.Name = "pruebaToolStripMenuItem1";
            this.pruebaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pruebaToolStripMenuItem1.Text = "Prueba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 627);
            this.Controls.Add(this.ms_BarraMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_BarraMenu;
            this.Name = "Form1";
            this.Text = "Menú principal";
            this.ms_BarraMenu.ResumeLayout(false);
            this.ms_BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMiPerfil;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem1;
    }
}

