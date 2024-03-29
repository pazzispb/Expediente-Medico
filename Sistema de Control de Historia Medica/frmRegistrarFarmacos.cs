﻿using System;
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
    public partial class frmRegistrarFarmacos : Form
    {
        clsBaseDatos bd = new clsBaseDatos(); //objeto de base de datos
        public frmFarmacos frmFarmacos = new frmFarmacos(); //formulario de farmacos para poder realizar operaciones sobre el
        public frmRegistrarFarmacos()
        {
            InitializeComponent();
        }

        private void btnGuardarFarmaco_Click(object sender, EventArgs e)
        {
            string vConsulta = $"INSERT INTO Farmacos (nombreFarmaco, frecuenciaFarmaco, dosisFarmaco, descripcionFarmaco, veces, idUsuario)" +
                $"VALUES ('{txtFarmaco.Text}', '{cmbFrecuenciaFarmaco.Text}', '{txtDosisFarmaco.Text}', '{txtDescripcionFarmaco.Text}', '{cmbVeces.Text}', {frmMenuPrincipal.vIdUsuario})";
            if (ValidarCamposRellenos())//Si todos los campos tienen un contenido
                if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                {
                    MessageBox.Show("Fármaco registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmFarmacos.cargarFarmacos();//actualiza el datagrid del formulario farmacos
                    LimpiarCampos();
                    this.Close();
                }
        }
        bool ValidarCamposRellenos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos del formulario
                if (String.IsNullOrWhiteSpace(c.Text)) //Si esta vacio
                {
                    MessageBox.Show("Rellene los campos vacios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; //retorna que hay campos no rellenos
                }
            return true; //retorna que los campos estan rellenos
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos del formulario
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarFarmacos_Load(object sender, EventArgs e)
        {
            cmbVeces.SelectedIndex = 0;//primer elemento seleccionado
            cmbFrecuenciaFarmaco.SelectedIndex = 0; //primer elemento seleccionado
        }
    }
}
