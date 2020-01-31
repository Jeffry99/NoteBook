using DatabaseAccess.UNA;
using NoteBook.UNA.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook.UNA.Formularios.Notas
{
    public partial class EditarNotaForm : Form
    {
        public EditarNotaForm()
        {
            InitializeComponent();
        }
        public Nota Nota
        {
            get;
            set;
        }
        private string colorNota = "";

        public Cuaderno CuadernoActual
        {
            get;
            set;
        }
        public EditarNotaForm(string nombreCuaderno)
        {
            InitializeComponent();
            Nota = new Nota();
            CuadernoActual = new Cuaderno();
            CuadernoActual.Nombre = nombreCuaderno;
            pictureBoxColorLetra.BackColor = richTextBoxNota.ForeColor;
            textBoxFuente.Text = richTextBoxNota.Font.ToString();
            Nota.ColorLetra = richTextBoxNota.ForeColor.ToString();
            Nota.Fuente = richTextBoxNota.Font.ToString();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                colorNota = MyDialog.Color.ToArgb().ToString();
                Nota.Color = colorNota;
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

                Nota.Fuente = fontDialog1.Font.ToString();
                Nota.ColorLetra = fontDialog1.Color.ToArgb().ToString();
            }
            richTextBoxNota.Focus();
        }
        private bool ValidarCampos()
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
            if (textBoxCategoria.TextLength == 0)
            {
                errorProvider.SetError(textBoxCategoria, "Debe ingresar una categoría");
                result = false;
            }
            if (pictureBoxColor.BackColor == BackColor)
            {
                errorProvider.SetError(buttonColor, "Debe seleccionar un color");
                result = false;
            }
            if (textBoxFuente.TextLength == 0)
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
            pictureBoxColor.BackColor = BackColor;
            richTextBoxNota.Clear();
            errorProvider.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }
        public void EditarNota()
        {
            
            Nota.Privacidad = comboBoxPrivacidad.SelectedItem.ToString();
            Nota.Categoria = textBoxCategoria.Text;
            Nota.Texto = richTextBoxNota.Text;
            string tituloNuevo = textBoxTitulo.Text;
            Console.WriteLine("Titulo: "+Nota.Titulo);
            string fechaModificacion = DateTime.Now.ToString();
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            mysqlAccess.EjectSQL("UPDATE dbproyecto.notas SET idCuadernos = '" + ObtenerIdCuaderno() + "', titulo = '" + tituloNuevo + "', privacidad = '" + Nota.Privacidad
                + "', categoria = '" + Nota.Categoria + "', color = '" + Nota.Color + "', fuente = '" + Nota.Fuente + "', color_letra = '" + Nota.ColorLetra
                + "', fecha_modificacion = '" + fechaModificacion + "', texto = '" + Nota.Texto+ "' WHERE titulo = '"+Nota.Titulo+"'");
            mysqlAccess.CloseConnection();
            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Se ha editado una nota", "Nota", "Nota: " + Nota.Titulo);
            RegistroAcciones.Save(accion);
            MessageBox.Show("Se ha editado la nota exitosamente", "Listo", MessageBoxButtons.OK);
            Close();
        }
        public int ObtenerIdCuaderno()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT idCuadernos FROM dbproyecto.cuadernos WHERE nombre = '" + CuadernoActual.Nombre + "' AND idUsuario = '" + LogIn.EncontrarIdUsuario() + "'");
            mysqlAccess.CloseConnection();
            int idCuaderno = Convert.ToInt32(data.Rows[0][0]);
            return idCuaderno;
        }

        private void EditarNotaForm_Load(object sender, EventArgs e)
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT titulo, privacidad, categoria, color, fuente, color_letra, texto FROM dbproyecto.notas WHERE titulo = '" + Nota.Titulo +"' AND idCuadernos = '"+ObtenerIdCuaderno()+"'");
            Nota.Color = data.Rows[0][3].ToString();
            Nota.ColorLetra = data.Rows[0][5].ToString();
            
            textBoxTitulo.Text = data.Rows[0][0].ToString();
            textBoxCategoria.Text = data.Rows[0][2].ToString();
            pictureBoxColor.BackColor = Color.FromArgb(Convert.ToInt32(data.Rows[0][3].ToString()));
            textBoxFuente.Text = data.Rows[0][4].ToString();
            Nota.Privacidad = data.Rows[0][1].ToString();

            pictureBoxColorLetra.BackColor = Color.FromArgb(Convert.ToInt32(data.Rows[0][5].ToString()));
            richTextBoxNota.Text = data.Rows[0][6].ToString();
            
            int pri = 0;
            if(Nota.Privacidad == "Privado")
            {
                pri = 1;
                richTextBoxNota.Text = Encrypt.Desencriptar(data.Rows[0][6].ToString());         
            }
          
           
            comboBoxPrivacidad.SelectedIndex = pri;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarCampos())
            {
                EditarNota();
            }
        }
    }
}
