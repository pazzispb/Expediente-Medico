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

        private void frmPerfilPersonal_Load(object sender, EventArgs e) // evento que se activa cuando se abre un formulario
        {
            clsBaseDatos bd = new clsBaseDatos();

            string vConsulta = $"SELECT usuario, nombre, apellido, cedula, fechaNacimiento, altura, peso, tipoSangre, " +
                $"seguroMedico, telefono FROM Usuarios WHERE idUsuario ={frmMenuPrincipal.vIdUsuario}"; // pasar la consulta relacionada con el id correspondiente


            DataSet vInformacion = new DataSet(); // objeto creado para almacenar la informacion extraida de la base de datos 

            vInformacion = bd.ConsultarInfomacion(vConsulta); // almacenar en memoria para utilizar en este formulario

            object[] aDatos = vInformacion.Tables[0].Rows[0].ItemArray; // creacion de un arreglo con los datos del usuario, para poder insertarlos dentro de este formulario

            txtUsuario.Text = aDatos[0].ToString(); // creacion de arreglos para cada campo 
            txtNombre.Text = aDatos[1].ToString();
            txtApellido.Text = aDatos[2].ToString();
            txtCedula.Text = aDatos[3].ToString();
            dtpFecha.Text = aDatos[4].ToString();
            txtAltura.Text = aDatos[5].ToString();
            txtPeso.Text = aDatos[6].ToString();
            txtSeguroMedico.Text = aDatos[8].ToString();
            txtTelefono.Text = aDatos[9].ToString();
            cmbTipoSangre.SelectedItem = aDatos[7].ToString();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();

            string vConsulta = $"UPDATE Usuarios" +
            $" SET nombre = '{txtNombre.Text}'," +
            $"apellido = '{txtApellido.Text}' , cedula = '{txtCedula.Text}', fechaNacimiento = '{dtpFecha.Text}', altura = {txtAltura.Text}, peso = {txtPeso.Text}, tipoSangre = '{cmbTipoSangre.Text}', seguroMedico = '{txtSeguroMedico.Text}', telefono = '{txtTelefono.Text}'" +
            $" WHERE idUsuario = {frmMenuPrincipal.vIdUsuario} ";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))
                {
                    MessageBox.Show("Perfil actualizado de manera exitosa", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Hubo un error al actualizar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool ValidarCamposRellenos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del formulario
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }

    }
}
