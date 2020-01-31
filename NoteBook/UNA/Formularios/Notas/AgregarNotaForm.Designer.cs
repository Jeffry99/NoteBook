namespace NoteBook.UNA.Formularios
{
    partial class AgregarNotaForm
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
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPrivacidad = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelFuente = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.comboBoxPrivacidad = new System.Windows.Forms.ComboBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFuente = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.textBoxFuente = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelColorLetra = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorLetra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLetra)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(32, 49);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 17);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // labelPrivacidad
            // 
            this.labelPrivacidad.AutoSize = true;
            this.labelPrivacidad.Location = new System.Drawing.Point(32, 95);
            this.labelPrivacidad.Name = "labelPrivacidad";
            this.labelPrivacidad.Size = new System.Drawing.Size(78, 17);
            this.labelPrivacidad.TabIndex = 1;
            this.labelPrivacidad.Text = "Privacidad:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(32, 141);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(410, 51);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 17);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color:";
            // 
            // labelFuente
            // 
            this.labelFuente.AutoSize = true;
            this.labelFuente.Location = new System.Drawing.Point(410, 105);
            this.labelFuente.Name = "labelFuente";
            this.labelFuente.Size = new System.Drawing.Size(56, 17);
            this.labelFuente.TabIndex = 4;
            this.labelFuente.Text = "Fuente:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(117, 46);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(201, 22);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitulo_KeyPress);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(117, 138);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(201, 22);
            this.textBoxCategoria.TabIndex = 3;
            this.textBoxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCategoria_KeyPress);
            // 
            // comboBoxPrivacidad
            // 
            this.comboBoxPrivacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacidad.FormattingEnabled = true;
            this.comboBoxPrivacidad.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.comboBoxPrivacidad.Location = new System.Drawing.Point(117, 88);
            this.comboBoxPrivacidad.Name = "comboBoxPrivacidad";
            this.comboBoxPrivacidad.Size = new System.Drawing.Size(201, 24);
            this.comboBoxPrivacidad.TabIndex = 2;
            this.comboBoxPrivacidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrivacidad_SelectedIndexChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(563, 41);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(201, 32);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.Text = "Seleccionar Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonFuente
            // 
            this.buttonFuente.Location = new System.Drawing.Point(607, 105);
            this.buttonFuente.Name = "buttonFuente";
            this.buttonFuente.Size = new System.Drawing.Size(157, 56);
            this.buttonFuente.TabIndex = 5;
            this.buttonFuente.Text = "Seleccionar Fuente y Color";
            this.buttonFuente.UseVisualStyleBackColor = true;
            this.buttonFuente.Click += new System.EventHandler(this.buttonFuente_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(634, 563);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(130, 37);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(479, 563);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 37);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(35, 206);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(729, 338);
            this.richTextBoxNota.TabIndex = 5;
            this.richTextBoxNota.Text = "";
            // 
            // textBoxFuente
            // 
            this.textBoxFuente.Enabled = false;
            this.textBoxFuente.Location = new System.Drawing.Point(479, 102);
            this.textBoxFuente.Name = "textBoxFuente";
            this.textBoxFuente.Size = new System.Drawing.Size(122, 22);
            this.textBoxFuente.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelColorLetra
            // 
            this.labelColorLetra.AutoSize = true;
            this.labelColorLetra.Location = new System.Drawing.Point(410, 141);
            this.labelColorLetra.Name = "labelColorLetra";
            this.labelColorLetra.Size = new System.Drawing.Size(102, 17);
            this.labelColorLetra.TabIndex = 21;
            this.labelColorLetra.Text = "Color de Letra:";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(479, 46);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(78, 24);
            this.pictureBoxColor.TabIndex = 22;
            this.pictureBoxColor.TabStop = false;
            // 
            // pictureBoxColorLetra
            // 
            this.pictureBoxColorLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorLetra.Location = new System.Drawing.Point(516, 132);
            this.pictureBoxColorLetra.Name = "pictureBoxColorLetra";
            this.pictureBoxColorLetra.Size = new System.Drawing.Size(85, 26);
            this.pictureBoxColorLetra.TabIndex = 23;
            this.pictureBoxColorLetra.TabStop = false;
            // 
            // AgregarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.pictureBoxColorLetra);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.labelColorLetra);
            this.Controls.Add(this.textBoxFuente);
            this.Controls.Add(this.richTextBoxNota);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonFuente);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.comboBoxPrivacidad);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelFuente);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelPrivacidad);
            this.Controls.Add(this.labelTitulo);
            this.Name = "AgregarNotaForm";
            this.Text = "AgregarNotaForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPrivacidad;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelFuente;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxPrivacidad;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonFuente;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.TextBox textBoxFuente;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelColorLetra;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.PictureBox pictureBoxColorLetra;
    }
}