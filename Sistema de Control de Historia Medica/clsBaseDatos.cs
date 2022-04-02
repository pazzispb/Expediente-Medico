using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Control_de_Historia_Medica
{
    internal class clsBaseDatos
    {
        //string vCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"\\..\\..\\BaseDatos.accdb\"";
        string vCadenaConexion = "";
        SQLiteConnection conexion;
        public clsBaseDatos()
        {
            try
            {
                conexion = new SQLiteConnection(vCadenaConexion);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
