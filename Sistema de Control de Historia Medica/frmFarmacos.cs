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
    public partial class frmFarmacos : Form
    {
        public frmFarmacos()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos(); //Objeto de base de datos
        private void btnIngresarFarmacos_Click(object sender, EventArgs e)
        {
            frmRegistrarFarmacos frm = new frmRegistrarFarmacos();
            frm.MdiParent = this.MdiParent; // Asignar el mismo padre a ambos formularios
            frm.frmFarmacos = this; //Le pasamos este formulario al otro para ejecutar operaciones sobre el
            frm.StartPosition = FormStartPosition.CenterScreen; //Centramos el formulario en la pantalla
            frm.Show();
        }
        public void cargarFarmacos() //Rellenar el datagridview de farmacos
        {
            DataSet ds = bd.ConsultarInfomacion($"SELECT nombreFarmaco as 'Nombre', frecuenciaFarmaco as 'Frecuencia', dosisFarmaco as 'Dosis', veces as 'Frecuencia Diaria', descripcionFarmaco as 'Descripción'" +
                $"FROM Farmacos WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}"); //Trae los farmacos correspondientes al usuario con la sesion iniciada desde la base de datos y los almacena en un dataset
            dgvFarmacos.DataSource = ds.Tables[0];//Carga el datagridview con lo que se encuentra almacenado en el dataset
        }
        private void btnCargarFarmacos_Click(object sender, EventArgs e)
        {
            cargarFarmacos();
        }
        private void dgvFarmacos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila clickeada no es un header del datagridview, solo incluir el contenido
            {
                //Rellenar cada campo del formulario con su respectiva columna de la fila seleccionada
                txtFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbFrecuenciaFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDosisFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbFrecuencia.Text = dgvFarmacos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescripcionFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
