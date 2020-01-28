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
        
        public NotasForm()
        {
            InitializeComponent();
            if (dataGridViewNotas.Rows.Count == 0)
            {
                dataGridViewNotas.Visible = false;
                labelNotasDisponibles.Visible = false;
                labelAgregar.Visible = true;
                labelNoNotas.Visible = true;
            }
            else
            {
                dataGridViewNotas.Visible = true;
                labelNotasDisponibles.Visible = true;
                labelAgregar.Visible = false;
                labelNoNotas.Visible = false;
            }
        }

        private void buttonAgregarNota_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarNotaForm agregarNota = new AgregarNotaForm();
            agregarNota.CuadernoActual = EncontrarCuadernoActual();
            agregarNota.Text = "Agregar Nota en: " + agregarNota.CuadernoActual.Nombre;
            agregarNota.ShowDialog();
            dataGridViewNotas.DataSource = EncontrarCuadernoActual().notas;
            Show();

        }


        private void NotasForm_Load(object sender, EventArgs e)
        {
            dataGridViewNotas.DataSource = EncontrarCuadernoActual().notas;
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewNotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerNotaForm notaForm = new VerNotaForm();
            Nota nota = new Nota();
            foreach (DataGridViewRow c in dataGridViewNotas.SelectedRows)
            {
                nota = (Nota)c.DataBoundItem;
                Console.WriteLine(nota.Titulo);
            }
            notaForm.richTextBoxNota.Text = dataGridViewNotas.CurrentCell.Value.ToString();
            //notaForm.Nota = nota;
            //notaForm.richTextBoxNota.Text = nota.Texto;
            Hide();
            notaForm.ShowDialog();
            Show();
        }
        private void textBoxTituloNotaBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Nota> tituloNota = new List<Nota>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                if (c.Nombre == EncontrarCuadernoActual().Nombre) { 
                    foreach(Nota n in c.notas)
                    {
                        if (textBoxTituloNotaBusqueda.Text == n.Titulo)
                        {
                            tituloNota.Add(n);
                        }
                    }
                }
            }
            dataGridViewNotas.DataSource = tituloNota;
        }
        private void notaBusqueda_Click(object sender, EventArgs e)
        {
            List<Nota> nota = new List<Nota>();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                //if (c.Nombre == EncontrarCuadernoActual().Nombre)
                //{
                //    foreach (Nota n in c.notas)
                //    {
                //        if (textBoxTituloNotaBusqueda.Text == n.Titulo &&
                //        comboBoxPrivacidadNotaBusqueda.Text == n.Privacidad)
                //        {
                //            nota.Add(n);
                //        }
                //    }
                //}
            }
            dataGridViewNotas.DataSource = nota;
        }
    }
}
