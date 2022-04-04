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

        private void clbEnfermedades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPadecimientos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPadecimiento_Click(object sender, EventArgs e)
        {
            frmRegistrarPadecimientos frmRegistrarPadecimientos = new frmRegistrarPadecimientos();
            frmRegistrarPadecimientos.Show();
        }
    }
}
