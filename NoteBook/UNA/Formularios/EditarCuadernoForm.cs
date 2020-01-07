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
    public partial class EditarCuadernoForm : Form
    {
        public EditarCuadernoForm()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                EditarCuaderno();
            }
        }

        public void EditarCuaderno()
        {
            //Obtener el cuaderno que se quiere editar 

            foreach (Cuaderno c in Datos.cuadernos)
            {
                
            }
            
            //Datos.cuadernos.Add(cuaderno);
            Datos.SaveToFile();
            Limpiar();

            MessageBox.Show("Se ha editado el cuaderno", "Cuaderno Editado", MessageBoxButtons.OK);
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


    }
}
