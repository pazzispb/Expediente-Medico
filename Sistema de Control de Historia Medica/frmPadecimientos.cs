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
        static public bool EstaAbierto()
        {
            if (Application.OpenForms.Count > 2) return true; //Si hay formularios abiertos aparte del Menu Principal
            else return false;
        }
        public void AbrirFormulario(Form frm) //Recibo un formulario
        {
            if (!EstaAbierto()) //si no hay formularios abiertos a parte del menu principal me permite abrir uno
            {
                frm.MdiParent = this; //Asignamos a ese objeto el formulario padre, que será este
                frm.StartPosition = FormStartPosition.CenterScreen;//Centrar el formulario en la pantalla
                frm.Show(); //Mostrar el formulario
            }
            else MessageBox.Show("Cierre la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
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
            AbrirFormulario(new frmRegistrarFarmacos());

        }
    }
}
