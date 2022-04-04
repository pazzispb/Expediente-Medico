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
            string vConsulta = $"SELECT COUNT(idUsuario) FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND cedula = '{txtCedula.Text}' "; // Cantidad de usuarios que comparten el mismo nombre y contrasena
            int vResultados = Convert.ToInt32(bd.ConsultarValor(vConsulta));

            if (vResultados == 1)
            {
                vConsulta = $"SELECT clave FROM Usuarios WHERE usuario = '{txtUsuario.Text}' AND cedula = '{txtCedula.Text}' "; // Cantidad de usuarios que comparten el mismo nombre y contrasena
                MessageBox.Show( bd.ConsultarValor(vConsulta).ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);//Indicamos el ID del usuario que ingreso al sistema
            }
            else MessageBox.Show("No existe usuario con esa cédula y/o username", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void lbLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
