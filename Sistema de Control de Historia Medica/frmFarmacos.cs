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
       
        public void AbrirFormulario(Form frm) //Recibo un formulario
        {
           
                frm.MdiParent = this; //Asignamos a ese objeto el formulario padre, que será este
                frm.StartPosition = FormStartPosition.CenterScreen;//Centrar el formulario en la pantalla
                frm.Show(); //Mostrar el formulario
           
        }

        private void btnIngresarFarmacos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarFarmacos());
        }
    }
}
