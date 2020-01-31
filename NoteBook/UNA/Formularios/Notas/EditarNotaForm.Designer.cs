namespace NoteBook.UNA.Formularios.Notas
{
    partial class EditarNotaForm
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
            this.pictureBoxColorLetra = new System.Windows.Forms.PictureBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.labelColorLetra = new System.Windows.Forms.Label();
            this.textBoxFuente = new System.Windows.Forms.TextBox();
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonListo = new System.Windows.Forms.Button();
            this.buttonFuente = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.comboBoxPrivacidad = new System.Windows.Forms.ComboBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelFuente = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPrivacidad = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxColorLetra
            // 
            this.pictureBoxColorLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorLetra.Location = new System.Drawing.Point(529, 132);
            this.pictureBoxColorLetra.Name = "pictureBoxColorLetra";
            this.pictureBoxColorLetra.Size = new System.Drawing.Size(85, 26);
            this.pictureBoxColorLetra.TabIndex = 40;
            this.pictureBoxColorLetra.TabStop = false;
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(492, 43);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(78, 24);
            this.pictureBoxColor.TabIndex = 39;
            this.pictureBoxColor.TabStop = false;
            // 
            // labelColorLetra
            // 
            this.labelColorLetra.AutoSize = true;
            this.labelColorLetra.Location = new System.Drawing.Point(423, 138);
            this.labelColorLetra.Name = "labelColorLetra";
            this.labelColorLetra.Size = new System.Drawing.Size(102, 17);
            this.labelColorLetra.TabIndex = 38;
            this.labelColorLetra.Text = "Color de Letra:";
            // 
            // textBoxFuente
            // 
            this.textBoxFuente.Enabled = false;
            this.textBoxFuente.Location = new System.Drawing.Point(492, 102);
            this.textBoxFuente.Name = "textBoxFuente";
            this.textBoxFuente.Size = new System.Drawing.Size(122, 22);
            this.textBoxFuente.TabIndex = 37;
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(48, 203);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(729, 338);
            this.richTextBoxNota.TabIndex = 33;
            this.richTextBoxNota.Text = "";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::NoteBook.Properties.Resources.back_button;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(492, 560);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 37);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "  Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonListo
            // 
            this.buttonListo.Image = global::NoteBook.Properties.Resources.diskette;
            this.buttonListo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonListo.Location = new System.Drawing.Point(647, 560);
            this.buttonListo.Name = "buttonListo";
            this.buttonListo.Size = new System.Drawing.Size(130, 37);
            this.buttonListo.TabIndex = 5;
            this.buttonListo.Text = "Guardar";
            this.buttonListo.UseVisualStyleBackColor = true;
            this.buttonListo.Click += new System.EventHandler(this.buttonListo_Click);
            // 
            // buttonFuente
            // 
            this.buttonFuente.Location = new System.Drawing.Point(620, 102);
            this.buttonFuente.Name = "buttonFuente";
            this.buttonFuente.Size = new System.Drawing.Size(157, 56);
            this.buttonFuente.TabIndex = 4;
            this.buttonFuente.Text = "Seleccionar Fuente y Color";
            this.buttonFuente.UseVisualStyleBackColor = true;
            this.buttonFuente.Click += new System.EventHandler(this.buttonFuente_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(576, 38);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(201, 32);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Seleccionar Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // comboBoxPrivacidad
            // 
            this.comboBoxPrivacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacidad.FormattingEnabled = true;
            this.comboBoxPrivacidad.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.comboBoxPrivacidad.Location = new System.Drawing.Point(130, 85);
            this.comboBoxPrivacidad.Name = "comboBoxPrivacidad";
            this.comboBoxPrivacidad.Size = new System.Drawing.Size(201, 24);
            this.comboBoxPrivacidad.TabIndex = 1;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(130, 135);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(201, 22);
            this.textBoxCategoria.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(130, 43);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(201, 22);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // labelFuente
            // 
            this.labelFuente.AutoSize = true;
            this.labelFuente.Location = new System.Drawing.Point(423, 102);
            this.labelFuente.Name = "labelFuente";
            this.labelFuente.Size = new System.Drawing.Size(56, 17);
            this.labelFuente.TabIndex = 31;
            this.labelFuente.Text = "Fuente:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(423, 48);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 17);
            this.labelColor.TabIndex = 29;
            this.labelColor.Text = "Color:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(45, 138);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 27;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelPrivacidad
            // 
            this.labelPrivacidad.AutoSize = true;
            this.labelPrivacidad.Location = new System.Drawing.Point(45, 92);
            this.labelPrivacidad.Name = "labelPrivacidad";
            this.labelPrivacidad.Size = new System.Drawing.Size(78, 17);
            this.labelPrivacidad.TabIndex = 26;
            this.labelPrivacidad.Text = "Privacidad:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(45, 46);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 17);
            this.labelTitulo.TabIndex = 24;
            this.labelTitulo.Text = "Título:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(823, 616);
            this.Controls.Add(this.pictureBoxColorLetra);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.labelColorLetra);
            this.Controls.Add(this.textBoxFuente);
            this.Controls.Add(this.richTextBoxNota);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonListo);
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
            this.Name = "EditarNotaForm";
            this.Text = "Editar Nota";
            this.Load += new System.EventHandler(this.EditarNotaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxColorLetra;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Label labelColorLetra;
        private System.Windows.Forms.TextBox textBoxFuente;
        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonListo;
        private System.Windows.Forms.Button buttonFuente;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ComboBox comboBoxPrivacidad;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelFuente;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPrivacidad;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}