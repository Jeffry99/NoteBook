using NoteBook.UNA.Formularios;
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

namespace NoteBook
{
    public partial class IngresarUsuarioForm : Form
    {
        public MenuPrincipalForm menuForm; 


        public IngresarUsuarioForm()
        {
            InitializeComponent();
        }

        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtBoxContrasena.Focus();
            }
        }

        private void txtBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                validarUsuario();
            }
        }

        private void validarUsuario()
        {
            if (txtBoxUsuario.TextLength == 0)
            {
                errorProviderUsuario.SetError(txtBoxUsuario, "No se ha ingresado un usuario");
            }
            if (txtBoxContrasena.TextLength == 0)
            {
                errorProviderContraseña.SetError(txtBoxContrasena, "No se ha ingresado una contraseña");
            }
            
            LogIn.Validar(txtBoxUsuario.Text, txtBoxContrasena.Text);
            if(LogIn.Validar(txtBoxUsuario.Text, txtBoxContrasena.Text) == true)
            {
                Close();
            }
            else
            {
                errorProviderError.SetError(btnAceptar, "Usuario o contraseña incorrectos");
            }

        }

        public string DevolverNomUsuario()
        {
            return txtBoxUsuario.Text;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
