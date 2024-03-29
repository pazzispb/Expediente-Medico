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
    public partial class frmCrearCuenta : Form
    {
        clsBaseDatos bd = new clsBaseDatos();
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarClaves())
            {
                string vConsulta = $"INSERT INTO Usuarios (usuario, clave, nombre, " +
                $"apellido, cedula, fechaNacimiento, altura, peso, tipoSangre, seguroMedico, telefono) " +
                $"VALUES ('{txtUsuario.Text}', '{txtClave.Text}', '{txtNombre.Text}', '{txtApellido.Text}', '{txtCedula.Text}', " +
                $"'{dtpFecha.Text}', {txtAltura.Text}, {txtPeso.Text}, '{cmbTipoSangre.Text}', '{txtSeguroMedico.Text}', '{txtTelefono.Text}')";
                if (ValidarCamposRellenos()) //Si todos los campos tienen un contenido
                    if (bd.EjecutarComando(vConsulta))//Si se agrego el registro
                    {
                        MessageBox.Show("Usuario registrado con éxito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        this.Close();
                    }
                    else MessageBox.Show("Hubo un error al registrar el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        bool ValidarClaves() 
        {
            if(txtClave.Text == txtClave2.Text) 
            {
                return true; //Si las claves coinciden
            }
            else
            {
                MessageBox.Show("Las contraseñas introducidas no son iguales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) //si el caracter ingresador es un digito
            {
                e.Handled = true; //maneja el evento
            }
        }
        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtAltura.Text.IndexOf(".") != -1) e.Handled = true; //si es un punto y ya hay puntos dentro del campo
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar)) e.Handled = true; //si no es un digito o un punto
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtPeso.Text.IndexOf(".") != -1) e.Handled = true; //si es un punto y ya hay puntos dentro del campo
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar)) e.Handled = true; //si no es un digito o un punto
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e) //al cargar el formulario
        {
            cmbTipoSangre.SelectedIndex = 0; //Selecciona el primer elemento del combobox
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = "";
                }
        }

        private void frmCrearCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms) //Recorre los formularios abiertos
                if (typeof(frmLogIn) == frm.GetType()) //Buscar el formulario de LogIn
                {
                    frm.Show(); //Muestra el formulario
                    break; //Sal del bucle
                }
        }
    }
}