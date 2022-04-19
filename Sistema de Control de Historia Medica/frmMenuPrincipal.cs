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
        bool vCancelarCierre = true; //Variable para ibhabilitar que el formulario se cierre
        static public string vIdUsuario; //Variable que el almacena el id del usuario con la sesion iniciada
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsPerfilPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPerfilPersonal()); //Abre el formulario Perfil Personal
        }

        private void tsAnaliticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAnaliticas()); //Abre el formulario Analiticas
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
            if(Application.OpenForms.Count > 2) return true; //Si hay formularios abiertos aparte del Menu Principal
            else return false;
        }
        public void AbrirFormulario(Form frm) //Recibo un formulario
        {
            if (!EstaAbierto()) //si no hay formularios abiertos a parte del menu principal me permite abrir uno
            {
                frm.MdiParent = this; //Asignamos a ese objeto el formulario padre, que será este
                frm.StartPosition = FormStartPosition.CenterScreen;//Centrar el formulario en la pantalla
                frm.Show(); //Mostrar el formulario
            }
            else
            {
                if(MessageBox.Show("Cierre la funcionalidad abierta. ¿Desea cerrarla para abrir la otra?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (Form frm1 in Application.OpenForms) //Recorre los formularios abiertos
                        if (!(typeof(frmLogIn) == frm1.GetType()) && !(typeof(frmMenuPrincipal) == frm1.GetType())) //Si no es el formulario del Login o del menu principal
                        {
                            frm1.Close();
                            frm.MdiParent = this; //Asignamos a ese objeto el formulario padre, que será este
                            frm.StartPosition = FormStartPosition.CenterScreen;//Centrar el formulario en la pantalla
                            frm.Show(); //Mostrar el formulario
                            break; //Sal del bucle
                        }
                }
                else
                {
                    MessageBox.Show("Debe cerrar la funcionalidad abierta antes de proceder con la otra", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = vCancelarCierre; //Evita (true) o autoriza (false) el cierre del formulario
            if (vCancelarCierre == true)
                if(MessageBox.Show("¿Desea cerrar la sesión?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (Form frm in Application.OpenForms) //Recorre los formularios abiertos
                        if (typeof(frmLogIn) == frm.GetType()) //Buscar el formulario de LogIn
                        {
                            frm.Show(); //Muestra el formulario
                            vCancelarCierre = false; //Permite el cierre del formulario de Menu
                            break; //Sal del bucle
                        }
                    e.Cancel = vCancelarCierre;
                }
                else
                {
                    MessageBox.Show("Debe cerrar la sesión antes de salir", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private void tsLogOut_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms) //Recorre los formularios abiertos
                if (typeof(frmLogIn) == frm.GetType()) //Buscar el formulario de LogIn
                {
                    frm.Show(); //Muestra el formulario
                    vCancelarCierre = false; //Permite el cierre del formulario de Menu
                    this.Close(); //Cierra el formulario
                    break; //Sal del bucle
                }
        }
        private void fármacosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFarmacos()); //Abre el formulario frmFarmacos
        }
    }
}
