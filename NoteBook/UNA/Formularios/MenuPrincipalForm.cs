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
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewCuadernos.DataSource = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos");
            if(dataGridViewCuadernos.Rows.Count == 0)
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
            
            mysqlAccess.CloseConnection();

        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

            IngresarUsuarioForm signin = new IngresarUsuarioForm();
            //signin.ShowDialog();
            //signin.Close();

            Show();
            statusStripUsuario.Text = "Usuario Actual: " + LogIn.usuario.nombreUsuario;
            
        }

        private void buttonAgregarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarCuadernoForm agregarCuaderno = new AgregarCuadernoForm();
            agregarCuaderno.ShowDialog();

            dataGridViewCuadernos.DataSource = Datos.cuadernos;

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

        private void textBoxNombreCuadernoBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Cuaderno> cuadernoNombre = new List<Cuaderno>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                Console.WriteLine(c.Nombre);
                if (c.Nombre == textBoxNombreCuadernoBusqueda.Text)
                {
                    cuadernoNombre.Add(c);
                }
            }
            dataGridViewCuadernos.DataSource = cuadernoNombre;
        }
        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
        }

    }
}
