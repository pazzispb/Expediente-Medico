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
            this.tsPerfilPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_BarraMenu
            // 
            this.ms_BarraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPerfilPersonal});
            this.ms_BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_BarraMenu.Name = "ms_BarraMenu";
            this.ms_BarraMenu.Size = new System.Drawing.Size(597, 28);
            this.ms_BarraMenu.TabIndex = 1;
            this.ms_BarraMenu.Text = "menuStrip1";
            // 
            // tsPerfilPersonal
            // 
            this.tsPerfilPersonal.Name = "tsPerfilPersonal";
            this.tsPerfilPersonal.Size = new System.Drawing.Size(117, 24);
            this.tsPerfilPersonal.Text = "Perfil personal";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 541);
            this.Controls.Add(this.ms_BarraMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_BarraMenu;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú principal";
            this.ms_BarraMenu.ResumeLayout(false);
            this.ms_BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem tsPerfilPersonal;
    }
}

