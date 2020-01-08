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
using NoteBook.UNA.Helpers;

namespace NoteBook.UNA.Formularios
{
    public partial class AgregarCuadernoForm : Form
    {
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
            int ultimoIndice = 0;
            foreach (Cuaderno c in Datos.cuadernos)
            {
                ultimoIndice++;
            }
            Cuaderno cuaderno = new Cuaderno
            {
                Nombre = textBoxNombre.Text,
                Categoria = textBoxCategoria.Text,
                Color = comboBoxColor.Text,
                Orden = ultimoIndice + 1
            };
            Datos.cuadernos.Add(cuaderno);
            Datos.SaveToFile();
            Limpiar();

            Accion accion = new Accion(LogIn.usuario.nombreUsuario, "Ha agregado un cuaderno", cuaderno.Nombre, "");
            RegistroAcciones.acciones.Add(accion);
            RegistroAcciones.SaveToFile();
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
