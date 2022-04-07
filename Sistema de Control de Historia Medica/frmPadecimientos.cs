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
    public partial class frmPadecimientos : Form
    {
       
        clsBaseDatos bd = new clsBaseDatos();

        public frmPadecimientos()
        {
            InitializeComponent();
        }

        private void labTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labNombre_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void labCentroDeSalud_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarPadecimientos_Click(object sender, EventArgs e)
        {
            frmRegistrarPadecimientos frm = new frmRegistrarPadecimientos();
            frm.MdiParent = this.MdiParent; // Asignar el mismo padre a ambas clases
            frm.frmPadecimientos = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void btnCargarPadecimientos_Click(object sender, EventArgs e)
        {
            cargarPadecimientos();
        }

        public void cargarPadecimientos()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT tipoPadecimiento as 'Tipo', nombrePadecimiento as 'Nombre', fecha as 'Fecha', descripcion as 'Descripción'" +
                $"FROM Padecimientos WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}");//Carga los registros correspondientes a las analiticas de los usuarios
            dgvPadecimientos.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
        }

        private void frmPadecimientos_Load(object sender, EventArgs e)
        {
            cargarPadecimientos();
        }

        private void dgvPadecimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila seleccionada no es un header del datagridview
            {
                txtTipoPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescripcionPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
