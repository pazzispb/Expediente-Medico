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
        public frmPadecimientos vPadecimientos;

        public frmRegistrarPadecimientos()
        {
            InitializeComponent();
        }

        private void rdbAlergia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPadecimiento_Click(object sender, EventArgs e)
        {
            vPadecimientos.cargarPadecimientos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstadoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEstadoFecha.Checked)
            {
                dtpFechaPadecimiento.Enabled = false;
            }
            else
            {
                dtpFechaPadecimiento.Enabled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
