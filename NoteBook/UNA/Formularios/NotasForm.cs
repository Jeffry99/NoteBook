using Newtonsoft.Json;
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
    public partial class NotasForm : Form
    {

        public static List<Cuaderno> cuadernos;
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

        private void buttonEditarNota_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloBusquedaNota_TextChanged(object sender, EventArgs e)
        {
            string path = @".\cuadernos.json";
            string readText = File.ReadAllText(path);
            cuadernos = JsonConvert.DeserializeObject<List<Cuaderno>>(readText);

            List<Nota> buscarNotasTitulo = new List<Nota>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                foreach(Nota n in c.notas)
                {
                    if(textBoxTituloBusquedaNota.Text == n.Titulo)
                    {
                        buscarNotasTitulo.Add(n);
                    }
                }
            }
            dataGridViewNotas.DataSource = buscarNotasTitulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBoxPrivacidadNotasBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = @".\cuadernos.json";
            string readText = File.ReadAllText(path);
            cuadernos = JsonConvert.DeserializeObject<List<Cuaderno>>(readText);

            List<Nota> buscarNotasPrivacidad = new List<Nota>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                EncontrarCuadernoActual();
                foreach (Nota n in c.notas)
                {
                    if (Convert.ToString(comboBoxPrivacidadNotasBusqueda.SelectedItem) == n.Privacidad)
                    {
                        buscarNotasPrivacidad.Add(n);
                    }
                }
                
            }
            dataGridViewNotas.DataSource = buscarNotasPrivacidad;
        }
    }
}
