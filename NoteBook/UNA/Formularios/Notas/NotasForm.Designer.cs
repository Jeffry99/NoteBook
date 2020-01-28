namespace NoteBook.UNA.Formularios
{
    partial class NotasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAgregarNota = new System.Windows.Forms.Button();
            this.buttonEditarNota = new System.Windows.Forms.Button();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelTituloNotaBusqueda = new System.Windows.Forms.Label();
            this.textBoxTituloNotaBusqueda = new System.Windows.Forms.TextBox();
            this.notaBusqueda = new System.Windows.Forms.Button();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.labelNoNotas = new System.Windows.Forms.Label();
            this.labelNotasDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(947, 398);
            this.buttonAgregarNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregarNota.Name = "buttonAgregarNota";
            this.buttonAgregarNota.Size = new System.Drawing.Size(132, 46);
            this.buttonAgregarNota.TabIndex = 0;
            this.buttonAgregarNota.Text = "Agregar Nota";
            this.buttonAgregarNota.UseVisualStyleBackColor = true;
            this.buttonAgregarNota.Click += new System.EventHandler(this.buttonAgregarNota_Click);
            // 
            // buttonEditarNota
            // 
            this.buttonEditarNota.Location = new System.Drawing.Point(1109, 398);
            this.buttonEditarNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarNota.Name = "buttonEditarNota";
            this.buttonEditarNota.Size = new System.Drawing.Size(132, 46);
            this.buttonEditarNota.TabIndex = 1;
            this.buttonEditarNota.Text = "Editar Nota";
            this.buttonEditarNota.UseVisualStyleBackColor = true;
            this.buttonEditarNota.Click += new System.EventHandler(this.buttonEditarNota_Click);
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.AllowUserToResizeColumns = false;
            this.dataGridViewNotas.AllowUserToResizeRows = false;
            this.dataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotas.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNotas.Location = new System.Drawing.Point(26, 100);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.Size = new System.Drawing.Size(1215, 238);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentDoubleClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(26, 398);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(169, 46);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelTituloNotaBusqueda
            // 
            this.labelTituloNotaBusqueda.AutoSize = true;
            this.labelTituloNotaBusqueda.Location = new System.Drawing.Point(847, 24);
            this.labelTituloNotaBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloNotaBusqueda.Name = "labelTituloNotaBusqueda";
            this.labelTituloNotaBusqueda.Size = new System.Drawing.Size(114, 17);
            this.labelTituloNotaBusqueda.TabIndex = 5;
            this.labelTituloNotaBusqueda.Text = "Titulo de la nota:";
            // 
            // textBoxTituloNotaBusqueda
            // 
            this.textBoxTituloNotaBusqueda.Location = new System.Drawing.Point(969, 21);
            this.textBoxTituloNotaBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTituloNotaBusqueda.Name = "textBoxTituloNotaBusqueda";
            this.textBoxTituloNotaBusqueda.Size = new System.Drawing.Size(132, 22);
            this.textBoxTituloNotaBusqueda.TabIndex = 6;
            this.textBoxTituloNotaBusqueda.TextChanged += new System.EventHandler(this.textBoxTituloNotaBusqueda_TextChanged);
            // 
            // notaBusqueda
            // 
            this.notaBusqueda.Location = new System.Drawing.Point(1109, 21);
            this.notaBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.notaBusqueda.Name = "notaBusqueda";
            this.notaBusqueda.Size = new System.Drawing.Size(132, 30);
            this.notaBusqueda.TabIndex = 11;
            this.notaBusqueda.Text = "Buscar";
            this.notaBusqueda.UseVisualStyleBackColor = true;
            this.notaBusqueda.Click += new System.EventHandler(this.notaBusqueda_Click);
            // 
            // labelAgregar
            // 
            this.labelAgregar.AutoSize = true;
            this.labelAgregar.Location = new System.Drawing.Point(428, 181);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(470, 17);
            this.labelAgregar.TabIndex = 18;
            this.labelAgregar.Text = "No ha agregado notas en este cuaderno, presione el botón para agregar";
            // 
            // labelNoNotas
            // 
            this.labelNoNotas.AutoSize = true;
            this.labelNoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNotas.Location = new System.Drawing.Point(484, 140);
            this.labelNoNotas.Name = "labelNoNotas";
            this.labelNoNotas.Size = new System.Drawing.Size(349, 32);
            this.labelNoNotas.TabIndex = 17;
            this.labelNoNotas.Text = "¡No hay notas disponibles!";
            // 
            // labelNotasDisponibles
            // 
            this.labelNotasDisponibles.AutoSize = true;
            this.labelNotasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotasDisponibles.Location = new System.Drawing.Point(554, 62);
            this.labelNotasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotasDisponibles.Name = "labelNotasDisponibles";
            this.labelNotasDisponibles.Size = new System.Drawing.Size(169, 25);
            this.labelNotasDisponibles.TabIndex = 19;
            this.labelNotasDisponibles.Text = "Notas Disponibles";
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1276, 458);
            this.Controls.Add(this.labelNotasDisponibles);
            this.Controls.Add(this.labelAgregar);
            this.Controls.Add(this.labelNoNotas);
            this.Controls.Add(this.notaBusqueda);
            this.Controls.Add(this.textBoxTituloNotaBusqueda);
            this.Controls.Add(this.labelTituloNotaBusqueda);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.buttonEditarNota);
            this.Controls.Add(this.buttonAgregarNota);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NotasForm";
            this.Load += new System.EventHandler(this.NotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarNota;
        private System.Windows.Forms.Button buttonEditarNota;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelTituloBusquedaNota;
        private System.Windows.Forms.Label labelNotaBusquedaNota;
        private System.Windows.Forms.TextBox textBoxTituloBusquedaNota;
        private System.Windows.Forms.TextBox textBoxNotaBusquedaNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrivacidadBusquedaNotas;
        private System.Windows.Forms.ComboBox comboBoxPrivacidadNotasBusqueda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTituloNotaBusqueda;
        private System.Windows.Forms.TextBox textBoxTituloNotaBusqueda;
        private System.Windows.Forms.Button notaBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.Label labelAgregar;
        private System.Windows.Forms.Label labelNoNotas;
        private System.Windows.Forms.Label labelNotasDisponibles;
    }
}