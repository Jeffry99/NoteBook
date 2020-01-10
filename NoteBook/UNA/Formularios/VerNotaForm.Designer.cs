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
            this.richTextBoxNota.Location = new System.Drawing.Point(57, 64);
            this.richTextBoxNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxNota.Name = "richTextBoxNota";
            this.richTextBoxNota.Size = new System.Drawing.Size(596, 299);
            this.richTextBoxNota.TabIndex = 0;
            this.richTextBoxNota.Text = "";
            // 
            // buttonListo
            // 
            this.buttonListo.Location = new System.Drawing.Point(576, 383);
            this.buttonListo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListo.Name = "buttonListo";
            this.buttonListo.Size = new System.Drawing.Size(76, 27);
            this.buttonListo.TabIndex = 1;
            this.buttonListo.Text = "Listo";
            this.buttonListo.UseVisualStyleBackColor = true;
            this.buttonListo.Click += new System.EventHandler(this.buttonListo_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(477, 383);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(76, 27);
            this.buttonVolver.TabIndex = 2;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // VerNotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 436);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonListo);
            this.Controls.Add(this.richTextBoxNota);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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