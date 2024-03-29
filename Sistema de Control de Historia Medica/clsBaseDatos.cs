﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Control_de_Historia_Medica
{
    internal class clsBaseDatos
    {
        string vCadenaConexion = "Data Source=\"..\\..\\database.db\"; Version=3;New=True;Compress=True;"; //Ruta y parametros para conectar
        SQLiteConnection conexion;//maneja las conexiones
        public clsBaseDatos()
        {
            try 
            {
                conexion = new SQLiteConnection(vCadenaConexion);//Iniciamos el objeto para la conexion con la base de datos
                CrearTablas();
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
                conexion.Open(); //Abrimos la conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CrearTablas()
        {
            try
            {
                string vConsulta = File.ReadAllText("..\\..\\database.db.sql");//lee lo que esta en este archivo
                EjecutarComando(vConsulta);//ejecutalo
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
                conexion.Close(); //Cerramos la conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool EjecutarComando(string vConsulta) //Para realizar INSERTS o UPDATES o DELETE
        {
            try
            {
                AbrirConexion();
                SQLiteCommand sQLiteCommand = new SQLiteCommand("PRAGMA foreign_keys=ON;" + vConsulta, conexion);//Iniciamos un objeto para ejecutar comando en la base de datos
                //PRAGMA foreign_keys = ON; Es para que los contraints de foreign keys funcionen (ON DELETE CASCADE)
                if (sQLiteCommand.ExecuteNonQuery() > 0) //Si afecto registros
                {
                    CerrarConexion(); 
                    return true; //Retornar que fue exitosa
                }
                else
                {
                    CerrarConexion(); 
                    return false; //Retornar que hubo un fallo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        public DataSet ConsultarInfomacion(string vConsulta) //Para solicitar registros a la base de datos SELECT
        {
            try
            {
                AbrirConexion();
                DataSet ds = new DataSet(); //Tabla en memoria
                SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion); //Objeto para ejecutar comandos
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(sQLiteCommand); //Objeto para adaptar los datos de una consulta
                sQLiteDataAdapter.Fill(ds); //Carga los resultados de la consulta al DataSet
                CerrarConexion();
                return ds; //Retorna el dataset con los resultados de la consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null; //retorna null si hubo errores en la ejecucion
            
        }
        public object ConsultarValor(string vConsulta) //Para solicitar un valor en concreto a la base de datos SELECT
        {
            try
            {
                AbrirConexion();
                SQLiteCommand sQLiteCommand = new SQLiteCommand(vConsulta, conexion); //Objeto para ejecutar comandos sobre la base de datos
                object var = sQLiteCommand.ExecuteScalar(); //Ejecutar la consulta sobre la base de datos
                CerrarConexion();
                return var; //retornamos el valor de la peticion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }
    }
}
