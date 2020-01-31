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
using DatabaseAccess.UNA;

namespace NoteBook.UNA.Formularios
{
    public partial class AgregarCuadernoForm : Form
    {
        string colorCuaderno = "";
        public AgregarCuadernoForm()
        {
            InitializeComponent();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                AgregarCuaderno();
            }
        }
        public void AgregarCuaderno()
        {
            Cuaderno cuaderno = new Cuaderno();

            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            mysqlAccess.EjectSQL("INSERT INTO dbproyecto.cuadernos (idUsuario, nombre, categoria, color) " +
                "VALUES ('"+LogIn.EncontrarIdUsuario()+"','"+ textBoxNombre.Text + "','" + textBoxCategoria.Text + "','" + colorCuaderno +"')");
            mysqlAccess.CloseConnection();
            Limpiar();
            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Se ha agregado un cuaderno", "Cuaderno", "Cuaderno: "+cuaderno.Nombre);
            RegistroAcciones.Save(accion);
            MessageBox.Show("Se ha agregado el cuaderno", "Cuaderno Agregado", MessageBoxButtons.OK);
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
            if (pictureBoxColor.BackColor == BackColor)
            {
                errorProviderColor.SetError(buttonColor, "Debe seleccionar un color");
                resultado = false;
            }
            else
            {
                errorProviderColor.Clear();
            }
            if (HayCuadernoconMismoNombre())
            {
                resultado = false;
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
            pictureBoxColor.BackColor = BackColor;
            errorProviderCategoria.Clear();
            errorProviderColor.Clear();
            errorProviderNombre.Clear();
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColor.BackColor = MyDialog.Color;
                colorCuaderno = MyDialog.Color.ToArgb().ToString();
            }
            buttonAgregar.Focus();
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBoxCategoria.Focus();
            }
        }

        private void textBoxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                buttonColor.Focus();
            }
        }
        public bool HayCuadernoconMismoNombre()
        {
            bool resultado = true;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT * FROM dbproyecto.cuadernos WHERE nombre = '"+textBoxNombre.Text+"'");
            if(data.Rows.Count == 0)
            {
                resultado = false;
            }
            else
            {
                errorProviderNombre.SetError(textBoxNombre, "Ya hay un cuaderno con este nombre");
            }
            return resultado;
        }
    }
}
