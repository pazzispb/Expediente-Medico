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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void lblCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario(new frmCrearCuenta());
        }
        public void AbrirFormulario(Form frm)
        {
            if (Application.OpenForms.Count < 2)
                frm.Show();
            else MessageBox.Show("Cierre la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbrirFormulario(new frmMenuPrincipal());
        }
    }
}
