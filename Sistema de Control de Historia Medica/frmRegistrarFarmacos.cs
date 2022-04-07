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
    public partial class frmRegistrarFarmacos : Form
    {
        clsBaseDatos bd = new clsBaseDatos();
        public frmFarmacos frmFarmacos = new frmFarmacos();
        public frmRegistrarFarmacos()
        {
            InitializeComponent();
        }

        private void btnGuardarFarmaco_Click(object sender, EventArgs e)
        {
            string vConsulta = $"INSERT INTO Farmacos (nombreFarmaco, frecuenciaFarmaco, dosisFarmaco, descripcionFarmaco, veces, idUsuario)" +
                $"VALUES ('{txtFarmaco.Text}', '{cmbFrecuenciaFarmaco.Text}', '{txtDosisFarmaco.Text}', '{txtDescripcionFarmaco.Text}', '{cmbVeces.Text}', {frmMenuPrincipal.vIdUsuario})";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                    MessageBox.Show("Fármaco registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmFarmacos.cargarFarmacos();
                    LimpiarCampos();
                    

                }
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
        void LimpiarCampos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del formulario
                if (typeof(TextBox) == c.GetType()) //Si esta vacio
                {
                    c.Text = ""; //Limpia el contenido del control
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
