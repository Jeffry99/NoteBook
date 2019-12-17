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
        public IngresarUsuarioForm()
        {
            InitializeComponent();
        }

        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtBoxContraseña.Focus();
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
            if(txtBoxUsuario.TextLength < 1)
            {
                errorProviderUsuario.SetError(txtBoxUsuario, "No se ha ingresado un usuario");
            }
            if(txtBoxContraseña.TextLength < 1)
            {
                errorProviderContraseña.SetError(txtBoxContraseña, "No se ha ingresado una contraseña");
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IngresarUsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
