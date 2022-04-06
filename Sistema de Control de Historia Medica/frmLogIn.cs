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
        clsBaseDatos bd = new clsBaseDatos(); //objeto de base de datos
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
            if (ValidarCamposRellenos()) //Llamamos la funcion para validar los campos rellenos
            {
                string vConsulta = $"SELECT COUNT(idUsuario) FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND clave = '{txtContrasena.Text}' "; // Cantidad de usuarios que comparten el mismo nombre y contrasena
                int vResultados = Convert.ToInt32(bd.ConsultarValor(vConsulta));

                if (vResultados == 1 )
                {
                    if (Application.OpenForms.Count < 2) this.Hide(); //Verifica que solo tiene el LogIn abierto
                    AbrirFormulario(new frmMenuPrincipal()); //Abre el formulario de Menu Principal
                    vConsulta = $"SELECT idUsuario FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND clave = '{txtContrasena.Text}' "; // Cantidad de usuarios que comparten el mismo nombre y contrasena
                    frmMenuPrincipal.vIdUsuario = bd.ConsultarValor(vConsulta).ToString();//Indicamos el ID del usuario que ingreso al sistema
                }
                else MessageBox.Show("Usuario y/o contraseña errónea", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }
        bool ValidarCamposRellenos()
        {
            
            if (String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtContrasena.Text)) //Si esta vacio
            {
                MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; //retorna que hay campos no rellenos
            }
            return true; //retorna que los campos estan rellenos
        }

        private void lblRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario(new frmRecuperarContrasena()); //Abre el formulario de Recuperar Contraseña

        }


    }
}