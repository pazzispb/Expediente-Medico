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
    public partial class frmPerfilPersonal : Form
    {
        public frmPerfilPersonal()
        {
            InitializeComponent();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilPersonal_Load(object sender, EventArgs e) // evento que se activa cuando se abre un formulario
        {
            clsBaseDatos bd = new clsBaseDatos();

            string vConsulta = $"SELECT usuario, nombre, apellido, cedula, fechaNacimiento, altura, peso, tipoSangre, " +
                $"seguroMedico, telefono FROM Usuarios WHERE idUsuario ={frmMenuPrincipal.vIdUsuario}"; // pasar la consulta relacionada con el id correspondiente


            DataSet vInformacion = new DataSet(); // objeto creado para almacenar la informacion extraida de la base de datos 

            vInformacion = bd.ConsultarInfomacion(vConsulta); // almacenar en memoria para utilizar en este formulario

            object[] aDatos = vInformacion.Tables[0].Rows[0].ItemArray; // creacion de un arreglo con los datos del usuario, para poder insertarlos dentro de este formulario

            txtUsuario.Text = aDatos[0].ToString();
            cmbTipoSangre.SelectedItem = aDatos[7].ToString();





        }
    }
}
