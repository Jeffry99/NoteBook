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
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

            IngresarUsuarioForm signin = new IngresarUsuarioForm();
            signin.ShowDialog();
            signin.Close();

            Show();
            statusStripUsuario.Text = "Usuario Actual: " + LogIn.usuario.nombreUsuario;
            dataGridViewCuadernos.DataSource = Datos.cuadernos;
            
        }

        private void buttonAgregarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarCuadernoForm agregarCuaderno = new AgregarCuadernoForm();
            agregarCuaderno.ShowDialog();

            dataGridViewCuadernos.DataSource = Datos.cuadernos;
            Show();
            
        }

        private void dataGridViewCuadernos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            
            
            textBoxNombreCuadernoBusqueda.Clear();
            pictureBoxColor.BackColor = BackColor;
            textBoxNombreCuadernoBusqueda.Text = " ";
            pictureBoxColor.BackColor = BackColor;
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
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColor.BackColor = MyDialog.Color;
            }
            pictureBoxColor.BackColor = MyDialog.Color;

            List<Cuaderno> cuadernoColor = new List<Cuaderno>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                if (pictureBoxColor.BackColor.ToString() == c.Color)
                {
                    cuadernoColor.Add(c);
                }
            }
            dataGridViewCuadernos.DataSource = cuadernoColor;
        }
        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            List<Cuaderno> cuadernoFiltrado = new List<Cuaderno>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                if (pictureBoxColor.BackColor.ToString() == c.Color && textBoxNombreCuadernoBusqueda.Text == c.Nombre)
                {
                    cuadernoFiltrado.Add(c);
                }
            }
            dataGridViewCuadernos.DataSource = cuadernoFiltrado;
        }

        private void pictureBoxColor_Click(object sender, EventArgs e)
        {

        }
    }
}
