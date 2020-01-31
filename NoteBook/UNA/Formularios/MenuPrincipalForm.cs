﻿using DatabaseAccess.UNA;
using Microsoft.Build.Framework.XamlTypes;
using Newtonsoft.Json;
using NoteBook.UNA.Formularios.Usuario;
using NoteBook.UNA.Helpers;
using NoteBook.UNA.Miscelaneo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook.UNA.Formularios
{
    public partial class MenuPrincipalForm : Form
    {

        public static List<Nota> nota;

        public MenuPrincipalForm()
        {
            InitializeComponent();



        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable table = mysqlAccess.QuerySQL("SELECT idUsuarios FROM dbproyecto.usuarios");
            mysqlAccess.CloseConnection();
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados", "Agregar usuarios", MessageBoxButtons.OK);
                AgregarUsuarioForm agregarUsuarioForm = new AgregarUsuarioForm();
                agregarUsuarioForm.ShowDialog();
            }

            IngresarUsuarioForm signin = new IngresarUsuarioForm();
            signin.ShowDialog();
            signin.Close();
            Show();

            CargarDataGrid();
            ValidarDataTable();
            statusStripUsuario.Text = "Usuario Actual: " + LogIn.usuario.NombreUsuario;

        }

        private void buttonAgregarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarCuadernoForm agregarCuaderno = new AgregarCuadernoForm();
            agregarCuaderno.ShowDialog();
            
            Show();
            CargarDataGrid();
            ValidarDataTable();
        }


        private void dataGridViewCuadernos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();
            Cuaderno cuaderno = new Cuaderno();
            string nombreCuaderno = dataGridViewCuadernos.SelectedRows[0].Cells[0].Value.ToString();
 
            NotasForm notas = new NotasForm(nombreCuaderno);
            notas.Text = nombreCuaderno;
            notas.ShowDialog();
            Show();
           
        }
        private void historialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HistorialForm historial = new HistorialForm();
            Hide();
            historial.ShowDialog();
            Show();

        }
        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            BuscarCuaderno();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContrasenaForm cambiarContrasena = new CambiarContrasenaForm();
            Hide();
            cambiarContrasena.ShowDialog();
            Show();
        }

        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (LogIn.usuario.TipoUsuario.Equals("Administrador"))
            {
                AgregarUsuarioForm agregarUsuario = new AgregarUsuarioForm();
                Hide();
                agregarUsuario.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("No tiene permiso para realizar esta función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDataGrid()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewCuadernos.DataSource = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos WHERE idUsuario ='" + LogIn.EncontrarIdUsuario() + "'");
            mysqlAccess.CloseConnection();
        }

        private void textBoxNombreCuadernoBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarCuaderno();
            }
        }
        public void BuscarCuaderno()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewCuadernos.DataSource = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos WHERE nombre LIKE '%"
                + textBoxNombreCuadernoBusqueda.Text + "%' AND idUsuario = '"+LogIn.EncontrarIdUsuario()+"'");
            mysqlAccess.CloseConnection();
            if (dataGridViewCuadernos.Rows.Count == 0)
            {
                dataGridViewCuadernos.Visible = false;
                labelCuadernoNoEncontrado.Visible = true;
            }
            else
            {
                dataGridViewCuadernos.Visible = true;
                labelCuadernoNoEncontrado.Visible = false;
            }
        }
        public void ValidarDataTable()
        {
            if (dataGridViewCuadernos.Rows.Count == 0)
            {
                dataGridViewCuadernos.Visible = false;
                labelCuadernosDisponibles.Visible = false;
                labelAgregar.Visible = true;
                labelNoCuadernos.Visible = true;
            }
            else
            {
                dataGridViewCuadernos.Visible = true;
                labelCuadernosDisponibles.Visible = true;
                labelAgregar.Visible = false;
                labelNoCuadernos.Visible = false;
            }
            labelCuadernoNoEncontrado.Visible = false;
        }

        private void buttonModificarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            if (dataGridViewCuadernos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el cuaderno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombreCuaderno = dataGridViewCuadernos.SelectedRows[0].Cells[0].Value.ToString();
                EditarCuadernoForm editarCuaderno = new EditarCuadernoForm(nombreCuaderno);
                editarCuaderno.ShowDialog();
                Show();
                CargarDataGrid();
                ValidarDataTable();
            }
        }

        private void buttonEliminarCuaderno_Click(object sender, EventArgs e)
        {
            string nombreCuaderno = "";
            if (dataGridViewCuadernos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el cuaderno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreCuaderno = dataGridViewCuadernos.SelectedRows[0].Cells[0].Value.ToString();
                MysqlAccess mysqlAccess = new MysqlAccess();
                mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
                mysqlAccess.OpenConnection();
                DataTable data = mysqlAccess.QuerySQL("SELECT idCuadernos FROM dbproyecto.cuadernos WHERE nombre = '" + nombreCuaderno + "'");
                int idCuaderno = Convert.ToInt32(data.Rows[0][0].ToString());
                try
                {
                    mysqlAccess.EjectSQL("DELETE FROM dbproyecto.cuadernos WHERE idCuadernos = '" + idCuaderno + "'");
                }
                catch (Exception)
                {
                    MessageBox.Show("No puede eliminar este cuaderno porque tiene notas relacionadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mysqlAccess.CloseConnection();

                CargarDataGrid();
                ValidarDataTable();
            } 
        }

        private void buttonEliminarCuaderno_DragOver(object sender, DragEventArgs e)
        {
            helpProvider.SetHelpString(buttonEliminarCuaderno, "Debe dar click sobre el cuaderno que desea eliminar");
        }

        private void buttonEliminarCuaderno_MouseHover(object sender, EventArgs e)
        {
            helpProvider.SetHelpString(buttonEliminarCuaderno, "Debe dar click sobre el cuaderno que desea eliminar");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Hide();
                IngresarUsuarioForm signin = new IngresarUsuarioForm();
                signin.ShowDialog();
                signin.Close();


                CargarDataGrid();
                ValidarDataTable();
                statusStripUsuario.Text = "Usuario Actual: " + LogIn.usuario.NombreUsuario;
                Show();
            }
            
            
        }
    }
}
