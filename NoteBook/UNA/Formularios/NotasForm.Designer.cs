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
            this.labelTituloBusquedaNota = new System.Windows.Forms.Label();
            this.labelNotaBusquedaNota = new System.Windows.Forms.Label();
            this.textBoxTituloBusquedaNota = new System.Windows.Forms.TextBox();
            this.textBoxNotaBusquedaNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrivacidadBusquedaNotas = new System.Windows.Forms.Label();
            this.comboBoxPrivacidadNotasBusqueda = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(31, 274);
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
            this.buttonEditarNota.Location = new System.Drawing.Point(229, 274);
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
            this.dataGridViewNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Location = new System.Drawing.Point(20, 45);
            this.dataGridViewNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.RowHeadersWidth = 51;
            this.dataGridViewNotas.RowTemplate.Height = 24;
            this.dataGridViewNotas.Size = new System.Drawing.Size(911, 165);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentClick);
            // 
            // labelTituloBusquedaNota
            // 
            this.labelTituloBusquedaNota.AutoSize = true;
            this.labelTituloBusquedaNota.Location = new System.Drawing.Point(438, 252);
            this.labelTituloBusquedaNota.Name = "labelTituloBusquedaNota";
            this.labelTituloBusquedaNota.Size = new System.Drawing.Size(36, 13);
            this.labelTituloBusquedaNota.TabIndex = 3;
            this.labelTituloBusquedaNota.Text = "Titulo:";
            // 
            // labelNotaBusquedaNota
            // 
            this.labelNotaBusquedaNota.AutoSize = true;
            this.labelNotaBusquedaNota.Location = new System.Drawing.Point(441, 291);
            this.labelNotaBusquedaNota.Name = "labelNotaBusquedaNota";
            this.labelNotaBusquedaNota.Size = new System.Drawing.Size(33, 13);
            this.labelNotaBusquedaNota.TabIndex = 4;
            this.labelNotaBusquedaNota.Text = "Nota:";
            // 
            // textBoxTituloBusquedaNota
            // 
            this.textBoxTituloBusquedaNota.Location = new System.Drawing.Point(480, 249);
            this.textBoxTituloBusquedaNota.Name = "textBoxTituloBusquedaNota";
            this.textBoxTituloBusquedaNota.Size = new System.Drawing.Size(100, 20);
            this.textBoxTituloBusquedaNota.TabIndex = 5;
            this.textBoxTituloBusquedaNota.TextChanged += new System.EventHandler(this.textBoxTituloBusquedaNota_TextChanged);
            // 
            // textBoxNotaBusquedaNota
            // 
            this.textBoxNotaBusquedaNota.Location = new System.Drawing.Point(480, 291);
            this.textBoxNotaBusquedaNota.Name = "textBoxNotaBusquedaNota";
            this.textBoxNotaBusquedaNota.Size = new System.Drawing.Size(332, 20);
            this.textBoxNotaBusquedaNota.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrivacidadBusquedaNotas
            // 
            this.labelPrivacidadBusquedaNotas.AutoSize = true;
            this.labelPrivacidadBusquedaNotas.Location = new System.Drawing.Point(604, 252);
            this.labelPrivacidadBusquedaNotas.Name = "labelPrivacidadBusquedaNotas";
            this.labelPrivacidadBusquedaNotas.Size = new System.Drawing.Size(60, 13);
            this.labelPrivacidadBusquedaNotas.TabIndex = 8;
            this.labelPrivacidadBusquedaNotas.Text = "Privacidad:";
            // 
            // comboBoxPrivacidadNotasBusqueda
            // 
            this.comboBoxPrivacidadNotasBusqueda.FormattingEnabled = true;
            this.comboBoxPrivacidadNotasBusqueda.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.comboBoxPrivacidadNotasBusqueda.Location = new System.Drawing.Point(670, 249);
            this.comboBoxPrivacidadNotasBusqueda.Name = "comboBoxPrivacidadNotasBusqueda";
            this.comboBoxPrivacidadNotasBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrivacidadNotasBusqueda.TabIndex = 9;
            this.comboBoxPrivacidadNotasBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrivacidadNotasBusqueda_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(819, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxPrivacidadNotasBusqueda);
            this.Controls.Add(this.labelPrivacidadBusquedaNotas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNotaBusquedaNota);
            this.Controls.Add(this.textBoxTituloBusquedaNota);
            this.Controls.Add(this.labelNotaBusquedaNota);
            this.Controls.Add(this.labelTituloBusquedaNota);
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
        private System.Windows.Forms.Label labelTituloBusquedaNota;
        private System.Windows.Forms.Label labelNotaBusquedaNota;
        private System.Windows.Forms.TextBox textBoxTituloBusquedaNota;
        private System.Windows.Forms.TextBox textBoxNotaBusquedaNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrivacidadBusquedaNotas;
        private System.Windows.Forms.ComboBox comboBoxPrivacidadNotasBusqueda;
        private System.Windows.Forms.Button button2;
    }
}