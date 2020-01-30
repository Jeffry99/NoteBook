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
            //int ultimoIndice = 0;
            //foreach (Cuaderno c in Datos.cuadernos)
            //{
            //    ultimoIndice++;
            //}
            //{
            //    Nombre = textBoxNombre.Text,
            //    Categoria = textBoxCategoria.Text,
            //    Color = pictureBoxColor.BackColor.ToString(),
            //    Orden = ultimoIndice + 1
            //};
            //Datos.cuadernos.Add(cuaderno);
            //Datos.SaveToFile();

            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            int orden = 1;
            mysqlAccess.EjectSQL("INSERT INTO dbproyecto.cuadernos (idUsuario, nombre, categoria, color, orden) " +
                "VALUES ('"+LogIn.EncontrarIdUsuario()+"','"+ textBoxNombre.Text + "','" + textBoxCategoria.Text + "','" + pictureBoxColor.BackColor.ToString() + "','"+orden+"')");
            
            mysqlAccess.CloseConnection();
            Limpiar();

            Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Ha agregado un cuaderno", cuaderno.Nombre, "");
            RegistroAcciones.acciones.Add(accion);
            RegistroAcciones.SaveToFile();
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
            //validar para cuadernos con el mismo nombre
            
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
            }
            buttonAgregar.Focus();
        }
        
    }
}
