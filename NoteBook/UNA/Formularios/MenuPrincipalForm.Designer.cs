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
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAgregarCuaderno = new System.Windows.Forms.Button();
            this.dataGridViewCuadernos = new System.Windows.Forms.DataGridView();
            this.labelCuadernosDisponibles = new System.Windows.Forms.Label();
            this.labelNombreCuadernoBusqueda = new System.Windows.Forms.Label();
            this.textBoxNombreCuadernoBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.labelNoCuadernos = new System.Windows.Forms.Label();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.labelCuadernoNoEncontrado = new System.Windows.Forms.Label();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
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
            this.menuToolStripMenuItem,
            this.usuarioToolStripMenuItem});
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
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem1,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUsuarioToolStripMenuItem1
            // 
            this.agregarUsuarioToolStripMenuItem1.Name = "agregarUsuarioToolStripMenuItem1";
            this.agregarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.agregarUsuarioToolStripMenuItem1.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem1_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // buttonAgregarCuaderno
            // 
            this.buttonAgregarCuaderno.Location = new System.Drawing.Point(596, 482);
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
            this.dataGridViewCuadernos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCuadernos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuadernos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCuadernos.Location = new System.Drawing.Point(34, 138);
            this.dataGridViewCuadernos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewCuadernos.Name = "dataGridViewCuadernos";
            this.dataGridViewCuadernos.RowHeadersWidth = 51;
            this.dataGridViewCuadernos.RowTemplate.Height = 24;
            this.dataGridViewCuadernos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuadernos.Size = new System.Drawing.Size(1308, 318);
            this.dataGridViewCuadernos.TabIndex = 3;
            this.dataGridViewCuadernos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuadernos_CellContentDoubleClick);
            // 
            // labelCuadernosDisponibles
            // 
            this.labelCuadernosDisponibles.AutoSize = true;
            this.labelCuadernosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuadernosDisponibles.Location = new System.Drawing.Point(582, 95);
            this.labelCuadernosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCuadernosDisponibles.Name = "labelCuadernosDisponibles";
            this.labelCuadernosDisponibles.Size = new System.Drawing.Size(215, 25);
            this.labelCuadernosDisponibles.TabIndex = 4;
            this.labelCuadernosDisponibles.Text = "Cuadernos Disponibles";
            // 
            // labelNombreCuadernoBusqueda
            // 
            this.labelNombreCuadernoBusqueda.AutoSize = true;
            this.labelNombreCuadernoBusqueda.Location = new System.Drawing.Point(888, 68);
            this.labelNombreCuadernoBusqueda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombreCuadernoBusqueda.Name = "labelNombreCuadernoBusqueda";
            this.labelNombreCuadernoBusqueda.Size = new System.Drawing.Size(149, 17);
            this.labelNombreCuadernoBusqueda.TabIndex = 6;
            this.labelNombreCuadernoBusqueda.Text = "Nombre del cuaderno:";
            // 
            // textBoxNombreCuadernoBusqueda
            // 
            this.textBoxNombreCuadernoBusqueda.Location = new System.Drawing.Point(1047, 65);
            this.textBoxNombreCuadernoBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNombreCuadernoBusqueda.Name = "textBoxNombreCuadernoBusqueda";
            this.textBoxNombreCuadernoBusqueda.Size = new System.Drawing.Size(175, 22);
            this.textBoxNombreCuadernoBusqueda.TabIndex = 9;
            this.textBoxNombreCuadernoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreCuadernoBusqueda_KeyPress);
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.Location = new System.Drawing.Point(1232, 65);
            this.buttonBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(110, 23);
            this.buttonBusqueda.TabIndex = 12;
            this.buttonBusqueda.Text = "Buscar";
            this.buttonBusqueda.UseVisualStyleBackColor = true;
            this.buttonBusqueda.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // labelNoCuadernos
            // 
            this.labelNoCuadernos.AutoSize = true;
            this.labelNoCuadernos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoCuadernos.Location = new System.Drawing.Point(484, 207);
            this.labelNoCuadernos.Name = "labelNoCuadernos";
            this.labelNoCuadernos.Size = new System.Drawing.Size(412, 32);
            this.labelNoCuadernos.TabIndex = 15;
            this.labelNoCuadernos.Text = "¡No hay cuadernos disponibles!";
            // 
            // labelAgregar
            // 
            this.labelAgregar.AutoSize = true;
            this.labelAgregar.Location = new System.Drawing.Point(440, 251);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(496, 17);
            this.labelAgregar.TabIndex = 16;
            this.labelAgregar.Text = "Este usuario no ha agregado cuadernos aún, presione el botón para agregar";
            // 
            // labelCuadernoNoEncontrado
            // 
            this.labelCuadernoNoEncontrado.AutoSize = true;
            this.labelCuadernoNoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuadernoNoEncontrado.Location = new System.Drawing.Point(462, 277);
            this.labelCuadernoNoEncontrado.Name = "labelCuadernoNoEncontrado";
            this.labelCuadernoNoEncontrado.Size = new System.Drawing.Size(449, 32);
            this.labelCuadernoNoEncontrado.TabIndex = 17;
            this.labelCuadernoNoEncontrado.Text = "¡No se han encontrado cuadernos!";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1371, 571);
            this.Controls.Add(this.labelCuadernoNoEncontrado);
            this.Controls.Add(this.labelAgregar);
            this.Controls.Add(this.labelNoCuadernos);
            this.Controls.Add(this.buttonBusqueda);
            this.Controls.Add(this.textBoxNombreCuadernoBusqueda);
            this.Controls.Add(this.labelNombreCuadernoBusqueda);
            this.Controls.Add(this.labelCuadernosDisponibles);
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
        private System.Windows.Forms.Label labelCuadernosDisponibles;
        private System.Windows.Forms.Label labelNombreCuadernoBusqueda;
        private System.Windows.Forms.TextBox textBoxNombreCuadernoBusqueda;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.ComboBox comboBoxColorBusqueda;
        private System.Windows.Forms.Label labelNoCuadernos;
        private System.Windows.Forms.Label labelAgregar;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.Label labelCuadernoNoEncontrado;
    }
}