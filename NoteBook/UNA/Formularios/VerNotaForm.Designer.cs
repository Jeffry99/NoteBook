namespace NoteBook.UNA.Formularios
{
    partial class VerNotaForm
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
            this.richTextBoxNota = new System.Windows.Forms.RichTextBox();
            this.buttonListo = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxNota
            // 
            this.richTextBoxNota.Location = new System.Drawing.Point(76, 79);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(793, 367);
            this.richTextBoxNota.TabIndex = 0;
            this.richTextBoxNota.Text = "";
            // 
            // buttonListo
            // 
            this.buttonListo.Location = new System.Drawing.Point(768, 471);
            this.buttonListo.Name = "buttonListo";
            this.buttonListo.Size = new System.Drawing.Size(101, 33);
            this.buttonListo.TabIndex = 1;
            this.buttonListo.Text = "Listo";
            this.buttonListo.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(636, 471);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(101, 33);
            this.buttonVolver.TabIndex = 2;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // VerNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 537);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonListo);
            this.Controls.Add(this.richTextBoxNota);
            this.Name = "VerNotaForm";
            this.Load += new System.EventHandler(this.VerNotaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNota;
        private System.Windows.Forms.Button buttonListo;
        private System.Windows.Forms.Button buttonVolver;
    }
}