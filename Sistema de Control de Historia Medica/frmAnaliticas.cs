using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmAnaliticas : Form
    {
        public frmAnaliticas()
        {
            InitializeComponent();
        }
        private void frmAnaliticas_Load(object sender, EventArgs e)
        {
            
        }
        private void btnRegistrarAnalitica_Click(object sender, EventArgs e)
        {
            if (!EstaAbierto())
            {
                frmRegistrarAnalitica frm = new frmRegistrarAnalitica();
                frm.MdiParent = this.MdiParent;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static public bool EstaAbierto()
        {
            if (Application.OpenForms.Count > 3) return true; //Si hay formularios abiertos aparte del Menu Principal
            else return false;
        }
    }
}
