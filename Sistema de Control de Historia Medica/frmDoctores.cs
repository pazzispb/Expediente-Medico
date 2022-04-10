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
        string vIDUsuario = frmMenuPrincipal.vIdUsuario; //Id del usuario con la sesion abierta
        clsBaseDatos bd = new clsBaseDatos();
        public frmDoctores()
        {
            InitializeComponent();
        }

        

       
        bool ValidarCamposRellenos()
        {
            foreach (Control c in pnRegistrarDoctor.Controls) //Recorremos cada elemento del formulario
                if (String.IsNullOrWhiteSpace(c.Text) && typeof(TextBox) == c.GetType()) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnRegistrarDoctor.Controls) //Recorremos cada elemento del formulario
                if (typeof(TextBox) == c.GetType()) //Si esta vacio
                {
                    c.Text = ""; //Limpia el contenido del control
                }

        }

        private void btnVerDoctores_Click_1(object sender, EventArgs e)
        {
            CargarDoctores();
            
        }

        void CargarDoctores()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idDoctor as 'ID', nombreDoctor as 'Nombre', especialidad as 'Especialidad', centroMedico as 'Centro medico'" +
                $"FROM Doctores");//Carga los registros correspondientes a los resultados de los usuarios
            dataGridView1.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta

        }

        private void labTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadirDoctor_Click(object sender, EventArgs e)
        {
            string vConsulta = $"INSERT INTO Doctores (nombreDoctor, telefono, especialidad, centroMedico ) " +
            $"VALUES ('{txtNombre.Text}', '{txtTelefono.Text}', '{txtEspecialidad.Text}', '{txtCentroDeSalud.Text}')";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                    MessageBox.Show("Doctor registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    
                }
                else MessageBox.Show("Hubo un error al registrar el doctor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila seleccionada no es un header del datagridview
            {
                txtEspecialidad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCentroDeSalud.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                
            }
        }

        
    }

}
