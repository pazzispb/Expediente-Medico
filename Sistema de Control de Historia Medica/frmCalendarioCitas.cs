﻿using System;
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
            cargarDoctores();
            cargarCentro();

        }

        private void listBoxInfoCitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadirCita_Click_1(object sender, EventArgs e)
        {
            string idDoctor = cmbDesplegarDoctor.SelectedValue.ToString();

            string vConsulta = $"INSERT INTO Citas (idDoctor, horario, fecha) " +
            $"VALUES ({idDoctor}, '{cmbDesplegarHorario.Text}', '{dateTimePicker1.Text}')";
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
            DataSet ds = bd.ConsultarInfomacion("SELECT A.idCita as 'ID', B.nombreDoctor as 'Nombre', B.centroMedico as 'Centro medico', A.fecha as 'Fecha', A.horario as 'Horario'" +
                $"FROM Citas as A INNER JOIN Doctores as B ON A.idDoctor = B.idDoctor");//Carga los registros correspondientes a las analiticas de los usuarios
            dgvInfoCitas.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta

        }

        private void btnCitasAgendadas_Click(object sender, EventArgs e)
        {
            CargarInfoCita();
        }
        
        private void dgvInfoCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void cargarDoctores()
        {
            
            DataSet ds = bd.ConsultarInfomacion("SELECT idDoctor as 'ID', nombreDoctor as 'Nombre' FROM Doctores");//Carga los registros correspondientes a las analiticas de los usuarios
            cmbDesplegarDoctor.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
            cmbDesplegarDoctor.DisplayMember = "Nombre";
            cmbDesplegarDoctor.ValueMember = "ID";
        }

         //Indica si el usuario desea eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvInfoCitas.SelectedRows.Count > 0) //Si la fila seleccionada no es un header del datagridview
            {
                if (MessageBox.Show("¿Realmente desea eliminar la cita?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdCita = dgvInfoCitas.SelectedRows[0].Cells["ID"].Value.ToString();

                    string vConsulta = $"DELETE FROM Citas WHERE idCita = {vIdCita}";

                    if (bd.EjecutarComando(vConsulta))
                    {
                        CargarInfoCita();
                    }

                }
                else MessageBox.Show("Hubo un error al eliminar la cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else MessageBox.Show("No se ha seleccionado ninguna fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            


        }

        private void cargarCentro()
        {
            
            DataSet ds = bd.ConsultarInfomacion("SELECT idDoctor as 'ID', centroMedico as 'Centro Medico' FROM Doctores");//Carga los registros correspondientes a las analiticas de los usuarios
            cmbCentro.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
            cmbCentro.DisplayMember = "Centro Medico";
            cmbCentro.ValueMember = "ID";
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            if (dgvInfoCitas.SelectedRows.Count > 0) //Si la fila seleccionada no es un header del datagridview
            {
                if (MessageBox.Show("¿Desea actualizar el registro?", "AVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vIdCita = dgvInfoCitas.SelectedRows[0].Cells["ID"].Value.ToString();

                    string vConsulta = $"UPDATE Citas as A INNER JOIN Doctores as B ON A.idCita = B.idCita SET B.Nombre = {cmbDesplegarDoctor.Text}, B.Centro medico = {cmbCentro.Text}" +
                        $"A.Fecha = {dateTimePicker1.Text}, A.Horario = {cmbDesplegarHorario.Text} WHERE idCita = {vIdCita}";
                    


                    if (bd.EjecutarComando(vConsulta))
                    {
                        
                        CargarInfoCita();
                    }

                }
                else MessageBox.Show("Hubo un error al actualizar la cita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else MessageBox.Show("No se ha seleccionado ninguna fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        

        private void dgvInfoCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvInfoCitas.Rows[e.RowIndex];
            cmbDesplegarDoctor.Text = dgv.Cells[1].Value.ToString();
            cmbCentro.Text = dgv.Cells[2].Value.ToString();
            dateTimePicker1.Text = dgv.Cells[3].Value.ToString();
            cmbDesplegarHorario.Text = dgv.Cells[4].Value.ToString();
        }
    }
}
