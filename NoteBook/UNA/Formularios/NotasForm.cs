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
    public partial class NotasForm : Form
    {
        private AgregarNotaForm agregarNota = new AgregarNotaForm();
        public NotasForm()
        {
            InitializeComponent();
        }

        private void buttonAgregarNota_Click(object sender, EventArgs e)
        {
            Hide();
            agregarNota.CuadernoActual = EncontrarCuadernoActual().Nombre;
            agregarNota.Text = "Agregar Nota en: " + agregarNota.CuadernoActual;
            agregarNota.ShowDialog();

            dataGridViewNotas.DataSource = EncontrarCuadernoActual().notas;
            dataGridViewNotas.Refresh();
            Show();
            

        }

        private void dataGridViewNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NotasForm_Load(object sender, EventArgs e)
        {
            dataGridViewNotas.DataSource = EncontrarCuadernoActual().notas;
            dataGridViewNotas.Refresh();
        }

        public Cuaderno EncontrarCuadernoActual()
        {
            Cuaderno cuaderno = new Cuaderno();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                if (c.Nombre.Equals(Text))
                {
                    cuaderno = c;
                }
            }
            return cuaderno;
        }
    }
}
