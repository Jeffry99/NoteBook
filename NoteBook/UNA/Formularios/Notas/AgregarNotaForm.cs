using NoteBook.UNA.Helpers;
using NoteBook.UNA.Miscelaneo;
using DatabaseAccess.UNA;
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
        private string colorNota = "";

        public Cuaderno CuadernoActual
        {
            get;
            set;
        }
        public AgregarNotaForm(string nombreCuaderno)
        {
            InitializeComponent();
            CuadernoActual = new Cuaderno();
            CuadernoActual.Nombre = nombreCuaderno;
            pictureBoxColorLetra.BackColor = Color.Black;
            textBoxFuente.Text = richTextBoxNota.Font.ToString();
            nota.ColorLetra = Color.Black.ToArgb().ToString();
            nota.Fuente = richTextBoxNota.Font.ToString();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                colorNota = MyDialog.Color.ToArgb().ToString();
                nota.Color = colorNota;
                pictureBoxColor.BackColor = MyDialog.Color;

            }
            pictureBoxColor.BackColor = MyDialog.Color;
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
                pictureBoxColorLetra.BackColor = fontDialog1.Color;
                nota.Fuente = fontDialog1.Font.ToString();
                nota.ColorLetra = fontDialog1.Color.ToArgb().ToString();
            }
            richTextBoxNota.Focus();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (Validar())
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
            if (pictureBoxColor.BackColor == BackColor)
            {
                errorProvider.SetError(buttonColor, "Debe seleccionar un color");
                result = false;
            }
            if(textBoxFuente.TextLength == 0)
            {
                errorProvider.SetError(buttonFuente, "Debe seleccionar la fuente y el color de letra");
                result = false;
            }
            if (HayNotaconMismoNombre())
            {
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
            pictureBoxColor.BackColor = BackColor;
            richTextBoxNota.Clear();
            errorProvider.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }

        public void AgregarNotaEnCuadernoActual(Nota nota)
        {
            
        }
        public void AgregarNota()
        {
            nota.Titulo = textBoxTitulo.Text;
            nota.Privacidad = comboBoxPrivacidad.SelectedItem.ToString();
            nota.Categoria = textBoxCategoria.Text;
            nota.Texto = richTextBoxNota.Text;
            nota.FechaCreacion = DateTime.Now.ToString();
            nota.FechaModificacion = "Esta nota no ha sido modificada";
            nota.Texto = richTextBoxNota.Text;
            
            string encripta = Encrypt.Encriptar(nota.Texto);
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            
            if(nota.Privacidad == "Privado")
            {
                mysqlAccess.EjectSQL("INSERT INTO dbproyecto.notas (idCuadernos, titulo, privacidad, categoria, color, fuente, color_letra, fecha_creacion, fecha_modificacion, texto) " +
                "VALUES ('" + ObtenerIdCuaderno() + "','" + nota.Titulo + "','" + nota.Privacidad + "','" + nota.Categoria + "','" + nota.Color + "','" + nota.Fuente + "','" + nota.ColorLetra
                + "','" + nota.FechaCreacion + "','" + nota.FechaModificacion + "','" + encripta + "')");
            }
            else
            {
                mysqlAccess.EjectSQL("INSERT INTO dbproyecto.notas (idCuadernos, titulo, privacidad, categoria, color, fuente, color_letra, fecha_creacion, fecha_modificacion, texto) " +
                "VALUES ('" + ObtenerIdCuaderno() + "','" + nota.Titulo + "','" + nota.Privacidad + "','" + nota.Categoria + "','" + nota.Color + "','" + nota.Fuente + "','" + nota.ColorLetra
                + "','" + nota.FechaCreacion + "','" + nota.FechaModificacion + "','" + nota.Texto + "')");
            }


            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Se ha agregado una nota", "Nota", "Nota: " + nota.Titulo);
            RegistroAcciones.Save(accion);
            MessageBox.Show("Se ha agregado la nota correctamente", "Nota agregada", MessageBoxButtons.OK);
            
            Limpiar();
            Close();
        }
        public int ObtenerIdCuaderno()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            Console.WriteLine("Cuaderno: " + CuadernoActual.Nombre + " idUsuario: " + LogIn.EncontrarIdUsuario());
            DataTable data = mysqlAccess.QuerySQL("SELECT idCuadernos FROM dbproyecto.cuadernos WHERE nombre = '"+CuadernoActual.Nombre+"' AND idUsuario = '"+LogIn.EncontrarIdUsuario()+"'");
            int idCuaderno = Convert.ToInt32(data.Rows[0][0]);
            return idCuaderno;
        }
        public bool HayNotaconMismoNombre()
        {
            bool resultado = true;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT * FROM dbproyecto.notas WHERE titulo = '" + textBoxTitulo.Text + "'");
            if (data.Rows.Count == 0)
            {
                resultado = false;
            }
            else
            {
                errorProvider.SetError(textBoxTitulo, "Ya hay una nota con este nombre");
            }
            return resultado;
        }
    }



    


}
