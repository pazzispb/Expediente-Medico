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
    public partial class frmDoctores : Form
    {
        clsBaseDatos bd = new clsBaseDatos(); //Objeto de la base de datos
        public frmDoctores()
        {
            InitializeComponent();
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in pnRegistrarDoctor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text) && typeof(TextBox) == c.GetType()) //Si esta vacio y es un textbox
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnRegistrarDoctor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }
        }
        private void btnVerDoctores_Click_1(object sender, EventArgs e)
        {
            CargarDoctores();
        }
        void CargarDoctores() //Rellenar el datagridview del formulario con la informacion de los doctores
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idDoctor as 'ID', nombreDoctor as 'Nombre', telefono as 'Telefono', especialidad as 'Especialidad', centroMedico as 'Centro medico'" +
                $"FROM Doctores WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}");//Trae los doctores correspondientes al usuario con la sesion iniciada desde la base de datos y los almacena en un dataset
            dataGridView1.DataSource = ds.Tables[0];//Carga el datagridview con lo que se encuentra almacenado en el dataset
        }
        private void btnAñadirDoctor_Click(object sender, EventArgs e)
        {
            string vConsulta = $"INSERT INTO Doctores ( nombreDoctor, telefono, especialidad, centroMedico, idUsuario ) " +
            $"VALUES ('{txtNombre.Text}', '{txtTelefono.Text}', '{txtEspecialidad.Text}', '{txtCentroDeSalud.Text}', {frmMenuPrincipal.vIdUsuario})";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro en la base de datos
                {
                    MessageBox.Show("Doctor registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDoctores();
                    LimpiarCampos();
                }
                else MessageBox.Show("Hubo un error al registrar el doctor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) //Si hay una fila seleccionada
            {
                if (MessageBox.Show("¿Realmente desea eliminar el doctor?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdDoctor = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();//Obtenemos el id del doctor a eliminar
                    string vConsulta = $"DELETE FROM Doctores WHERE idDoctor = {vIdDoctor}";
                    if (bd.EjecutarComando(vConsulta))//Si se elimino el registro
                    {
                        CargarDoctores();
                        MessageBox.Show("Doctor eliminado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Hubo un error al eliminar al doctor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else MessageBox.Show("Seleccione una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnModificarDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) //Si hay una fila seleccionada
            {
                if (MessageBox.Show("¿Desea actualizar el registro?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdDoctor = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(); //Obtenemos el id del doctor a actualizar
                    string vConsulta = $"UPDATE Doctores SET nombreDoctor = '{txtNombre.Text}', telefono = '{txtTelefono.Text}', especialidad = '{txtEspecialidad.Text}', centroMedico = '{txtCentroDeSalud.Text}' WHERE idDoctor = {vIdDoctor}";
                    if (bd.EjecutarComando(vConsulta)) //Si se modifico el registro
                    {
                        MessageBox.Show("Doctor modificado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDoctores();
                        LimpiarCampos();
                    }
                    else MessageBox.Show("Hubo un error al actualizar el doctor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else MessageBox.Show("Seleccione una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];//Fila que esta seleccionada
            //Carga la informacion de la fila a los textbox correspondientes
            txtNombre.Text = dgv.Cells[1].Value.ToString();
            txtTelefono.Text = dgv.Cells[2].Value.ToString();
            txtEspecialidad.Text = dgv.Cells[3].Value.ToString();
            txtCentroDeSalud.Text = dgv.Cells[4].Value.ToString();
        }
    }
}
