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
    public partial class frmRecuperarContrasena : Form
    {
        clsBaseDatos bd = new clsBaseDatos(); //objeto de base de datos
        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposRellenos()) //validamos que no hayan campos rellenos
            {
                string vConsulta = $"SELECT COUNT(idUsuario) FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND cedula = '{txtCedula.Text}' ";
                int vResultados = Convert.ToInt32(bd.ConsultarValor(vConsulta)); //Cantidad de usuarios que comparten el mismo usernmae y cedula
                if (vResultados == 1) //si existe uno
                {
                    vConsulta = $"SELECT clave FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND cedula = '{txtCedula.Text}' ";
                    MessageBox.Show(bd.ConsultarValor(vConsulta).ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);//mostramos la clave del usuario
                }
                else MessageBox.Show("No existe usuario con esa cédula y/o username", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }
        bool ValidarCamposRellenos()
        {
            foreach (Control c in Controls) //Recorremos cada elemento del formulario
                if (String.IsNullOrWhiteSpace(c.Text) && typeof(TextBox) == c.GetType()) //Si esta vacio y es un textbox
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRecuperarContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms) //Recorre los formularios abiertos
                if (typeof(frmLogIn) == frm.GetType()) //Buscar el formulario de LogIn
                {
                    frm.Show(); //Muestra el formulario
                    break; //Sal del bucle
                }
        }
    }
}
