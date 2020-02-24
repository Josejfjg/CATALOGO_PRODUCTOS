namespace CATALOGO
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.Menu_Principal = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.opmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.opmFamilias = new System.Windows.Forms.ToolStripMenuItem();
            this.opmCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.opmFabricantes = new System.Windows.Forms.ToolStripMenuItem();
            this.opmMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.opmUnidadDeMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.opmImpuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.opmCasaComercial = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.tsLista_Productos = new System.Windows.Forms.ToolStripButton();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Menu_Principal.SuspendLayout();
            this.Barra.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Principal
            // 
            this.Menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.seguridadToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
            this.Menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_Principal.Name = "Menu_Principal";
            this.Menu_Principal.Size = new System.Drawing.Size(1377, 24);
            this.Menu_Principal.TabIndex = 0;
            this.Menu_Principal.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 20);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opmUsuarios});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // opmUsuarios
            // 
            this.opmUsuarios.Name = "opmUsuarios";
            this.opmUsuarios.Size = new System.Drawing.Size(119, 22);
            this.opmUsuarios.Text = "Usuarios";
            this.opmUsuarios.Click += new System.EventHandler(this.opmUsuarios_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opmProductos,
            this.opmFamilias,
            this.opmCategorias,
            this.opmFabricantes,
            this.opmMarcas,
            this.opmUnidadDeMedida,
            this.opmImpuestos,
            this.opmCasaComercial});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(67, 20);
            this.toolsMenu.Text = "&Catalogo";
            // 
            // opmProductos
            // 
            this.opmProductos.Name = "opmProductos";
            this.opmProductos.Size = new System.Drawing.Size(171, 22);
            this.opmProductos.Text = "Productos";
            this.opmProductos.Click += new System.EventHandler(this.opmProductos_Click);
            // 
            // opmFamilias
            // 
            this.opmFamilias.Name = "opmFamilias";
            this.opmFamilias.Size = new System.Drawing.Size(171, 22);
            this.opmFamilias.Text = "Familias";
            this.opmFamilias.Click += new System.EventHandler(this.opmFamilias_Click);
            // 
            // opmCategorias
            // 
            this.opmCategorias.Name = "opmCategorias";
            this.opmCategorias.Size = new System.Drawing.Size(171, 22);
            this.opmCategorias.Text = "Categorias";
            this.opmCategorias.Click += new System.EventHandler(this.opmCategorias_Click);
            // 
            // opmFabricantes
            // 
            this.opmFabricantes.Name = "opmFabricantes";
            this.opmFabricantes.Size = new System.Drawing.Size(171, 22);
            this.opmFabricantes.Text = "Fabricantes";
            this.opmFabricantes.Click += new System.EventHandler(this.opmFabricantes_Click);
            // 
            // opmMarcas
            // 
            this.opmMarcas.Name = "opmMarcas";
            this.opmMarcas.Size = new System.Drawing.Size(171, 22);
            this.opmMarcas.Text = "Marcas";
            this.opmMarcas.Click += new System.EventHandler(this.opmMarcas_Click);
            // 
            // opmUnidadDeMedida
            // 
            this.opmUnidadDeMedida.Name = "opmUnidadDeMedida";
            this.opmUnidadDeMedida.Size = new System.Drawing.Size(171, 22);
            this.opmUnidadDeMedida.Text = "Unidad de Medida";
            this.opmUnidadDeMedida.Click += new System.EventHandler(this.opmUnidadDeMedida_Click);
            // 
            // opmImpuestos
            // 
            this.opmImpuestos.Name = "opmImpuestos";
            this.opmImpuestos.Size = new System.Drawing.Size(171, 22);
            this.opmImpuestos.Text = "Impuestos";
            this.opmImpuestos.Click += new System.EventHandler(this.opmImpuestos_Click);
            // 
            // opmCasaComercial
            // 
            this.opmCasaComercial.Name = "opmCasaComercial";
            this.opmCasaComercial.Size = new System.Drawing.Size(171, 22);
            this.opmCasaComercial.Text = "Casa Comercial";
            this.opmCasaComercial.Click += new System.EventHandler(this.opmCasaComercial_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            this.helpMenu.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // Barra
            // 
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLista_Productos});
            this.Barra.Location = new System.Drawing.Point(0, 24);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(1377, 25);
            this.Barra.TabIndex = 1;
            this.Barra.Text = "ToolStrip";
            // 
            // tsLista_Productos
            // 
            this.tsLista_Productos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLista_Productos.Image = ((System.Drawing.Image)(resources.GetObject("tsLista_Productos.Image")));
            this.tsLista_Productos.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsLista_Productos.Name = "tsLista_Productos";
            this.tsLista_Productos.Size = new System.Drawing.Size(23, 22);
            this.tsLista_Productos.Text = "Productos";
            this.tsLista_Productos.Click += new System.EventHandler(this.tsLista_Productos_Click);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolEstado});
            this.BarraEstado.Location = new System.Drawing.Point(0, 549);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(1377, 22);
            this.BarraEstado.TabIndex = 2;
            this.BarraEstado.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // toolEstado
            // 
            this.toolEstado.Name = "toolEstado";
            this.toolEstado.Size = new System.Drawing.Size(42, 17);
            this.toolEstado.Text = "Estado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CATALOGO.Properties.Resources.BM_Principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1377, 571);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Menu_Principal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu_Principal;
            this.Name = "frmPrincipal";
            this.Text = "BM Catalogo Unico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_Principal.ResumeLayout(false);
            this.Menu_Principal.PerformLayout();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip Menu_Principal;
        private System.Windows.Forms.ToolStrip Barra;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolEstado;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem opmProductos;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton tsLista_Productos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem opmCategorias;
        private System.Windows.Forms.ToolStripMenuItem opmFabricantes;
        private System.Windows.Forms.ToolStripMenuItem opmFamilias;
        private System.Windows.Forms.ToolStripMenuItem opmMarcas;
        private System.Windows.Forms.ToolStripMenuItem opmUnidadDeMedida;
        private System.Windows.Forms.ToolStripMenuItem opmImpuestos;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem opmCasaComercial;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}



