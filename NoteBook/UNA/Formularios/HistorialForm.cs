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
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }
        private void HistorialForm_Load(object sender, EventArgs e)
        {
            dataGridViewHistorial.DataSource = RegistroAcciones.Load();
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
