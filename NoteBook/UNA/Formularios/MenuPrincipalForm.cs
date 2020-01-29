using DatabaseAccess.UNA;
using Microsoft.Build.Framework.XamlTypes;
using Newtonsoft.Json;
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
        public static List<Cuaderno> cuadernos;
        public static List<Nota> nota;

        public MenuPrincipalForm()
        {
            InitializeComponent();
            CargarDataGrid();
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

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

            IngresarUsuarioForm signin = new IngresarUsuarioForm();
            signin.ShowDialog();
            signin.Close();
            Show();
            statusStripUsuario.Text = "Usuario Actual: " + LogIn.usuario.NombreUsuario;
            
        }

        private void buttonAgregarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarCuadernoForm agregarCuaderno = new AgregarCuadernoForm();
            agregarCuaderno.ShowDialog();
            CargarDataGrid();
            Show();
        }


        private void dataGridViewCuadernos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Hide();
            Cuaderno cuaderno = new Cuaderno();
            foreach (DataGridViewRow c in dataGridViewCuadernos.SelectedRows)
            {
                cuaderno = (Cuaderno)c.DataBoundItem;
            }




            NotasForm notas = new NotasForm();
            notas.Text = cuaderno.Nombre;
            notas.ShowDialog();


            Show();
            dataGridViewCuadernos.DataSource = Datos.cuadernos;
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
                MessageBox.Show("No tiene permiso para realizar esta función", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDataGrid()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewCuadernos.DataSource = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos");
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
                + textBoxNombreCuadernoBusqueda.Text + "%'");
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
    }
}
