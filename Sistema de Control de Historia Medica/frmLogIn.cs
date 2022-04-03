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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario(new frmCrearCuenta()); //Muestra el formulario de Crear Cuenta
        }
        public void AbrirFormulario(Form frm) //Recibe el formulario que deseo abrir
        {
            if (Application.OpenForms.Count < 2) //Verificamos que solamente este abierto el formulario de LogIn
            {
                frm.Show(); 
            }
            else MessageBox.Show("Cierre la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2) this.Hide(); //Verifica que solo tiene el LogIn abierto
            AbrirFormulario(new frmMenuPrincipal()); //Abre el formulario de Menu Principal
            frmMenuPrincipal.vIdUsuario = "1";//Indicamos el ID del usuario que ingreso al sistema
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario(new frmRecuperarContrasena()); //Abre el formulario de Menu Principal
        }

        private void lbRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario(new frmRecuperarContrasena()); //Abre el formulario de Menu Principal
        }
    }
}