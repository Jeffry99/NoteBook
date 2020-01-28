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
            //TODO Terminar esta funcion del programa
            //Obtener el cuaderno que se quiere editar 
            Cuaderno cuaderno = new Cuaderno();
            foreach (Cuaderno c in Datos.cuadernos)
            {
                
            }
            
            //Datos.cuadernos.Add(cuaderno);
            Datos.SaveToFile();
            Limpiar();
            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Ha editado un cuaderno", cuaderno.Nombre, "");
            RegistroAcciones.acciones.Add(accion);
            RegistroAcciones.SaveToFile();
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
