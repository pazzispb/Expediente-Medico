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
        clsBaseDatos bd = new clsBaseDatos();//objeto de base de datos
        public frmPadecimientos frmPadecimientos = new frmPadecimientos(); //formulario de padecimientos para hacer operaciones sobre el
        public frmRegistrarPadecimientos()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarPadecimiento_Click(object sender, EventArgs e)
        {
            if (!chbEstadoFecha.Checked)//si el checkbox no esta checked
            {
                string vConsulta = $"INSERT INTO Padecimientos (tipoPadecimiento, nombrePadecimiento, fecha, descripcion, idUsuario) " +
                $"VALUES ('{cmbTipoPadecimiento.Text}', '{txtPadecimiento.Text}', '{dtpFechaPadecimiento.Text}', '{txtDescripcionPadecimiento.Text}', {frmMenuPrincipal.vIdUsuario})";
                if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                    if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                    {
                        MessageBox.Show("Padecimiento registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        frmPadecimientos.cargarPadecimientos(); //actualiza el datagridview del formulario padecimientos
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al registrar el padecimiento", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
            {
                string vConsulta = $"INSERT INTO Padecimientos (tipoPadecimiento, nombrePadecimiento, fecha, descripcion, idUsuario) " +
                $"VALUES ('{cmbTipoPadecimiento.Text}', '{txtPadecimiento.Text}', '{"No Aplica"}', '{txtDescripcionPadecimiento.Text}', {frmMenuPrincipal.vIdUsuario})";
                if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                    if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                    {
                        MessageBox.Show("Padecimiento registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        frmPadecimientos.cargarPadecimientos(); //actualiza el datagridview del formulario padecimientos
                    }
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
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si esta vacio
                {
                    c.Text = ""; //Limpia el contenido del control
                }
        }
        private void frmRegistrarPadecimientos_Load(object sender, EventArgs e)
        {
            cmbTipoPadecimiento.SelectedIndex = 0;//primer elemento del combobox seleccionado
        }
        private void chbEstadoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstadoFecha.Checked)//si el checkbox ta checked
            {
                dtpFechaPadecimiento.Enabled = false; //deshabilita el datetimepicker
            }
            else
            {
                dtpFechaPadecimiento.Enabled = true; //habilita el datetimepicker
            }
        }
    }
}
