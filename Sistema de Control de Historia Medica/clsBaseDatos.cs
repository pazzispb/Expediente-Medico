using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Control_de_Historia_Medica
{
    internal class clsBaseDatos
    {
        string vCadenaConexion = "Data Source=database.db; Version=3;New=True;Compress=True;";
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
        void AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //public (bool, int) EjecutarComandoConRetorno(string vConsulta)
        //{//INSERT INTO TABLA(CAMPOS) VALUES ()
        //    try
        //    {
        //        AbrirConexion();
        //        SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion);
        //        if (sQLiteCommand.ExecuteNonQuery() > 0)
        //        {
        //            CerrarConexion();
        //            var vResultado = vConsulta.Split(' ')[2].Substring(0,vConsulta.Split(' ')[2].IndexOf("("));
        //            var valor = ConsultarValor($"SELECT * FROM {vResultado} WHERE  = (SELECT MAX(ID)  FROM TABLE);
        //            ");
        //            return (true, 1);
        //        }
        //        else
        //        {
        //            CerrarConexion();
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return false;
        //}
        public bool EjecutarComando(string vConsulta)
        {
            try
            {
                AbrirConexion();
                SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion);
                if (sQLiteCommand.ExecuteNonQuery() > 0)
                {
                    CerrarConexion();
                    return true;
                }
                else
                {
                    CerrarConexion();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        public DataSet ConsultarInfomacion(string vConsulta)
        {
            try
            {
                AbrirConexion();
                DataSet ds = new DataSet();
                SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion);
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand);
                sQLiteDataAdapter.Fill(ds);
                CerrarConexion();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
            
        }
        public object ConsultarValor(string vConsulta)
        {
            try
            {
                AbrirConexion();
                DataSet ds = new DataSet();
                SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion);
                object var = sQLiteCommand.ExecuteScalar();
                CerrarConexion();
                return var;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

    }
}
