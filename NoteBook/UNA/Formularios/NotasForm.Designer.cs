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
            this.buttonRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(946, 324);
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
            this.buttonEditarNota.Location = new System.Drawing.Point(1110, 324);
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
            this.dataGridViewNotas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNotas.Location = new System.Drawing.Point(27, 55);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.Size = new System.Drawing.Size(1215, 237);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentClick);
            this.dataGridViewNotas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentDoubleClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(27, 334);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(169, 36);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(1143, 22);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(99, 28);
            this.buttonRefrescar.TabIndex = 4;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 404);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.buttonEditarNota);
            this.Controls.Add(this.buttonAgregarNota);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NotasForm";
            this.Load += new System.EventHandler(this.NotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarNota;
        private System.Windows.Forms.Button buttonEditarNota;
        private System.Windows.Forms.DataGridView dataGridViewNotas;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelTituloBusquedaNota;
        private System.Windows.Forms.Label labelNotaBusquedaNota;
        private System.Windows.Forms.TextBox textBoxTituloBusquedaNota;
        private System.Windows.Forms.TextBox textBoxNotaBusquedaNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrivacidadBusquedaNotas;
        private System.Windows.Forms.ComboBox comboBoxPrivacidadNotasBusqueda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRefrescar;
    }
}