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
            this.tsAnaliticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoctores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIntervenciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPadecimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResumen = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_BarraMenu
            // 
            this.ms_BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.ms_BarraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPerfilPersonal,
            this.tsAnaliticas,
            this.tsCalendario,
            this.tsDoctores,
            this.tsIntervenciones,
            this.tsPadecimientos,
            this.tsResumen});
            this.ms_BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_BarraMenu.Name = "ms_BarraMenu";
            this.ms_BarraMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_BarraMenu.Size = new System.Drawing.Size(902, 27);
            this.ms_BarraMenu.TabIndex = 1;
            this.ms_BarraMenu.Text = "menuStrip1";
            // 
            // tsPerfilPersonal
            // 
            this.tsPerfilPersonal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsPerfilPersonal.ForeColor = System.Drawing.Color.White;
            this.tsPerfilPersonal.Name = "tsPerfilPersonal";
            this.tsPerfilPersonal.Size = new System.Drawing.Size(119, 23);
            this.tsPerfilPersonal.Text = "Perfil personal";
            this.tsPerfilPersonal.Click += new System.EventHandler(this.tsPerfilPersonal_Click);
            // 
            // tsAnaliticas
            // 
            this.tsAnaliticas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsAnaliticas.ForeColor = System.Drawing.Color.White;
            this.tsAnaliticas.Name = "tsAnaliticas";
            this.tsAnaliticas.Size = new System.Drawing.Size(85, 23);
            this.tsAnaliticas.Text = "Analíticas";
            this.tsAnaliticas.Click += new System.EventHandler(this.tsAnaliticas_Click);
            // 
            // tsCalendario
            // 
            this.tsCalendario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsCalendario.ForeColor = System.Drawing.Color.White;
            this.tsCalendario.Name = "tsCalendario";
            this.tsCalendario.Size = new System.Drawing.Size(208, 23);
            this.tsCalendario.Text = "Calendario de citas médicas";
            this.tsCalendario.Click += new System.EventHandler(this.tsCalendario_Click);
            // 
            // tsDoctores
            // 
            this.tsDoctores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsDoctores.ForeColor = System.Drawing.Color.White;
            this.tsDoctores.Name = "tsDoctores";
            this.tsDoctores.Size = new System.Drawing.Size(81, 23);
            this.tsDoctores.Text = "Doctores";
            this.tsDoctores.Click += new System.EventHandler(this.tsDoctores_Click);
            // 
            // tsIntervenciones
            // 
            this.tsIntervenciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsIntervenciones.ForeColor = System.Drawing.Color.White;
            this.tsIntervenciones.Name = "tsIntervenciones";
            this.tsIntervenciones.Size = new System.Drawing.Size(119, 23);
            this.tsIntervenciones.Text = "Intervenciones";
            this.tsIntervenciones.Click += new System.EventHandler(this.tsIntervenciones_Click);
            // 
            // tsPadecimientos
            // 
            this.tsPadecimientos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsPadecimientos.ForeColor = System.Drawing.Color.White;
            this.tsPadecimientos.Name = "tsPadecimientos";
            this.tsPadecimientos.Size = new System.Drawing.Size(119, 23);
            this.tsPadecimientos.Text = "Padecimientos";
            this.tsPadecimientos.Click += new System.EventHandler(this.tsPadecimientos_Click);
            // 
            // tsResumen
            // 
            this.tsResumen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsResumen.ForeColor = System.Drawing.Color.White;
            this.tsResumen.Name = "tsResumen";
            this.tsResumen.Size = new System.Drawing.Size(81, 23);
            this.tsResumen.Text = "Resumen";
            this.tsResumen.Click += new System.EventHandler(this.tsResumen_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 687);
            this.Controls.Add(this.ms_BarraMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_BarraMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.ms_BarraMenu.ResumeLayout(false);
            this.ms_BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem tsPerfilPersonal;
        private System.Windows.Forms.ToolStripMenuItem tsAnaliticas;
        private System.Windows.Forms.ToolStripMenuItem tsCalendario;
        private System.Windows.Forms.ToolStripMenuItem tsDoctores;
        private System.Windows.Forms.ToolStripMenuItem tsIntervenciones;
        private System.Windows.Forms.ToolStripMenuItem tsPadecimientos;
        private System.Windows.Forms.ToolStripMenuItem tsResumen;
    }
}

