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
        string vIDUsuario = frmMenuPrincipal.vIdUsuario; //Id del usuario con la sesion abierta
        clsBaseDatos bd = new clsBaseDatos();
        public frmCalendarioCitas()
        {
            InitializeComponent();

        }


        private void frmCalendarioCitas_Load(object sender, EventArgs e)
        {
            var fechaActual = DateTime.Now;
            dateTimePicker1.MinDate = fechaActual;
            MonthCalendar.MinDate = fechaActual;

            
            
            
        }

        private void listBoxInfoCitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadirCita_Click_1(object sender, EventArgs e)
        {
            string idDoctor = "1";

            string vConsulta = $"INSERT INTO Citas (idDoctor, horario, centroMedico, fecha) " +
            $"VALUES ({idDoctor}, '{cmbDesplegarHorario.Text}', '{cmbCentro.Text}', '{dateTimePicker1.Text}')";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                        MessageBox.Show("Doctor registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string vID = bd.ConsultarValor("SELECT idDoctor FROM Doctores ORDER BY idDoctor DESC LIMIT 1;").ToString(); //obtiene el id del doctor que se acaba de registrar                       
                        LimpiarCampos();
                }
                else MessageBox.Show("Hubo un error al registrar el doctor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    
        }

        bool ValidarCamposRellenos()
        {
            foreach (Control c in pnDatosCita.Controls) //Recorremos cada elemento del formulario
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }

        void LimpiarCampos()
        {
            foreach (Control c in pnDatosCita.Controls) //Recorremos cada elemento del formulario
                if (typeof(TextBox) == c.GetType()) //Si esta vacio
                {
                    c.Text = ""; //Limpia el contenido del control
                }
            
        }

        void CargarInfoCita()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT nombreDoctor as 'Nombre', centroMedico as 'Centro medico', fecha as 'Fecha', horario as 'Horario', " +
                $"FROM Citas WHERE idUsuario = {vIDUsuario}");//Carga los registros correspondientes a las analiticas de los usuarios
            dgvInfoCitas.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta

        }

        private void btnCitasAgendadas_Click(object sender, EventArgs e)
        {
            CargarInfoCita();
        }

        private void dgvInfoCitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila seleccionada no es un header del datagridview
            {
                cmbDesplegarDoctor.Text = dgvInfoCitas.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbDesplegarHorario.Text = dgvInfoCitas.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbCentro.Text = dgvInfoCitas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dgvInfoCitas.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }
    }
}
