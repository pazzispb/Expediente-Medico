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

        clsBaseDatos bd = new clsBaseDatos();

        private void btnIngresarFarmacos_Click(object sender, EventArgs e)
        {
            frmRegistrarFarmacos frm = new frmRegistrarFarmacos();
            frm.MdiParent = this.MdiParent; // Asignar el mismo padre a ambas clases
            frm.frmFarmacos = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

       

        public void cargarFarmacos()
        {
            DataSet ds = bd.ConsultarInfomacion($"SELECT nombreFarmaco as 'Nombre', frecuenciaFarmaco as 'Frecuencia', dosisFarmaco as 'Dosis', veces as 'Frecuencia Diaria', descripcionFarmaco as 'Descripción'" +
                $"FROM Farmacos WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}");
            dgvFarmacos.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
        }

    

        private void btnCargarFarmacos_Click(object sender, EventArgs e)
        {
            cargarFarmacos();
        }

        private void dgvFarmacos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila seleccionada no es un header del datagridview
            {
                txtFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbFrecuenciaFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDosisFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbFrecuencia.Text = dgvFarmacos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescripcionFarmaco.Text = dgvFarmacos.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
