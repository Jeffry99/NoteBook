using DatabaseAccess.UNA;
using Newtonsoft.Json;
using NoteBook.UNA.Formularios.Notas;
using NoteBook.UNA.Helpers;
using NoteBook.UNA.Miscelaneo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook.UNA.Formularios
{
    public partial class NotasForm : Form
    {

        public static List<Cuaderno> cuadernos;
        public Cuaderno cuaderno = new Cuaderno();
        public NotasForm(string nombreCuaderno)
        {
            cuaderno.Nombre = nombreCuaderno;
            InitializeComponent();
            
        }

        private void buttonAgregarNota_Click(object sender, EventArgs e)
        {
            Hide();
            AgregarNotaForm agregarNota = new AgregarNotaForm(cuaderno.Nombre);
            agregarNota.Text = "Agregar Nota en: " + agregarNota.CuadernoActual.Nombre;
            agregarNota.ShowDialog();
            
            CargarDataGrid();
            ValidarDataGrid();
            Show();
        }


        private void NotasForm_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            ValidarDataGrid();
        }

        public Cuaderno EncontrarCuadernoActual()
        {
            Cuaderno cuaderno = new Cuaderno();
            
            return cuaderno;
        }
        public void CargarDataGrid()
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewNotas.DataSource = mysqlAccess.QuerySQL("SELECT titulo, privacidad, categoria, color, fecha_creacion, fecha_modificacion FROM dbproyecto.notas WHERE idCuadernos ='" + EncontrarIdCuaderno() + "'");
            mysqlAccess.CloseConnection();
        }
        private void buttonEditarNota_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewNotas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                string tituloNota = dataGridViewNotas.SelectedRows[0].Cells[0].Value.ToString();
                EditarNotaForm editarNota = new EditarNotaForm(cuaderno.Nombre);
                editarNota.Nota.Titulo = tituloNota;
                editarNota.ShowDialog();
                Show();

                CargarDataGrid();
                ValidarDataGrid();
            }
            
        }
        public int EncontrarIdCuaderno()
        {
            int idUsuario = 0;
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            DataTable data = mysqlAccess.QuerySQL("SELECT idCuadernos FROM dbproyecto.cuadernos WHERE nombre = '" + cuaderno.Nombre + "'");
            idUsuario = Convert.ToInt32(data.Rows[0][0].ToString());
            mysqlAccess.CloseConnection();
            return idUsuario;
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewNotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerNotaForm notaForm = new VerNotaForm();
            Nota nota = new Nota();
            foreach (DataGridViewRow c in dataGridViewNotas.SelectedRows)
            {
                nota = (Nota)c.DataBoundItem;
                Console.WriteLine(nota.Titulo);
            }
            notaForm.richTextBoxNota.Text = dataGridViewNotas.CurrentCell.Value.ToString();
            Hide();
            notaForm.ShowDialog();
            Show();
        }
        private void textBoxTituloNotaBusqueda_TextChanged(object sender, EventArgs e)
        {
        }
        private void notaBusqueda_Click(object sender, EventArgs e)
        {
            MysqlAccess mysqlAccess = new MysqlAccess();
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridViewNotas.DataSource = mysqlAccess.QuerySQL("SELECT titulo, privacidad, categoria, color, fecha_creacion, fecha_modificacion FROM dbproyecto.notas WHERE titulo LIKE '%"
                + textBoxTituloNotaBusqueda.Text + "%' AND idCuadernos = '" + EncontrarIdCuaderno() + "'");
            mysqlAccess.CloseConnection();
            if (dataGridViewNotas.Rows.Count == 0)
            {
                dataGridViewNotas.Visible = false;
                labelNoNotas.Visible = true;
                labelAgregar.Visible = true;
            }
            else
            {
                dataGridViewNotas.Visible = true;
                labelNoNotas.Visible = false;
                labelAgregar.Visible = false;
            }
        }
        public void ValidarDataGrid()
        {
            if (dataGridViewNotas.Rows.Count == 0)
            {
                dataGridViewNotas.Visible = false;
                labelNotasDisponibles.Visible = false;
                labelAgregar.Visible = true;
                labelNoNotas.Visible = true;
            }
            else
            {
                dataGridViewNotas.Visible = true;
                labelNotasDisponibles.Visible = true;
                labelAgregar.Visible = false;
                labelNoNotas.Visible = false;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewNotas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tituloNota = dataGridViewNotas.SelectedRows[0].Cells[0].Value.ToString();
                MysqlAccess mysqlAccess = new MysqlAccess();
                mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
                mysqlAccess.OpenConnection();
                DataTable data = mysqlAccess.QuerySQL("SELECT idNotas FROM dbproyecto.notas WHERE titulo = '" + tituloNota + "'");
                int idNota = Convert.ToInt32(data.Rows[0][0].ToString());
                if (MessageBox.Show("¿Desea eliminar la nota seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mysqlAccess.EjectSQL("DELETE FROM dbproyecto.notas WHERE idNotas = '" + idNota + "'");
                    Accion accion = new Accion(LogIn.usuario.NombreUsuario, "Se ha eliminado una nota", "Nota", "Nota: " + tituloNota);
                    RegistroAcciones.Save(accion);
                }
                mysqlAccess.CloseConnection();
                CargarDataGrid();
                ValidarDataGrid();
            }
            
        }
    }
}
