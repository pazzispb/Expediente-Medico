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
        clsBaseDatos bd = new clsBaseDatos();
        public frmCalendarioCitas()
        {
            InitializeComponent();

        }

        

        private void labTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labcondiciones_Click(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            string vConsulta = $"INSERT INTO Citas (nombreDoctor, horario, centroMedico, fecha) " +
            $"VALUES ('{cmbDesplegarDoctor.Text}', '{cmbDesplegarHorario.Text}', '{cmbCentro.Text}', {dateTimePicker1.Text})";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                        MessageBox.Show("Doctor registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string vID = bd.ConsultarValor("SELECT idDoctor FROM Analiticas ORDER BY idDoctor DESC LIMIT 1;").ToString(); //obtiene el id del doctor que se acaba de registrar                       
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MonthCalendar.SetDate(dateTimePicker1.Value);
        }


        private void btnCitasAgendadas_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Agenda de citas.txt");
            string linea;

            listBoxInfoCitas.Items.Clear();
            linea = sr.ReadLine();

            while(linea != null)
            {
                listBoxInfoCitas.Items.Add(linea);
                linea = sr.ReadLine();
            }
            sr.Close();
            
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            
            listBoxInfoCitas.Items.RemoveAt(listBoxInfoCitas.SelectedIndex);
            
            
        }

    }
}
