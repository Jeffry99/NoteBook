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
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

            IngresarUsuarioForm signin = new IngresarUsuarioForm();
            signin.ShowDialog();
            if(signin.DialogResult == DialogResult.OK)
            {
                signin.Close();
                Show();
                statusStripUsuario.Text = "Usuario Actual: " + signin.usuario.nombreUsuario;
            }
            
        }

        private void buttonAgregarCuaderno_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarCuadernoForm AgregarCuaderno = new AgregarCuadernoForm();
            AgregarCuaderno.Show();
        }
    }
}
