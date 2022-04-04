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
            this.tsPadecimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResumen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.fármacosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_BarraMenu
            // 
            this.ms_BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.ms_BarraMenu.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_BarraMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPerfilPersonal,
            this.tsAnaliticas,
            this.tsCalendario,
            this.tsDoctores,
            this.tsPadecimientos,
            this.tsResumen,
            this.tsLogOut});
            this.ms_BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_BarraMenu.Name = "ms_BarraMenu";
            this.ms_BarraMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_BarraMenu.Size = new System.Drawing.Size(975, 26);
            this.ms_BarraMenu.TabIndex = 1;
            this.ms_BarraMenu.Text = "menuStrip1";
            // 
            // tsPerfilPersonal
            // 
            this.tsPerfilPersonal.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPerfilPersonal.ForeColor = System.Drawing.Color.White;
            this.tsPerfilPersonal.Name = "tsPerfilPersonal";
            this.tsPerfilPersonal.Size = new System.Drawing.Size(100, 22);
            this.tsPerfilPersonal.Text = "Mi cuenta";
            this.tsPerfilPersonal.Click += new System.EventHandler(this.tsPerfilPersonal_Click);
            // 
            // tsAnaliticas
            // 
            this.tsAnaliticas.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAnaliticas.ForeColor = System.Drawing.Color.White;
            this.tsAnaliticas.Name = "tsAnaliticas";
            this.tsAnaliticas.Size = new System.Drawing.Size(94, 22);
            this.tsAnaliticas.Text = "Analíticas";
            this.tsAnaliticas.Click += new System.EventHandler(this.tsAnaliticas_Click);
            // 
            // tsCalendario
            // 
            this.tsCalendario.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCalendario.ForeColor = System.Drawing.Color.White;
            this.tsCalendario.Name = "tsCalendario";
            this.tsCalendario.Size = new System.Drawing.Size(234, 22);
            this.tsCalendario.Text = "Calendario de citas médicas";
            this.tsCalendario.Click += new System.EventHandler(this.tsCalendario_Click);
            // 
            // tsDoctores
            // 
            this.tsDoctores.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDoctores.ForeColor = System.Drawing.Color.White;
            this.tsDoctores.Name = "tsDoctores";
            this.tsDoctores.Size = new System.Drawing.Size(85, 22);
            this.tsDoctores.Text = "Doctores";
            this.tsDoctores.Click += new System.EventHandler(this.tsDoctores_Click);
            // 
            // tsPadecimientos
            // 
            this.tsPadecimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fármacosToolStripMenuItem});
            this.tsPadecimientos.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPadecimientos.ForeColor = System.Drawing.Color.White;
            this.tsPadecimientos.Name = "tsPadecimientos";
            this.tsPadecimientos.Size = new System.Drawing.Size(130, 22);
            this.tsPadecimientos.Text = "Padecimientos";
            this.tsPadecimientos.Click += new System.EventHandler(this.tsPadecimientos_Click);
            // 
            // tsResumen
            // 
            this.tsResumen.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsResumen.ForeColor = System.Drawing.Color.White;
            this.tsResumen.Name = "tsResumen";
            this.tsResumen.Size = new System.Drawing.Size(87, 22);
            this.tsResumen.Text = "Resumen";
            this.tsResumen.Click += new System.EventHandler(this.tsResumen_Click);
            // 
            // tsLogOut
            // 
            this.tsLogOut.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tsLogOut.ForeColor = System.Drawing.Color.White;
            this.tsLogOut.Name = "tsLogOut";
            this.tsLogOut.Size = new System.Drawing.Size(73, 22);
            this.tsLogOut.Text = "LogOut";
            this.tsLogOut.Click += new System.EventHandler(this.tsLogOut_Click);
            // 
            // fármacosToolStripMenuItem
            // 
            this.fármacosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.fármacosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fármacosToolStripMenuItem.Name = "fármacosToolStripMenuItem";
            this.fármacosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fármacosToolStripMenuItem.Text = "Fármacos";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 687);
            this.Controls.Add(this.ms_BarraMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_BarraMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem tsPadecimientos;
        private System.Windows.Forms.ToolStripMenuItem tsResumen;
        private System.Windows.Forms.ToolStripMenuItem tsLogOut;
        private System.Windows.Forms.ToolStripMenuItem fármacosToolStripMenuItem;
    }
}

