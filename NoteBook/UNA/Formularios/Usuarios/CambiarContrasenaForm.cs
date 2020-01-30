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

namespace NoteBook.UNA.Formularios.Usuario
{
    public partial class CambiarContrasenaForm : Form
    {
        public CambiarContrasenaForm()
        {
            InitializeComponent();
        }
        public bool ValidarCampos()
        {
            bool resultado = true;
            if (textBoxContrasenaActual.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxContrasenaActual, "Debe ingresar su contraseña actual");
            }
            if (textBoxContrasenaActual.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxContrasenaNueva, "No ingresó la contraseña nueva");
            }
            if (textBoxContrasenaActual.Text.Equals(""))
            {
                resultado = false;
                errorProvider.SetError(textBoxConfirmarContrasena, "Debe confirmar la contraseña nueva");
            }
            
            return resultado;
        }
        public bool ValidarContrasenas()
        {
            bool resultado = true;
           
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable dat =  mysqlAccess.QuerySQL("SELECT contraseña FROM dbproyecto.usuarios WHERE nombre_usuario = '" + LogIn.usuario.NombreUsuario + "'");
            Console.WriteLine(dat.Rows[0][0].ToString());
            mysqlAccess.CloseConnection();

            if (!(dat.Rows[0][0].ToString() == textBoxContrasenaActual.Text))
            {
                resultado = false;
                errorProvider.SetError(textBoxContrasenaActual, "La contraseña es incorrecta");
            }
            if (!textBoxContrasenaNueva.Text.Equals(textBoxConfirmarContrasena.Text))
            {
                resultado = false;
                errorProvider.SetError(buttonCambiarContrasena, "Las contraseñas no coinciden");
            }
            return resultado;
        }
        public void CambiarContrasena()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            //dataGridViewCuadernos.DataSource = mysqlAccess.QuerySQL("SELECT nombre, categoria, color FROM dbproyecto.cuadernos");
            mysqlAccess.EjectSQL("UPDATE dbproyecto.usuarios SET contraseña = '" + textBoxConfirmarContrasena.Text + "' WHERE nombre_usuario = '" + LogIn.usuario.NombreUsuario + "'");
            mysqlAccess.CloseConnection();
            MessageBox.Show("Se ha cambiado la contraseña con éxito", "Listo", MessageBoxButtons.OK);
            Close();
        }
        private void textBoxContrasenaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBoxContrasenaNueva.Focus();
            }
        }

        private void textBoxContrasenaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                textBoxConfirmarContrasena.Focus();
            }
        }

        private void textBoxConfirmarContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (ValidarCampos())
                {
                    if (ValidarContrasenas())
                    {
                        CambiarContrasena();
                    }
                }
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarContrasenas())
                {
                    CambiarContrasena();
                }
            }
        }
    }
}
