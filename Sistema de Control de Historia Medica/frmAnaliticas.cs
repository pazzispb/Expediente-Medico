using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmAnaliticas : Form
    {
        string vIDUsuario = frmMenuPrincipal.vIdUsuario; //Id del usuario con la sesion abierta
        clsBaseDatos bd = new clsBaseDatos();
        public frmAnaliticas()
        {
            InitializeComponent();
        }
        private void frmAnaliticas_Load(object sender, EventArgs e)
        {
            CargarAnaliticas();
        }
        private void btnRegistrarAnalitica_Click(object sender, EventArgs e)
        {
            if (!EstaAbierto())
            {
                frmRegistrarAnalitica frm = new frmRegistrarAnalitica();
                frm.MdiParent = this.MdiParent;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static public bool EstaAbierto() //Valida si hay formularios abiertos aparte del Menu Principal y el de Analiticas
        {
            if (Application.OpenForms.Count > 3) return true; 
            else return false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarAnaliticas();
        }
        void CargarAnaliticas()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idAnalitica as 'ID', fecha as 'Fecha', proposito as 'Propósito', observaciones as 'Observaciones'" +
                $"FROM Analiticas WHERE idUsuario = {vIDUsuario}");//Carga los registros correspondientes a las analiticas de los usuarios
            dgvAnaliticas.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
            
        }

        private void dgvAnaliticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lblID.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpFecha.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPropositoAnalitica.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtObservaciones.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[2].Value.ToString();
                string direccion = Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf('\\'));//Obtener la direccion del programa en ejecucion
                pdfVisualizador.src = $"{direccion}\\Analiticas\\{lblID.Text}.pdf";
            }
        }
    }
}
