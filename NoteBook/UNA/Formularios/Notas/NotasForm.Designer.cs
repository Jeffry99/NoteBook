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
            this.buttonEditarNota = new System.Windows.Forms.Button();
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.labelTituloNotaBusqueda = new System.Windows.Forms.Label();
            this.textBoxTituloNotaBusqueda = new System.Windows.Forms.TextBox();
            this.notaBusqueda = new System.Windows.Forms.Button();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.labelNoNotas = new System.Windows.Forms.Label();
            this.labelNotasDisponibles = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonAgregarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditarNota
            // 
            this.buttonEditarNota.Image = global::NoteBook.Properties.Resources.write;
            this.buttonEditarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditarNota.Location = new System.Drawing.Point(1157, 472);
            this.buttonEditarNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarNota.Name = "buttonEditarNota";
            this.buttonEditarNota.Size = new System.Drawing.Size(92, 46);
            this.buttonEditarNota.TabIndex = 1;
            this.buttonEditarNota.Text = "Editar";
            this.buttonEditarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarNota.UseVisualStyleBackColor = true;
            this.buttonEditarNota.Click += new System.EventHandler(this.buttonEditarNota_Click);
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.AllowUserToResizeColumns = false;
            this.dataGridViewNotas.AllowUserToResizeRows = false;
            this.dataGridViewNotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotas.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNotas.Location = new System.Drawing.Point(26, 100);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotas.Size = new System.Drawing.Size(1323, 323);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentDoubleClick);
            // 
            // labelTituloNotaBusqueda
            // 
            this.labelTituloNotaBusqueda.AutoSize = true;
            this.labelTituloNotaBusqueda.Location = new System.Drawing.Point(968, 59);
            this.labelTituloNotaBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloNotaBusqueda.Name = "labelTituloNotaBusqueda";
            this.labelTituloNotaBusqueda.Size = new System.Drawing.Size(114, 17);
            this.labelTituloNotaBusqueda.TabIndex = 5;
            this.labelTituloNotaBusqueda.Text = "Titulo de la nota:";
            // 
            // textBoxTituloNotaBusqueda
            // 
            this.textBoxTituloNotaBusqueda.Location = new System.Drawing.Point(1090, 56);
            this.textBoxTituloNotaBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTituloNotaBusqueda.Name = "textBoxTituloNotaBusqueda";
            this.textBoxTituloNotaBusqueda.Size = new System.Drawing.Size(132, 22);
            this.textBoxTituloNotaBusqueda.TabIndex = 6;
            this.textBoxTituloNotaBusqueda.TextChanged += new System.EventHandler(this.textBoxTituloNotaBusqueda_TextChanged);
            // 
            // notaBusqueda
            // 
            this.notaBusqueda.Image = global::NoteBook.Properties.Resources.searching_magnifying_glass__1_;
            this.notaBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notaBusqueda.Location = new System.Drawing.Point(1241, 47);
            this.notaBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.notaBusqueda.Name = "notaBusqueda";
            this.notaBusqueda.Size = new System.Drawing.Size(108, 40);
            this.notaBusqueda.TabIndex = 11;
            this.notaBusqueda.Text = "Buscar";
            this.notaBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notaBusqueda.UseVisualStyleBackColor = true;
            this.notaBusqueda.Click += new System.EventHandler(this.notaBusqueda_Click);
            // 
            // labelAgregar
            // 
            this.labelAgregar.AutoSize = true;
            this.labelAgregar.Location = new System.Drawing.Point(481, 193);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(470, 17);
            this.labelAgregar.TabIndex = 18;
            this.labelAgregar.Text = "No ha agregado notas en este cuaderno, presione el botón para agregar";
            // 
            // labelNoNotas
            // 
            this.labelNoNotas.AutoSize = true;
            this.labelNoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNotas.Location = new System.Drawing.Point(549, 149);
            this.labelNoNotas.Name = "labelNoNotas";
            this.labelNoNotas.Size = new System.Drawing.Size(349, 32);
            this.labelNoNotas.TabIndex = 17;
            this.labelNoNotas.Text = "¡No hay notas disponibles!";
            // 
            // labelNotasDisponibles
            // 
            this.labelNotasDisponibles.AutoSize = true;
            this.labelNotasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotasDisponibles.Location = new System.Drawing.Point(635, 60);
            this.labelNotasDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotasDisponibles.Name = "labelNotasDisponibles";
            this.labelNotasDisponibles.Size = new System.Drawing.Size(169, 25);
            this.labelNotasDisponibles.TabIndex = 19;
            this.labelNotasDisponibles.Text = "Notas Disponibles";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::NoteBook.Properties.Resources.rubbish_bin;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.Location = new System.Drawing.Point(1255, 472);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 46);
            this.buttonEliminar.TabIndex = 20;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Image = global::NoteBook.Properties.Resources.back_button;
            this.buttonVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVolver.Location = new System.Drawing.Point(26, 472);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(125, 46);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Image = global::NoteBook.Properties.Resources.notebook__3_;
            this.buttonAgregarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarNota.Location = new System.Drawing.Point(640, 472);
            this.buttonAgregarNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregarNota.Name = "buttonAgregarNota";
            this.buttonAgregarNota.Size = new System.Drawing.Size(132, 46);
            this.buttonAgregarNota.TabIndex = 0;
            this.buttonAgregarNota.Text = " Agregar Nota";
            this.buttonAgregarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarNota.UseVisualStyleBackColor = true;
            this.buttonAgregarNota.Click += new System.EventHandler(this.buttonAgregarNota_Click);
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1382, 573);
            this.Controls.Add(this.buttonEliminar);
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
        private System.Windows.Forms.Button buttonEliminar;
    }
}