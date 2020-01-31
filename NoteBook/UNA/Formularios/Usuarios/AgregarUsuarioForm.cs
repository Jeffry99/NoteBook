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

namespace NoteBook.UNA.Formularios
{
    public partial class AgregarUsuarioForm : Form
    {
        public AgregarUsuarioForm()
        {
            InitializeComponent();
        }
        public bool ValidarCampos()
        {
            bool resultado = true;
            if (textBoxNombreUsuario.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxNombreUsuario, "Debe ingresar el nombre de usuario");
            }
            if (textBoxNombreReal.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxNombreReal, "Debe ingresar el nombre completo");
            }
            if (textBoxContrasena.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxContrasena, "Debe ingresar una contraseña");
            }
            if (comboBoxTipoUsuario.SelectedItem == null)
            {
                resultado = false;
                errorProvider.SetError(comboBoxTipoUsuario, "Debe definir el tipo de usuario");
            }
            if (HayUsuarioconMismoNombre())
            {
                resultado = false;
            }
            return resultado;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AgregarUsuario();
            }
        }
        public void AgregarUsuario()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            mysqlAccess.EjectSQL("INSERT INTO dbproyecto.usuarios (nombre_usuario, nombre_real, contraseña, tipo_usuario) " +
                "VALUES ('" + textBoxNombreUsuario.Text + "','" + textBoxNombreReal.Text + "','" + Encrypt.Encriptar(textBoxContrasena.Text) + "','"
                + comboBoxTipoUsuario.SelectedItem.ToString() + "')");
            mysqlAccess.CloseConnection();
            MessageBox.Show("Se ha agregado el usuario", "Listo", MessageBoxButtons.OK);
            Close();
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool HayUsuarioconMismoNombre()
        {
            bool resultado = true;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT * FROM dbproyecto.usuarios WHERE nombre_usuario = '" + textBoxNombreUsuario.Text + "'");
            if (data.Rows.Count == 0)
            {
                resultado = false;
            }
            else
            {
                errorProvider.SetError(textBoxNombreUsuario, "Ya hay un usuario con este nombre");
            }
            return resultado;
        }
    }
}
