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
                listBoxInfoCitas.Items.Add("Doctor: " + cmbDesplegarDoctor.Text + "\tFecha: " + dateTimePicker1.Text + "\tCentro Médico: " +
                cmbCentro.Text + "\tHora" + cmbDesplegarHorario.Text);


                StreamWriter sw = new StreamWriter("Agenda de citas.txt", true);
                sw.WriteLine("Doctor: " + cmbDesplegarDoctor.Text + "\tFecha: " + dateTimePicker1.Text + "\tCentro Médico: " +
                    cmbCentro.Text + "\tHora" + cmbDesplegarHorario.Text);
                sw.Close();                             
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
