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
    public partial class frmRegistrarPadecimientos : Form
    {
        public frmRegistrarPadecimientos()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbEstadoFechaPadecimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEstadoFechaPadecimiento.Checked)
            {
                dtpFechaPadecimiento.Enabled = false;

            }
            else
            {
                dtpFechaPadecimiento.Enabled = true;
            }
        }
    }
}
