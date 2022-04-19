using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmRegistrarAnalitica : Form
    {
        clsBaseDatos bd = new clsBaseDatos(); //Objeto de base de datos
        public frmAnaliticas frmAnaliticas; //Formulario de analiticas
        public frmRegistrarAnalitica()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fdBuscarArchivo.ShowDialog();//Muestra la ventana para buscar el archivo
        }
        private void fdBuscarArchivo_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fdBuscarArchivo.FileName))//Si se selecciono un archivo
            {
                lblDireccion.Text = fdBuscarArchivo.FileName;//Escribe el nombre del archivo en el label
            }
        }
        private void btnRegistrarAnalitica_Click(object sender, EventArgs e)
        {
            if (ValidarArchivo()) //valida si el archivo seleccionado es valido
            {
                string vConsulta = $"INSERT INTO Analiticas (fecha, proposito, observaciones, idUsuario) " +
                $"VALUES ('{dtpFecha.Text}', '{txtPropositoAnalitica.Text}', '{txtObservaciones.Text}', {frmMenuPrincipal.vIdUsuario})";
                if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                    if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                    {
                        MessageBox.Show("Analitica registrada con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string vID = bd.ConsultarValor("SELECT idAnalitica FROM Analiticas ORDER BY idAnalitica DESC LIMIT 1;").ToString(); //obtiene el id de la analitica que se acaba de registrar
                        if(File.Exists($"../../Analiticas/{vID}.pdf")) //Si existe el archivo a almacenar en la ubicacion donde lo deseo
                            File.Delete($"../../Analiticas/{vID}.pdf"); //Borralo
                        File.Copy(lblDireccion.Text, $"../../Analiticas/{vID}.pdf"); //Guarda el archivo bajo el id correspondiente a su registro en la base de datos
                        LimpiarCampos();
                        frmAnaliticas.CargarAnaliticas();//recargo el datagridview de analiticas
                        this.Close();
                    }
                    else MessageBox.Show("Hubo un error al registrar la analitica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        bool ValidarCamposRellenos() //Valida que los campos del contenedor esten todos llenos
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        void LimpiarCampos() 
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }
            lblDireccion.Text = "Dirección del archivo";
        }
        bool ValidarArchivo()
        {
            if(File.Exists(lblDireccion.Text))  return true; //valida si la direccion del archivo a ingresar existe o es valida
            else
            {
                MessageBox.Show("Seleccione un archivo valido", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void frmRegistrarAnalitica_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Today;//fecha de hoy
        }
    }
}