using DatabaseAccess.UNA;
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
        public Cuaderno Cuaderno
        {
            get;
            set;
        }
        public EditarCuadernoForm(string nombreCuaderno)
        {
            InitializeComponent();
            Cuaderno = new Cuaderno();
            Cuaderno.Nombre = nombreCuaderno;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable table = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos WHERE nombre = '" + Cuaderno.Nombre + "' AND idUsuario = '" + LogIn.EncontrarIdUsuario() + "'");
            textBoxNombre.Text = table.Rows[0][0].ToString();
            textBoxCategoria.Text = table.Rows[0][1].ToString();
            pictureBoxColor.BackColor = Color.FromArgb(Convert.ToInt32(table.Rows[0][2].ToString()));
            mysqlAccess.CloseConnection();

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
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            mysqlAccess.EjectSQL("UPDATE dbproyecto.cuadernos SET nombre ='"+textBoxNombre.Text+"', categoria = '"+textBoxCategoria.Text
                +"', color = '"+pictureBoxColor.BackColor.ToArgb().ToString()+"' WHERE nombre = '"+Cuaderno.Nombre+"'");
            mysqlAccess.CloseConnection();
            Limpiar();
            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Se ha editado un cuaderno", "Cuaderno", "Cuaderno: " + Cuaderno.Nombre);
            RegistroAcciones.Save(accion);
            MessageBox.Show("Se ha editado el cuaderno", "Cuaderno Editado", MessageBoxButtons.OK);
            Close();
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
            if (pictureBoxColor.BackColor.Equals(BackColor))
            {
                errorProviderColor.SetError(buttonSeleccionarColor, "Debe seleccionar un color");
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
            errorProviderCategoria.Clear();
            errorProviderColor.Clear();
            errorProviderNombre.Clear();
        }

        private void buttonSeleccionarColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColor.BackColor = MyDialog.Color;
            }
            buttonCambiar.Focus();
        }

        private void EditarCuadernoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
