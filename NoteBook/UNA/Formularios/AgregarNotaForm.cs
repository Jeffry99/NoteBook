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
    public partial class AgregarNotaForm : Form
    {
        private Nota nota = new Nota();
        public string CuadernoActual
        {
            get;
            set;
        }
        public AgregarNotaForm()
        {
            InitializeComponent();
            textBoxColorLetra.Text = richTextBoxNota.ForeColor.ToString();
            textBoxFuente.Text = richTextBoxNota.Font.ToString();
            nota.ColorLetra = richTextBoxNota.ForeColor.ToString();
            nota.Fuente = richTextBoxNota.Font.ToString();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                nota.Color = MyDialog.Color.ToString();
                textBoxColor.Text = MyDialog.Color.ToString();
            }
            buttonFuente.Focus();
        }

        private void buttonFuente_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBoxNota.Font;
            fontDialog1.Color = richTextBoxNota.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBoxNota.Font = fontDialog1.Font;
                richTextBoxNota.ForeColor = fontDialog1.Color;
                textBoxFuente.Text = fontDialog1.Font.ToString();
                textBoxColorLetra.Text = fontDialog1.Color.ToString();

                nota.Fuente = fontDialog1.Font.ToString();
                nota.ColorLetra = fontDialog1.Color.ToString();
                
            }
            richTextBoxNota.Focus();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                AgregarNota();
            }
            
        }
        private bool Validar()
        {
            bool result = true;
            if (textBoxTitulo.TextLength == 0)
            {
                errorProvider.SetError(textBoxTitulo, "Debe ingresar el título de la nota");
                result = false;
            }
            if (comboBoxPrivacidad.Text.Equals(""))
            {
                errorProvider.SetError(comboBoxPrivacidad, "Debe seleccionar la privacidad");
                result = false;
            }
            if(textBoxCategoria.TextLength == 0)
            {
                errorProvider.SetError(textBoxCategoria, "Debe ingresar una categoría");
                result = false;
            }
            if(textBoxColor.TextLength == 0)
            {
                errorProvider.SetError(buttonColor, "Debe seleccionar un color");
                result = false;
            }
            if(textBoxFuente.TextLength == 0)
            {
                errorProvider.SetError(buttonFuente, "Debe seleccionar la fuente y el color de letra");
                result = false;
            }

            return result;
        }

        private void textBoxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBoxPrivacidad.Focus();
            }
        }

        private void comboBoxPrivacidad_SelectedIndexChanged(object sender, EventArgs e)
        {
             textBoxCategoria.Focus();
        }

        private void textBoxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buttonColor.Focus();
            }
        }

        public void Limpiar()
        {
            textBoxTitulo.Clear();
            comboBoxPrivacidad.SelectedItem = null;
            textBoxCategoria.Clear();
            textBoxColor.Clear();
            textBoxFuente.Clear();
            textBoxColorLetra.Clear();
            richTextBoxNota.Clear();
            errorProvider.Clear();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AgregarNotaEnCuadernoActual(Nota nota)
        {
            foreach (Cuaderno c in Datos.cuadernos)
            {

                if (c.Nombre.Equals(CuadernoActual))
                {
                    c.notas.Add(nota);
                }
                
            }
        }

        public void AgregarNota()
        {
            nota.Titulo = textBoxTitulo.Text;
            nota.Privacidad = comboBoxPrivacidad.SelectedItem.ToString();
            nota.Categoria = textBoxCategoria.Text;
            nota.FechaCreacion = DateTime.Now.ToString();
            nota.FechaModificacion = "Esta nota no ha sido modificada";
            nota.Texto = richTextBoxNota.Text;

            AgregarNotaEnCuadernoActual(nota);
            Datos.SaveToFile();
            MessageBox.Show("Se ha agregado la nota correctamente", "Nota agregada", MessageBoxButtons.OK);
            Limpiar();
        }
    }
}
