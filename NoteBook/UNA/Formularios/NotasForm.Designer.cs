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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregarNota
            // 
            this.buttonAgregarNota.Location = new System.Drawing.Point(722, 347);
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
            this.buttonEditarNota.Location = new System.Drawing.Point(722, 279);
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
            this.dataGridViewNotas.Size = new System.Drawing.Size(1013, 203);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(121, 364);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(127, 29);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            this.dataGridViewNotas.Size = new System.Drawing.Size(911, 165);
            this.dataGridViewNotas.TabIndex = 2;
            this.dataGridViewNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotas_CellContentClick);
            // 
            // labelTituloBusquedaNota
            // 
            // 
            // labelNotaBusquedaNota
            // 
            // 
            // textBoxTituloBusquedaNota
            // 
            // 
            // textBoxNotaBusquedaNota
            // 
            // 
            // button1
            // 
            
            // 
            // NotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 454);
            this.Controls.Add(this.buttonVolver);
            this.ClientSize = new System.Drawing.Size(957, 369);
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
    }
}