using NoteBook.UNA.Helpers;
using NoteBook.UNA.Miscelaneo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook.UNA.Formularios
{
    public partial class MenuPrincipalForm : Form
    {
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
            AgregarCuadernoForm AgregarCuaderno = new AgregarCuadernoForm();
            AgregarCuaderno.ShowDialog();

            dataGridViewCuadernos.DataSource = Datos.cuadernos;
            Console.WriteLine("jdjdjdjd");
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

            dataGridViewCuadernos.DataSource = Datos.cuadernos;
            //dataGridViewCuadernos.Refresh();

            Show();
            dataGridViewCuadernos.DataSource = Datos.cuadernos;
        }
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            
            dataGridViewCuadernos.DataSource = Datos.cuadernos;
            
            dataGridViewCuadernos.Refresh();
            Console.WriteLine("refrescado");
        }


        private void historialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HistorialForm historial = new HistorialForm();
            Hide();
            historial.ShowDialog();
            Show();

        }
    }
}
