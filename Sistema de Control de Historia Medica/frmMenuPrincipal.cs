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
    public partial class frmMenuPrincipal : Form
    {
        static public int vIdUsuario = 0;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsPerfilPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPerfilPersonal());
        }

        private void tsAnaliticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAnaliticas());
        }

        private void tsCalendario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCalendarioCitas());
        }

        private void tsDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDoctores());
        }

        private void tsIntervenciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDoctores());
        }

        private void tsPadecimientos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPadecimientos());
        }

        private void tsResumen_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResumen());
        }
        static public bool EstaAbierto()
        {
            if(Application.OpenForms.Count > 1) return true;
            else return false;
        }
        private void AbrirFormulario(Form frm)
        {
            if (!EstaAbierto()) //si no hay formularios abiertos
            {
                frm.MdiParent = this; //Asignamos a ese objeto el formulario padre, que será este
                frm.StartPosition = FormStartPosition.CenterScreen;//Centrar el formulario en la pantalla
                frm.Show(); //Mostrar el formulario
            }
            else MessageBox.Show("Cierre la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
