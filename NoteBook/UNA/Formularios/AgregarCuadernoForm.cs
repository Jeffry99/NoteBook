using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NoteBook.UNA.Miscelaneo;

namespace NoteBook.UNA.Formularios
{
    public partial class AgregarCuadernoForm : Form
    {
        //private List<Cuaderno> cuadernos = new List<Cuaderno>();
        public AgregarCuadernoForm()
        {
            InitializeComponent();
        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                AgregarCuaderno();
            }
        }

        public void AgregarCuaderno()
        {
            Cuaderno cuaderno = new Cuaderno
            {
                nombre = textBoxNombre.Text,
                categoria = textBoxCategoria.Text,
                color = comboBoxColor.Text
            };
            Datos.cuadernos.Add(cuaderno);
            Datos.SaveToFile();
            Limpiar();

            MessageBox.Show("Se ha agregado el cuaderno", "Cuaderno Agregado", MessageBoxButtons.OK);
        }

        public bool Validar()
        {
            bool resultado = true;
            if (textBoxNombre.Text.Equals(""))
            {
                errorProviderNombre.SetError(textBoxNombre, "Debe ingresar el nombre del cuaderno");
                resultado = false;
            }
            else
            {
                errorProviderNombre.Clear();
            }
            if (textBoxCategoria.Text.Equals(""))
            {
                errorProviderCategoria.SetError(textBoxCategoria, "Debe definir la categoría");
                resultado = false;
            }
            else
            {
                errorProviderCategoria.Clear();
            }
            if (comboBoxColor.Text.Equals(""))
            {
                errorProviderColor.SetError(comboBoxColor, "Debe seleccionar un color");
                resultado = false;
            }
            else
            {
                errorProviderColor.Clear();
            }
            return resultado;            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxCategoria.Clear();
            comboBoxColor.SelectedItem = null;

            errorProviderCategoria.Clear();
            errorProviderColor.Clear();
            errorProviderNombre.Clear();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar = " ";
        }
    }
}
