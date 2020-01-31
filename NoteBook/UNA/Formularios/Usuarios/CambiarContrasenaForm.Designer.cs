namespace NoteBook.UNA.Formularios.Usuario
{
    partial class CambiarContrasenaForm
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
            this.labelContrasenaActual = new System.Windows.Forms.Label();
            this.labelContrasenaNueva = new System.Windows.Forms.Label();
            this.labelConfirmarContrasena = new System.Windows.Forms.Label();
            this.textBoxContrasenaActual = new System.Windows.Forms.TextBox();
            this.textBoxContrasenaNueva = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.buttonCambiarContrasena = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContrasenaActual
            // 
            this.labelContrasenaActual.AutoSize = true;
            this.labelContrasenaActual.Location = new System.Drawing.Point(112, 87);
            this.labelContrasenaActual.Name = "labelContrasenaActual";
            this.labelContrasenaActual.Size = new System.Drawing.Size(128, 17);
            this.labelContrasenaActual.TabIndex = 0;
            this.labelContrasenaActual.Text = "Contraseña Actual:";
            // 
            // labelContrasenaNueva
            // 
            this.labelContrasenaNueva.AutoSize = true;
            this.labelContrasenaNueva.Location = new System.Drawing.Point(112, 160);
            this.labelContrasenaNueva.Name = "labelContrasenaNueva";
            this.labelContrasenaNueva.Size = new System.Drawing.Size(130, 17);
            this.labelContrasenaNueva.TabIndex = 1;
            this.labelContrasenaNueva.Text = "Contraseña Nueva:";
            // 
            // labelConfirmarContrasena
            // 
            this.labelConfirmarContrasena.AutoSize = true;
            this.labelConfirmarContrasena.Location = new System.Drawing.Point(112, 230);
            this.labelConfirmarContrasena.Name = "labelConfirmarContrasena";
            this.labelConfirmarContrasena.Size = new System.Drawing.Size(150, 17);
            this.labelConfirmarContrasena.TabIndex = 2;
            this.labelConfirmarContrasena.Text = "Confirmar Contraseña:";
            // 
            // textBoxContrasenaActual
            // 
            this.textBoxContrasenaActual.Location = new System.Drawing.Point(275, 87);
            this.textBoxContrasenaActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrasenaActual.Name = "textBoxContrasenaActual";
            this.textBoxContrasenaActual.Size = new System.Drawing.Size(257, 22);
            this.textBoxContrasenaActual.TabIndex = 3;
            this.textBoxContrasenaActual.UseSystemPasswordChar = true;
            this.textBoxContrasenaActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContrasenaActual_KeyPress);
            // 
            // textBoxContrasenaNueva
            // 
            this.textBoxContrasenaNueva.Location = new System.Drawing.Point(275, 160);
            this.textBoxContrasenaNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrasenaNueva.Name = "textBoxContrasenaNueva";
            this.textBoxContrasenaNueva.Size = new System.Drawing.Size(257, 22);
            this.textBoxContrasenaNueva.TabIndex = 4;
            this.textBoxContrasenaNueva.UseSystemPasswordChar = true;
            this.textBoxContrasenaNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContrasenaNueva_KeyPress);
            // 
            // textBoxConfirmarContrasena
            // 
            this.textBoxConfirmarContrasena.Location = new System.Drawing.Point(275, 230);
            this.textBoxConfirmarContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmarContrasena.Name = "textBoxConfirmarContrasena";
            this.textBoxConfirmarContrasena.Size = new System.Drawing.Size(257, 22);
            this.textBoxConfirmarContrasena.TabIndex = 5;
            this.textBoxConfirmarContrasena.UseSystemPasswordChar = true;
            this.textBoxConfirmarContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmarContrasena_KeyPress);
            // 
            // buttonCambiarContrasena
            // 
            this.buttonCambiarContrasena.Image = global::NoteBook.Properties.Resources.diskette;
            this.buttonCambiarContrasena.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCambiarContrasena.Location = new System.Drawing.Point(516, 327);
            this.buttonCambiarContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCambiarContrasena.Name = "buttonCambiarContrasena";
            this.buttonCambiarContrasena.Size = new System.Drawing.Size(127, 33);
            this.buttonCambiarContrasena.TabIndex = 6;
            this.buttonCambiarContrasena.Text = "Guardar";
            this.buttonCambiarContrasena.UseVisualStyleBackColor = true;
            this.buttonCambiarContrasena.Click += new System.EventHandler(this.buttonCambiarContrasena_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancelar.Image = global::NoteBook.Properties.Resources.back_button;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(383, 327);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(127, 33);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CambiarContrasenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(675, 386);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCambiarContrasena);
            this.Controls.Add(this.textBoxConfirmarContrasena);
            this.Controls.Add(this.textBoxContrasenaNueva);
            this.Controls.Add(this.textBoxContrasenaActual);
            this.Controls.Add(this.labelConfirmarContrasena);
            this.Controls.Add(this.labelContrasenaNueva);
            this.Controls.Add(this.labelContrasenaActual);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CambiarContrasenaForm";
            this.Text = "Cambiar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContrasenaActual;
        private System.Windows.Forms.Label labelContrasenaNueva;
        private System.Windows.Forms.Label labelConfirmarContrasena;
        private System.Windows.Forms.TextBox textBoxContrasenaActual;
        private System.Windows.Forms.TextBox textBoxContrasenaNueva;
        private System.Windows.Forms.TextBox textBoxConfirmarContrasena;
        private System.Windows.Forms.Button buttonCambiarContrasena;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}