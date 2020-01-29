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
            return resultado;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }
        }

        public void AgregarUsuario()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            mysqlAccess.EjectSQL("INSERT INTO dbproyecto.usuarios (nombre_usuario, nombre_real, contraseña, tipo_usuario) " +
                "VALUES ('" + textBoxNombreUsuario.Text + "','" + textBoxNombreReal.Text + "','" + textBoxContrasena.Text + "','" 
                + comboBoxTipoUsuario.SelectedItem.ToString() + "')");
        }
    }
}
