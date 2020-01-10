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
            this.labelTituloNotaBusqueda = new System.Windows.Forms.Label();
            this.textBoxTituloNotaBusqueda = new System.Windows.Forms.TextBox();
            this.labelNotaNotaBusqueda = new System.Windows.Forms.Label();
            this.textBoxNotaNotaBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivacidadNotaBusqueda = new System.Windows.Forms.ComboBox();
            this.notaBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(710, 323);
            this.buttonAgregarNota.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregarNota.Name = "buttonAgregarNota";
            this.buttonAgregarNota.Size = new System.Drawing.Size(99, 37);
            this.buttonAgregarNota.TabIndex = 0;
            this.buttonAgregarNota.Text = "Agregar Nota";
            this.buttonAgregarNota.UseVisualStyleBackColor = true;
            this.buttonAgregarNota.Click += new System.EventHandler(this.buttonAgregarNota_Click);
            // 
            // buttonEditarNota
            // 
            this.buttonEditarNota.Location = new System.Drawing.Point(832, 323);
            this.buttonEditarNota.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarNota.Name = "buttonEditarNota";
            this.buttonEditarNota.Size = new System.Drawing.Size(99, 37);
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
            this.dataGridViewNotas.Location = new System.Drawing.Point(20, 45);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.Size = new System.Drawing.Size(911, 193);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentDoubleClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(20, 331);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(127, 29);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(857, 18);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(74, 23);
            this.buttonRefrescar.TabIndex = 4;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // labelTituloNotaBusqueda
            // 
            this.labelTituloNotaBusqueda.AutoSize = true;
            this.labelTituloNotaBusqueda.Location = new System.Drawing.Point(451, 258);
            this.labelTituloNotaBusqueda.Name = "labelTituloNotaBusqueda";
            this.labelTituloNotaBusqueda.Size = new System.Drawing.Size(36, 13);
            this.labelTituloNotaBusqueda.TabIndex = 5;
            this.labelTituloNotaBusqueda.Text = "Titulo:";
            // 
            // textBoxTituloNotaBusqueda
            // 
            this.textBoxTituloNotaBusqueda.Location = new System.Drawing.Point(493, 255);
            this.textBoxTituloNotaBusqueda.Name = "textBoxTituloNotaBusqueda";
            this.textBoxTituloNotaBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textBoxTituloNotaBusqueda.TabIndex = 6;
            this.textBoxTituloNotaBusqueda.TextChanged += new System.EventHandler(this.textBoxTituloNotaBusqueda_TextChanged);
            // 
            // labelNotaNotaBusqueda
            // 
            this.labelNotaNotaBusqueda.AutoSize = true;
            this.labelNotaNotaBusqueda.Location = new System.Drawing.Point(567, 295);
            this.labelNotaNotaBusqueda.Name = "labelNotaNotaBusqueda";
            this.labelNotaNotaBusqueda.Size = new System.Drawing.Size(33, 13);
            this.labelNotaNotaBusqueda.TabIndex = 7;
            this.labelNotaNotaBusqueda.Text = "Nota:";
            // 
            // textBoxNotaNotaBusqueda
            // 
            this.textBoxNotaNotaBusqueda.Location = new System.Drawing.Point(602, 292);
            this.textBoxNotaNotaBusqueda.Name = "textBoxNotaNotaBusqueda";
            this.textBoxNotaNotaBusqueda.Size = new System.Drawing.Size(207, 20);
            this.textBoxNotaNotaBusqueda.TabIndex = 8;
            this.textBoxNotaNotaBusqueda.TextChanged += new System.EventHandler(this.textBoxNotaNotaBusqueda_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Privacidad:";
            // 
            // comboBoxPrivacidadNotaBusqueda
            // 
            this.comboBoxPrivacidadNotaBusqueda.FormattingEnabled = true;
            this.comboBoxPrivacidadNotaBusqueda.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.comboBoxPrivacidadNotaBusqueda.Location = new System.Drawing.Point(688, 255);
            this.comboBoxPrivacidadNotaBusqueda.Name = "comboBoxPrivacidadNotaBusqueda";
            this.comboBoxPrivacidadNotaBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrivacidadNotaBusqueda.TabIndex = 10;
            this.comboBoxPrivacidadNotaBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrivacidadNotaBusqueda_SelectedIndexChanged);
            // 
            // notaBusqueda
            // 
            this.notaBusqueda.Location = new System.Drawing.Point(832, 255);
            this.notaBusqueda.Name = "notaBusqueda";
            this.notaBusqueda.Size = new System.Drawing.Size(99, 23);
            this.notaBusqueda.TabIndex = 11;
            this.notaBusqueda.Text = "Buscar";
            this.notaBusqueda.UseVisualStyleBackColor = true;
            this.notaBusqueda.Click += new System.EventHandler(this.notaBusqueda_Click);
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 372);
            this.Controls.Add(this.notaBusqueda);
            this.Controls.Add(this.comboBoxPrivacidadNotaBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotaNotaBusqueda);
            this.Controls.Add(this.labelNotaNotaBusqueda);
            this.Controls.Add(this.textBoxTituloNotaBusqueda);
            this.Controls.Add(this.labelTituloNotaBusqueda);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.buttonEditarNota);
            this.Controls.Add(this.buttonAgregarNota);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotasForm";
            this.Load += new System.EventHandler(this.NotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelTituloNotaBusqueda;
        private System.Windows.Forms.TextBox textBoxTituloNotaBusqueda;
        private System.Windows.Forms.Label labelNotaNotaBusqueda;
        private System.Windows.Forms.TextBox textBoxNotaNotaBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrivacidadNotaBusqueda;
        private System.Windows.Forms.Button notaBusqueda;
    }
}