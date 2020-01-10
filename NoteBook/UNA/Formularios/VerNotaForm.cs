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
    public partial class VerNotaForm : Form
    {
        public Nota Nota
        {
            get;
            set;
        }
        public VerNotaForm()
        {
            InitializeComponent();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VerNotaForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Nota.Titulo);
            this.Text = Nota.Titulo;
            richTextBoxNota.Text = Nota.Texto;
        }

        private void buttonListo_Click(object sender, EventArgs e)
        {

        }
    }
}
