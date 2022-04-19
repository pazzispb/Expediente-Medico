using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmCalendarioCitas : Form
    {
        clsBaseDatos bd = new clsBaseDatos(); //Objeto de base de datos
        public frmCalendarioCitas()
        {
            InitializeComponent();
        }
        private void frmCalendarioCitas_Load(object sender, EventArgs e)
        {
            cmbDesplegarHorario.SelectedIndex = 0; //Seleccionamos el primer elemento del combobox
            cargarDoctores();//rellenamos el combobox de doctores
            cargarCentro(); //rellenamos el combobox de centros medicos
        }
        private void btnAñadirCita_Click_1(object sender, EventArgs e)
        {
            if (ValidarCamposRellenos()) { //Si los campos estan rellenos
                string idDoctor = cmbDesplegarDoctor.SelectedValue.ToString(); //Obtenemos el id del doctor seleccionado
                string vConsulta = $"INSERT INTO Citas (idDoctor, doctorCita, centroCita, horario, fecha, idUsuario) " +
                $"VALUES ({idDoctor}, '{cmbDesplegarDoctor.Text}', '{cmbCentro.Text}', '{cmbDesplegarHorario.Text}', '{dateTimePicker1.Text}', {frmMenuPrincipal.vIdUsuario})";
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                    MessageBox.Show("Cita registrada con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarInfoCita();//Actualiza el datagrid de informacion de citas
                }
                else MessageBox.Show("Hubo un error al registrar la cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in pnDatosCita.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnDatosCita.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }
        }
        void CargarInfoCita()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idCita as 'ID', doctorCita as 'Doctor', centroCita as 'Centro medico', fecha as 'Fecha', horario as 'Horario'" +
                $"FROM Citas WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}");//Almacena en un dataset los registros correspondientes a las citas del usuario con la sesion iniciada
            dgvInfoCitas.DataSource = ds.Tables[0];//Carga el datagridview con lo que se encuentra almacenado en el dataset
        }
        private void btnCitasAgendadas_Click(object sender, EventArgs e)
        {
            CargarInfoCita();
        }
        private void cargarDoctores()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idDoctor as 'ID', nombreDoctor as 'Nombre' FROM Doctores");//Almacena en un dataset los registros correspondientes a los doctores del usuario con la sesion iniciada
            cmbDesplegarDoctor.DataSource = ds.Tables[0];//Carga el combobox con lo que se encuentra almacenado en el dataset
            cmbDesplegarDoctor.DisplayMember = "Nombre"; //Se coloca que el campo Nombre sea el que visualice el usuario como elementos del combobox
            cmbDesplegarDoctor.ValueMember = "ID";//Se coloca que el campo ID sea el valor correspondiente a cada elemento del combobox
        }

         //Indica si el usuario desea eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInfoCitas.SelectedRows.Count  == 1 ) //Si hay una fila seleccionada
            {
                if (MessageBox.Show("¿Realmente desea eliminar la cita?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdCita = dgvInfoCitas.SelectedRows[0].Cells["ID"].Value.ToString();//Obtenemos el id de la cita a eliminar
                    string vConsulta = $"DELETE FROM Citas WHERE idCita = {vIdCita}";
                    if (bd.EjecutarComando(vConsulta)) //Si se elimino el registro
                    {
                        CargarInfoCita();
                        MessageBox.Show("Cita eliminada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Hubo un error al eliminar la cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else MessageBox.Show("No se ha seleccionado ninguna fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cargarCentro()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT centroMedico as 'Centro Medico' FROM Doctores"); //Almacena en un dataset los centros medicos que estan registrados en el sistema
            cmbCentro.DataSource = ds.Tables[0]; //Carga el combobox con lo que se encuentra almacenado en el dataset
            cmbCentro.DisplayMember = "Centro Medico"; //Se coloca que el campo Centro Medico sea el que visualice el usuario como elementos del combobox
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            if (dgvInfoCitas.SelectedRows.Count == 1) //Si hay una fila seleccionada
            {
                if (MessageBox.Show("¿Desea actualizar el registro?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdCita = dgvInfoCitas.SelectedRows[0].Cells["ID"].Value.ToString(); //Obtenemos el id de la cita a modificar
                    string vConsulta = $"UPDATE Citas SET doctorCita = '{cmbDesplegarDoctor.Text}', centroCita = '{cmbCentro.Text}', fecha = '{dateTimePicker1.Text}', horario = '{cmbDesplegarHorario.Text}' WHERE idCita = {vIdCita}";
                    if (bd.EjecutarComando(vConsulta)) //Si se modifico el registro
                    {
                        MessageBox.Show("Cita modificada con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarInfoCita();
                    }
                    else MessageBox.Show("Hubo un error al actualizar la cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else MessageBox.Show("No se ha seleccionado ninguna fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void dgvInfoCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvInfoCitas.Rows[e.RowIndex]; //Obtenemos la fila que se encuentra seleccionada
            //Cargamos cada campo del registro con su respectivo campo del formulario
            cmbDesplegarDoctor.Text = dgv.Cells[1].Value.ToString();
            cmbCentro.Text = dgv.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgv.Cells[3].Value.ToString());
            cmbDesplegarHorario.Text = dgv.Cells[4].Value.ToString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //Cuando el datetimepicker cambie de valor
        {
            MonthCalendar.SetDate(dateTimePicker1.Value); //El calendario toma esa misma fecha
        }
    }
}
