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
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonFuente = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.textBoxFuente = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxColorLetra = new System.Windows.Forms.TextBox();
            this.labelColorLetra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(80, 49);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 17);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // labelPrivacidad
            // 
            this.labelPrivacidad.AutoSize = true;
            this.labelPrivacidad.Location = new System.Drawing.Point(80, 88);
            this.labelPrivacidad.Name = "labelPrivacidad";
            this.labelPrivacidad.Size = new System.Drawing.Size(78, 17);
            this.labelPrivacidad.TabIndex = 1;
            this.labelPrivacidad.Text = "Privacidad:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(80, 130);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(80, 168);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 17);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color:";
            // 
            // labelFuente
            // 
            this.labelFuente.AutoSize = true;
            this.labelFuente.Location = new System.Drawing.Point(80, 203);
            this.labelFuente.Name = "labelFuente";
            this.labelFuente.Size = new System.Drawing.Size(56, 17);
            this.labelFuente.TabIndex = 4;
            this.labelFuente.Text = "Fuente:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(195, 49);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(370, 22);
            this.textBoxTitulo.TabIndex = 6;
            this.textBoxTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitulo_KeyPress);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(195, 127);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(370, 22);
            this.textBoxCategoria.TabIndex = 7;
            this.textBoxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCategoria_KeyPress);
            // 
            // comboBoxPrivacidad
            // 
            this.comboBoxPrivacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacidad.FormattingEnabled = true;
            this.comboBoxPrivacidad.Items.AddRange(new object[] {
            "Público",
            "Privado"});
            this.comboBoxPrivacidad.Location = new System.Drawing.Point(195, 88);
            this.comboBoxPrivacidad.Name = "comboBoxPrivacidad";
            this.comboBoxPrivacidad.Size = new System.Drawing.Size(370, 24);
            this.comboBoxPrivacidad.TabIndex = 8;
            this.comboBoxPrivacidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrivacidad_SelectedIndexChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(424, 160);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(141, 32);
            this.buttonColor.TabIndex = 12;
            this.buttonColor.Text = "Seleccionar Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Enabled = false;
            this.textBoxColor.Location = new System.Drawing.Point(195, 165);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(223, 22);
            this.textBoxColor.TabIndex = 13;
            // 
            // buttonFuente
            // 
            this.buttonFuente.Location = new System.Drawing.Point(364, 203);
            this.buttonFuente.Name = "buttonFuente";
            this.buttonFuente.Size = new System.Drawing.Size(201, 56);
            this.buttonFuente.TabIndex = 14;
            this.buttonFuente.Text = "Seleccionar Fuente y Color";
            this.buttonFuente.UseVisualStyleBackColor = true;
            this.buttonFuente.Click += new System.EventHandler(this.buttonFuente_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(589, 585);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(130, 37);
            this.buttonAgregar.TabIndex = 16;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(435, 585);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(130, 37);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(83, 288);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(636, 291);
            this.richTextBoxNota.TabIndex = 18;
            this.richTextBoxNota.Text = "";
            // 
            // textBoxFuente
            // 
            this.textBoxFuente.Enabled = false;
            this.textBoxFuente.Location = new System.Drawing.Point(195, 203);
            this.textBoxFuente.Name = "textBoxFuente";
            this.textBoxFuente.Size = new System.Drawing.Size(163, 22);
            this.textBoxFuente.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxColorLetra
            // 
            this.textBoxColorLetra.Enabled = false;
            this.textBoxColorLetra.Location = new System.Drawing.Point(195, 237);
            this.textBoxColorLetra.Name = "textBoxColorLetra";
            this.textBoxColorLetra.Size = new System.Drawing.Size(163, 22);
            this.textBoxColorLetra.TabIndex = 20;
            // 
            // labelColorLetra
            // 
            this.labelColorLetra.AutoSize = true;
            this.labelColorLetra.Location = new System.Drawing.Point(80, 240);
            this.labelColorLetra.Name = "labelColorLetra";
            this.labelColorLetra.Size = new System.Drawing.Size(102, 17);
            this.labelColorLetra.TabIndex = 21;
            this.labelColorLetra.Text = "Color de Letra:";
            // 
            // AgregarNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.labelColorLetra);
            this.Controls.Add(this.textBoxColorLetra);
            this.Controls.Add(this.textBoxFuente);
            this.Controls.Add(this.richTextBoxNota);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonFuente);
            this.Controls.Add(this.textBoxColor);
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
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Button buttonFuente;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.TextBox textBoxFuente;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelColorLetra;
        private System.Windows.Forms.TextBox textBoxColorLetra;
    }
}