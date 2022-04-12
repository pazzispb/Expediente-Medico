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
    public partial class frmRegistrarPadecimientos : Form
    {
        clsBaseDatos bd = new clsBaseDatos();
        public frmPadecimientos frmPadecimientos = new frmPadecimientos();
        public frmRegistrarPadecimientos()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTimePicker GetDtpFechaPadecimiento()
        {
            return dtpFechaPadecimiento;
        }

      
        private void btnGuardarPadecimiento_Click(object sender, EventArgs e)
        {

            string vConsulta = $"INSERT INTO Padecimientos (tipoPadecimiento, nombrePadecimiento, fecha, descripcion, idUsuario) " +
            $"VALUES ('{cmbTipoPadecimiento.Text}', '{txtPadecimiento.Text}', '{dtpFechaPadecimiento.Text}', '{txtDescripcionPadecimiento.Text}', {frmMenuPrincipal.vIdUsuario})";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                    MessageBox.Show("Padecimiento registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    frmPadecimientos.cargarPadecimientos();
                   
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

        private void frmRegistrarPadecimientos_Load(object sender, EventArgs e)
        {
            cmbTipoPadecimiento.SelectedIndex = 0; 
        }

        private void chbEstadoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstadoFecha.Checked)
            {
                dtpFechaPadecimiento.Enabled = false;
            }
            else
            {
                dtpFechaPadecimiento.Enabled = true;
            }

        }
    }
}
