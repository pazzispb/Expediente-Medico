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
       
        clsBaseDatos bd = new clsBaseDatos(); //objeto de base de datos

        public frmPadecimientos()
        {
            InitializeComponent();
        }
        private void btnIngresarPadecimientos_Click(object sender, EventArgs e)
        {
            frmRegistrarPadecimientos frm = new frmRegistrarPadecimientos();
            frm.MdiParent = this.MdiParent; // Asignar el mismo padre a ambas formularios
            frm.frmPadecimientos = this; //Le pasamos este formulario para que pueda ejercer operaciones sobre el
            frm.StartPosition = FormStartPosition.CenterScreen; //Lo centramos en la pantalla
            frm.Show();
        }
        private void btnCargarPadecimientos_Click(object sender, EventArgs e)
        {
            cargarPadecimientos(); //Cargamos los padecimientos del usuario al datagrid
        }
        public void cargarPadecimientos() //Cargamos los padecimientos del usuario al datagrid
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT tipoPadecimiento as 'Tipo', nombrePadecimiento as 'Nombre', fecha as 'Fecha', descripcion as 'Descripción'" +
                $"FROM Padecimientos WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}");//Trae los padecimientos correspondientes al usuario con la sesion iniciada desde la base de datos y los almacena en un dataset
            dgvPadecimientos.DataSource = ds.Tables[0];//Carga el datagridview con lo que se encuentra almacenado en el dataset
        }
        private void frmPadecimientos_Load(object sender, EventArgs e)
        {
            cargarPadecimientos();
        }
        private void dgvPadecimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la celda seleccionada no es un header
            {
                if (dgvPadecimientos.Rows[e.RowIndex].Cells[2].Value.ToString() != "No Aplica") //Si el campo de fecha de la celda seleccionada no dice no aplica
                {
                    dtpPadecimiento.Visible = true; //visibilizamos el datetimepicker
                    txtFechaNoAplica.Visible = false; //Invisibilizamos el textbox que dice no aplica
                    //Cargamos cada valor de las columnas de la fila actual con su respectivo campo del formulario
                    txtTipoPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtpPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDescripcionPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    dtpPadecimiento.Visible = false; //invisibilizamos el datetimepicker
                    txtFechaNoAplica.Visible = true; //visibilizamos el textbox que dice no aplica
                    //Cargamos cada valor de las columnas de la fila actual con su respectivo campo del formulario
                    txtTipoPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtFechaNoAplica.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDescripcionPadecimiento.Text = dgvPadecimientos.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            
        }
    }
}
