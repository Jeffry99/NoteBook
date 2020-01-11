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
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAgregarCuaderno = new System.Windows.Forms.Button();
            this.dataGridViewCuadernos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.labelNombreCuadernoBusqueda = new System.Windows.Forms.Label();
            this.labelColorBusqueda = new System.Windows.Forms.Label();
            this.textBoxNombreCuadernoBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuadernos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1371, 22);
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1371, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.historialToolStripMenuItem.Text = "Ver historial de cambios";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click_1);
            // 
            // buttonAgregarCuaderno
            // 
            this.buttonAgregarCuaderno.Location = new System.Drawing.Point(34, 597);
            this.buttonAgregarCuaderno.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.dataGridViewCuadernos.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridViewCuadernos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCuadernos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuadernos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCuadernos.Location = new System.Drawing.Point(34, 129);
            this.dataGridViewCuadernos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewCuadernos.Name = "dataGridViewCuadernos";
            this.dataGridViewCuadernos.RowHeadersWidth = 51;
            this.dataGridViewCuadernos.RowTemplate.Height = 24;
            this.dataGridViewCuadernos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuadernos.Size = new System.Drawing.Size(1308, 318);
            this.dataGridViewCuadernos.TabIndex = 3;
            this.dataGridViewCuadernos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentClick);
            this.dataGridViewCuadernos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuadernos Disponibles";
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(1242, 77);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(100, 36);
            this.buttonRefrescar.TabIndex = 5;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // labelNombreCuadernoBusqueda
            // 
            this.labelNombreCuadernoBusqueda.AutoSize = true;
            this.labelNombreCuadernoBusqueda.Location = new System.Drawing.Point(538, 471);
            this.labelNombreCuadernoBusqueda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombreCuadernoBusqueda.Name = "labelNombreCuadernoBusqueda";
            this.labelNombreCuadernoBusqueda.Size = new System.Drawing.Size(149, 17);
            this.labelNombreCuadernoBusqueda.TabIndex = 6;
            this.labelNombreCuadernoBusqueda.Text = "Nombre del cuaderno:";
            // 
            // labelColorBusqueda
            // 
            this.labelColorBusqueda.AutoSize = true;
            this.labelColorBusqueda.Location = new System.Drawing.Point(883, 471);
            this.labelColorBusqueda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelColorBusqueda.Name = "labelColorBusqueda";
            this.labelColorBusqueda.Size = new System.Drawing.Size(45, 17);
            this.labelColorBusqueda.TabIndex = 8;
            this.labelColorBusqueda.Text = "Color:";
            // 
            // textBoxNombreCuadernoBusqueda
            // 
            this.textBoxNombreCuadernoBusqueda.Location = new System.Drawing.Point(688, 468);
            this.textBoxNombreCuadernoBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNombreCuadernoBusqueda.Name = "textBoxNombreCuadernoBusqueda";
            this.textBoxNombreCuadernoBusqueda.Size = new System.Drawing.Size(175, 22);
            this.textBoxNombreCuadernoBusqueda.TabIndex = 9;
            this.textBoxNombreCuadernoBusqueda.TextChanged += new System.EventHandler(this.textBoxNombreCuadernoBusqueda_TextChanged);
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Location = new System.Drawing.Point(1232, 456);
            this.buttonBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(110, 34);
            this.buttonBusqueda.TabIndex = 12;
            this.buttonBusqueda.Text = "Buscar";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(1034, 456);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(189, 34);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.Text = "Seleccionar Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(937, 460);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(89, 30);
            this.pictureBoxColor.TabIndex = 14;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.Click += new System.EventHandler(this.pictureBoxColor_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1371, 711);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonBusqueda);
            this.Controls.Add(this.textBoxNombreCuadernoBusqueda);
            this.Controls.Add(this.labelColorBusqueda);
            this.Controls.Add(this.labelNombreCuadernoBusqueda);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCuadernos);
            this.Controls.Add(this.buttonAgregarCuaderno);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MenuPrincipalForm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuadernos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripUsuario;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.Button buttonAgregarCuaderno;
        private System.Windows.Forms.DataGridView dataGridViewCuadernos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Label labelNombreCuadernoBusqueda;
        private System.Windows.Forms.Label labelColorBusqueda;
        private System.Windows.Forms.TextBox textBoxNombreCuadernoBusqueda;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.ComboBox comboBoxColorBusqueda;
    }
}