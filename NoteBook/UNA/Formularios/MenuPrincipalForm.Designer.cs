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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalForm));
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
            this.labelNotaBusqueda = new System.Windows.Forms.Label();
            this.labelColorBusqueda = new System.Windows.Forms.Label();
            this.textBoxNombreCuadernoBusqueda = new System.Windows.Forms.TextBox();
            this.textBoxNotaBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxColorBusqueda = new System.Windows.Forms.ComboBox();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(865, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripUsuario
            // 
            this.statusStripUsuario.Name = "statusStripUsuario";
            this.statusStripUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(865, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.historialToolStripMenuItem.Text = "Ver historial de cambios";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click_1);
            // 
            // buttonAgregarCuaderno
            // 
            this.buttonAgregarCuaderno.Location = new System.Drawing.Point(11, 394);
            this.buttonAgregarCuaderno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAgregarCuaderno.Name = "buttonAgregarCuaderno";
            this.buttonAgregarCuaderno.Size = new System.Drawing.Size(139, 38);
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
            this.dataGridViewCuadernos.Location = new System.Drawing.Point(65, 61);
            this.dataGridViewCuadernos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCuadernos.Name = "dataGridViewCuadernos";
            this.dataGridViewCuadernos.RowHeadersWidth = 51;
            this.dataGridViewCuadernos.RowTemplate.Height = 24;
            this.dataGridViewCuadernos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuadernos.Size = new System.Drawing.Size(736, 166);
            this.dataGridViewCuadernos.TabIndex = 3;
            this.dataGridViewCuadernos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentClick);
            this.dataGridViewCuadernos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuadernos Disponibles";
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Location = new System.Drawing.Point(779, 28);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(75, 29);
            this.buttonRefrescar.TabIndex = 5;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = true;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // labelNombreCuadernoBusqueda
            // 
            this.labelNombreCuadernoBusqueda.AutoSize = true;
            this.labelNombreCuadernoBusqueda.Location = new System.Drawing.Point(62, 277);
            this.labelNombreCuadernoBusqueda.Name = "labelNombreCuadernoBusqueda";
            this.labelNombreCuadernoBusqueda.Size = new System.Drawing.Size(112, 13);
            this.labelNombreCuadernoBusqueda.TabIndex = 6;
            this.labelNombreCuadernoBusqueda.Text = "Nombre del cuaderno:";
            // 
            // labelNotaBusqueda
            // 
            this.labelNotaBusqueda.AutoSize = true;
            this.labelNotaBusqueda.Location = new System.Drawing.Point(349, 277);
            this.labelNotaBusqueda.Name = "labelNotaBusqueda";
            this.labelNotaBusqueda.Size = new System.Drawing.Size(33, 13);
            this.labelNotaBusqueda.TabIndex = 7;
            this.labelNotaBusqueda.Text = "Nota:";
            // 
            // labelColorBusqueda
            // 
            this.labelColorBusqueda.AutoSize = true;
            this.labelColorBusqueda.Location = new System.Drawing.Point(583, 277);
            this.labelColorBusqueda.Name = "labelColorBusqueda";
            this.labelColorBusqueda.Size = new System.Drawing.Size(34, 13);
            this.labelColorBusqueda.TabIndex = 8;
            this.labelColorBusqueda.Text = "Color:";
            // 
            // textBoxNombreCuadernoBusqueda
            // 
            this.textBoxNombreCuadernoBusqueda.Location = new System.Drawing.Point(181, 269);
            this.textBoxNombreCuadernoBusqueda.Name = "textBoxNombreCuadernoBusqueda";
            this.textBoxNombreCuadernoBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCuadernoBusqueda.TabIndex = 9;
            this.textBoxNombreCuadernoBusqueda.TextChanged += new System.EventHandler(this.textBoxNombreCuadernoBusqueda_TextChanged);
            // 
            // textBoxNotaBusqueda
            // 
            this.textBoxNotaBusqueda.Location = new System.Drawing.Point(388, 269);
            this.textBoxNotaBusqueda.Name = "textBoxNotaBusqueda";
            this.textBoxNotaBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textBoxNotaBusqueda.TabIndex = 10;
            // 
            // comboBoxColorBusqueda
            // 
            this.comboBoxColorBusqueda.FormattingEnabled = true;
            this.comboBoxColorBusqueda.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Negro",
            "Rojo",
            "Verde"});
            this.comboBoxColorBusqueda.Location = new System.Drawing.Point(634, 268);
            this.comboBoxColorBusqueda.Name = "comboBoxColorBusqueda";
            this.comboBoxColorBusqueda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColorBusqueda.TabIndex = 11;
            this.comboBoxColorBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorBusqueda_SelectedIndexChanged);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 470);
            this.Controls.Add(this.comboBoxColorBusqueda);
            this.Controls.Add(this.textBoxNotaBusqueda);
            this.Controls.Add(this.textBoxNombreCuadernoBusqueda);
            this.Controls.Add(this.labelColorBusqueda);
            this.Controls.Add(this.labelNotaBusqueda);
            this.Controls.Add(this.labelNombreCuadernoBusqueda);
            this.Controls.Add(this.buttonRefrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCuadernos);
            this.Controls.Add(this.buttonAgregarCuaderno);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.Button buttonAgregarCuaderno;
        private System.Windows.Forms.DataGridView dataGridViewCuadernos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.Label labelNombreCuadernoBusqueda;
        private System.Windows.Forms.Label labelNotaBusqueda;
        private System.Windows.Forms.Label labelColorBusqueda;
        private System.Windows.Forms.TextBox textBoxNombreCuadernoBusqueda;
        private System.Windows.Forms.TextBox textBoxNotaBusqueda;
        private System.Windows.Forms.ComboBox comboBoxColorBusqueda;
    }
}