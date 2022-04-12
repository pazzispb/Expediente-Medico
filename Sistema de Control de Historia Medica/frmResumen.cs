using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;


namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmResumen : Form
    {
        public frmResumen()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos();
        string[] aCampos = { "nombre", "edad", "fecha", "seguro", "altura", "peso", "sangre", "enfermedades", "condiciones", "alergias", "emergencias", "farmacos", "analiticas" };
        string[] aResultados;
        private void btnGenerar_Click(object sender, EventArgs e) 
        {
            RellenarResultados();
            PdfTextField vCampo; //Objeto para manejar los campos del formulario
            PdfString vValor; //Objeto para poder ingresar los valores dentro del formulario
            PdfDocument vPlantilla = PdfReader.Open(@"..\..\Plantilla_del_Resumen_de_Historia_de_Usuario.pdf", PdfDocumentOpenMode.Modify);//Traemos la plantilla en formato modificable
            PdfDocument vReporte = vPlantilla; //Copiamos la plantilla en otro objeto para agregar los datos de ese reporte.
            if (vReporte.AcroForm.Elements.ContainsKey("/NeedAppearances") == false) //Si el formulario esconde los valores
                vReporte.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true)); //Activa que se puedan visualizar los valores
            for (int i = 0; i < aCampos.Length; i++)//Recorre los campos que posee la plantilla
            {
                vCampo = (PdfTextField)(vReporte.AcroForm.Fields[aCampos[i]]);//Obtenemos el campo a rellenar
                vValor = new PdfString(aResultados[i]);//Preparamos el valor para introducirlo en el campo
                vCampo.Value = vValor;//Ingresamos el valor dentro del campo
                vCampo.ReadOnly = true;//Colocar el campo como de lectura
            }
            vReporte.Save(@"HistoriaMedica.pdf");//Guardamos el reporte
            pdfVisor.LoadFile("HistoriaMedica.pdf");//Cargamos al visor el reporte generado
        }
        void RellenarResultados()
        {
            object[] aDatosUsuario = bd.ConsultarInfomacion("SELECT nombre, apellido, fechaNacimiento, seguroMedico, altura, peso, tipoSangre " +
                $"FROM Usuarios WHERE idUsuario = {frmMenuPrincipal.vIdUsuario}").Tables[0].Rows[0].ItemArray; //Creamos un arreglo con los datos del usuario
            string vNombre = $"{aDatosUsuario[0].ToString()} {aDatosUsuario[1].ToString()}";//Nombre completo del usuario
            DateTime fechaActual = DateTime.Now;//Fecha de hoy
            DateTime fechaNacimiento = Convert.ToDateTime(aDatosUsuario[2].ToString()); //Fecha de nacimiento del usuario
            string vEdad = ((fechaActual - fechaNacimiento).Days / 365).ToString();//edad del usuario en años
            string vFecha = aDatosUsuario[2].ToString(),
                vSeguro = aDatosUsuario[3].ToString(),
                vAltura = $"{aDatosUsuario[4].ToString()}m",
                vPeso = $"{aDatosUsuario[5].ToString()}kg",
                vSangre = aDatosUsuario[6].ToString();
            string vEnfermedades = " ", vCondiciones = " ", vAlergias = " ", vEmergencias = " ", vFarmacos = " ", vAnaliticas = " ";
            aResultados = new string[]{ vNombre, vEdad, vFecha, vSeguro, vAltura, vPeso, vSangre, vEnfermedades, vCondiciones, vAlergias, vEmergencias, vFarmacos, vAnaliticas };
        }
    }
}
