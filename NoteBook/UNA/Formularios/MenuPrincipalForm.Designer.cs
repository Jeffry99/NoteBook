namespace NoteBook.UNA.Formularios
{
    partial class MenuPrincipalForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luisPutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAgregarCuaderno = new System.Windows.Forms.Button();
            this.dataGridViewCuadernos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuadernos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripUsuario
            // 
            this.statusStripUsuario.Name = "statusStripUsuario";
            this.statusStripUsuario.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luisPutoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // luisPutoToolStripMenuItem
            // 
            this.luisPutoToolStripMenuItem.Name = "luisPutoToolStripMenuItem";
            this.luisPutoToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.luisPutoToolStripMenuItem.Text = "Luis Puto";
            // 
            // buttonAgregarCuaderno
            // 
            this.buttonAgregarCuaderno.Location = new System.Drawing.Point(230, 351);
            this.buttonAgregarCuaderno.Name = "buttonAgregarCuaderno";
            this.buttonAgregarCuaderno.Size = new System.Drawing.Size(185, 47);
            this.buttonAgregarCuaderno.TabIndex = 2;
            this.buttonAgregarCuaderno.Text = "Agregar Cuaderno";
            this.buttonAgregarCuaderno.UseVisualStyleBackColor = true;
            this.buttonAgregarCuaderno.Click += new System.EventHandler(this.buttonAgregarCuaderno_Click);
            // 
            // dataGridViewCuadernos
            // 
            this.dataGridViewCuadernos.AllowUserToAddRows = false;
            this.dataGridViewCuadernos.AllowUserToDeleteRows = false;
            this.dataGridViewCuadernos.AllowUserToResizeColumns = false;
            this.dataGridViewCuadernos.AllowUserToResizeRows = false;
            this.dataGridViewCuadernos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCuadernos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuadernos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewCuadernos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCuadernos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCuadernos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuadernos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCuadernos.Location = new System.Drawing.Point(1, 75);
            this.dataGridViewCuadernos.Name = "dataGridViewCuadernos";
            this.dataGridViewCuadernos.RowHeadersWidth = 51;
            this.dataGridViewCuadernos.RowTemplate.Height = 24;
            this.dataGridViewCuadernos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuadernos.Size = new System.Drawing.Size(981, 204);
            this.dataGridViewCuadernos.TabIndex = 3;
            this.dataGridViewCuadernos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentClick);
            this.dataGridViewCuadernos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuadernos Disponibles";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCuadernos);
            this.Controls.Add(this.buttonAgregarCuaderno);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipalForm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuadernos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripUsuario;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luisPutoToolStripMenuItem;
        private System.Windows.Forms.Button buttonAgregarCuaderno;
        private System.Windows.Forms.DataGridView dataGridViewCuadernos;
        private System.Windows.Forms.Label label1;
    }
}