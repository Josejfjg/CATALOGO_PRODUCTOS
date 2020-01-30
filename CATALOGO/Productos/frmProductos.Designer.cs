﻿namespace CATALOGO.Productos
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.tapMain = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.txtContenido = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnidad_Medida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSucursales = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkSuc_Todas = new System.Windows.Forms.CheckBox();
            this.txtSuc_Sugerido = new System.Windows.Forms.NumericUpDown();
            this.txtSuc_Utilidad = new System.Windows.Forms.NumericUpDown();
            this.txtSuc_Descuento = new System.Windows.Forms.NumericUpDown();
            this.txtSuc_Costo = new System.Windows.Forms.NumericUpDown();
            this.chkSuc_Estado = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSuc_Sucursal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSuc_Producto_Id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.tapImpuestos = new System.Windows.Forms.TabPage();
            this.dtgGrid_Impuestos = new System.Windows.Forms.DataGridView();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Agregar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHablador = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbCasa_Comercial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).BeginInit();
            this.tapMain.SuspendLayout();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContenido)).BeginInit();
            this.tabSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Sugerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Utilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            this.tapImpuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid_Impuestos)).BeginInit();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_LDCOM
            // 
            this.Pb_LDCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_LDCOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_LDCOM.Image = global::CATALOGO.Properties.Resources.BM_Principal;
            this.Pb_LDCOM.Location = new System.Drawing.Point(6, 669);
            this.Pb_LDCOM.Name = "Pb_LDCOM";
            this.Pb_LDCOM.Size = new System.Drawing.Size(121, 61);
            this.Pb_LDCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_LDCOM.TabIndex = 42;
            this.Pb_LDCOM.TabStop = false;
            // 
            // tapMain
            // 
            this.tapMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tapMain.Controls.Add(this.tabProducto);
            this.tapMain.Controls.Add(this.tabSucursales);
            this.tapMain.Controls.Add(this.tapImpuestos);
            this.tapMain.Location = new System.Drawing.Point(-1, 62);
            this.tapMain.Name = "tapMain";
            this.tapMain.SelectedIndex = 0;
            this.tapMain.Size = new System.Drawing.Size(961, 595);
            this.tapMain.TabIndex = 43;
            this.tapMain.SelectedIndexChanged += new System.EventHandler(this.tapMain_SelectedIndexChanged);
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.label18);
            this.tabProducto.Controls.Add(this.cmbCasa_Comercial);
            this.tabProducto.Controls.Add(this.txtHablador);
            this.tabProducto.Controls.Add(this.label17);
            this.tabProducto.Controls.Add(this.txtContenido);
            this.tabProducto.Controls.Add(this.label12);
            this.tabProducto.Controls.Add(this.cmbFamilia);
            this.tabProducto.Controls.Add(this.chkEstado);
            this.tabProducto.Controls.Add(this.label9);
            this.tabProducto.Controls.Add(this.txtDescripcion);
            this.tabProducto.Controls.Add(this.label6);
            this.tabProducto.Controls.Add(this.label7);
            this.tabProducto.Controls.Add(this.cmbSubCategoria);
            this.tabProducto.Controls.Add(this.label8);
            this.tabProducto.Controls.Add(this.cmbCategoria);
            this.tabProducto.Controls.Add(this.label5);
            this.tabProducto.Controls.Add(this.cmbUnidad_Medida);
            this.tabProducto.Controls.Add(this.label4);
            this.tabProducto.Controls.Add(this.cmbMarca);
            this.tabProducto.Controls.Add(this.label3);
            this.tabProducto.Controls.Add(this.cmbFabricante);
            this.tabProducto.Controls.Add(this.txtNombre);
            this.tabProducto.Controls.Add(this.label2);
            this.tabProducto.Controls.Add(this.txtCodigo);
            this.tabProducto.Controls.Add(this.label1);
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(953, 569);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Producto :";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(138, 313);
            this.txtContenido.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(274, 20);
            this.txtContenido.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(576, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Familias :";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(632, 39);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(274, 21);
            this.cmbFamilia.TabIndex = 10;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(570, 258);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Contenido";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(138, 113);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(274, 64);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SubCategoria :";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(632, 110);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(274, 21);
            this.cmbSubCategoria.TabIndex = 7;
            this.cmbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(632, 74);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(274, 21);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad Medida :";
            // 
            // cmbUnidad_Medida
            // 
            this.cmbUnidad_Medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad_Medida.FormattingEnabled = true;
            this.cmbUnidad_Medida.Location = new System.Drawing.Point(138, 276);
            this.cmbUnidad_Medida.Name = "cmbUnidad_Medida";
            this.cmbUnidad_Medida.Size = new System.Drawing.Size(274, 21);
            this.cmbUnidad_Medida.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Marca :";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(632, 218);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(274, 21);
            this.cmbMarca.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fabricante :";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(632, 179);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(274, 21);
            this.cmbFabricante.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 77);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 41);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(274, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo de Barras :";
            // 
            // tabSucursales
            // 
            this.tabSucursales.Controls.Add(this.splitContainer1);
            this.tabSucursales.Location = new System.Drawing.Point(4, 22);
            this.tabSucursales.Name = "tabSucursales";
            this.tabSucursales.Padding = new System.Windows.Forms.Padding(3);
            this.tabSucursales.Size = new System.Drawing.Size(953, 569);
            this.tabSucursales.TabIndex = 1;
            this.tabSucursales.Text = "Sucursal";
            this.tabSucursales.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkSuc_Todas);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuc_Sugerido);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuc_Utilidad);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuc_Descuento);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuc_Costo);
            this.splitContainer1.Panel1.Controls.Add(this.chkSuc_Estado);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSuc_Sucursal);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.txtSuc_Producto_Id);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgGrid);
            this.splitContainer1.Size = new System.Drawing.Size(947, 563);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 7;
            // 
            // chkSuc_Todas
            // 
            this.chkSuc_Todas.AutoSize = true;
            this.chkSuc_Todas.Location = new System.Drawing.Point(427, 49);
            this.chkSuc_Todas.Name = "chkSuc_Todas";
            this.chkSuc_Todas.Size = new System.Drawing.Size(56, 17);
            this.chkSuc_Todas.TabIndex = 22;
            this.chkSuc_Todas.Text = "Todas";
            this.chkSuc_Todas.UseVisualStyleBackColor = true;
            this.chkSuc_Todas.CheckedChanged += new System.EventHandler(this.chkSuc_Todas_CheckedChanged);
            // 
            // txtSuc_Sugerido
            // 
            this.txtSuc_Sugerido.Location = new System.Drawing.Point(566, 50);
            this.txtSuc_Sugerido.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSuc_Sugerido.Name = "txtSuc_Sugerido";
            this.txtSuc_Sugerido.Size = new System.Drawing.Size(360, 20);
            this.txtSuc_Sugerido.TabIndex = 21;
            // 
            // txtSuc_Utilidad
            // 
            this.txtSuc_Utilidad.Location = new System.Drawing.Point(566, 13);
            this.txtSuc_Utilidad.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSuc_Utilidad.Name = "txtSuc_Utilidad";
            this.txtSuc_Utilidad.Size = new System.Drawing.Size(360, 20);
            this.txtSuc_Utilidad.TabIndex = 20;
            // 
            // txtSuc_Descuento
            // 
            this.txtSuc_Descuento.Location = new System.Drawing.Point(81, 122);
            this.txtSuc_Descuento.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSuc_Descuento.Name = "txtSuc_Descuento";
            this.txtSuc_Descuento.Size = new System.Drawing.Size(340, 20);
            this.txtSuc_Descuento.TabIndex = 19;
            // 
            // txtSuc_Costo
            // 
            this.txtSuc_Costo.Location = new System.Drawing.Point(81, 86);
            this.txtSuc_Costo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtSuc_Costo.Name = "txtSuc_Costo";
            this.txtSuc_Costo.Size = new System.Drawing.Size(340, 20);
            this.txtSuc_Costo.TabIndex = 18;
            // 
            // chkSuc_Estado
            // 
            this.chkSuc_Estado.AutoSize = true;
            this.chkSuc_Estado.Checked = true;
            this.chkSuc_Estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuc_Estado.Location = new System.Drawing.Point(576, 87);
            this.chkSuc_Estado.Name = "chkSuc_Estado";
            this.chkSuc_Estado.Size = new System.Drawing.Size(56, 17);
            this.chkSuc_Estado.TabIndex = 17;
            this.chkSuc_Estado.Text = "Activo";
            this.chkSuc_Estado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(506, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Sugerido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(506, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Utilidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Descuento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Costo";
            // 
            // cmbSuc_Sucursal
            // 
            this.cmbSuc_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuc_Sucursal.FormattingEnabled = true;
            this.cmbSuc_Sucursal.Location = new System.Drawing.Point(81, 47);
            this.cmbSuc_Sucursal.Name = "cmbSuc_Sucursal";
            this.cmbSuc_Sucursal.Size = new System.Drawing.Size(340, 21);
            this.cmbSuc_Sucursal.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Codigo";
            // 
            // txtSuc_Producto_Id
            // 
            this.txtSuc_Producto_Id.Enabled = false;
            this.txtSuc_Producto_Id.Location = new System.Drawing.Point(81, 12);
            this.txtSuc_Producto_Id.Name = "txtSuc_Producto_Id";
            this.txtSuc_Producto_Id.Size = new System.Drawing.Size(340, 20);
            this.txtSuc_Producto_Id.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sucursal";
            // 
            // dtgGrid
            // 
            this.dtgGrid.AllowUserToAddRows = false;
            this.dtgGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGrid.Location = new System.Drawing.Point(0, 0);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgGrid.Size = new System.Drawing.Size(947, 411);
            this.dtgGrid.TabIndex = 0;
            // 
            // tapImpuestos
            // 
            this.tapImpuestos.Controls.Add(this.dtgGrid_Impuestos);
            this.tapImpuestos.Location = new System.Drawing.Point(4, 22);
            this.tapImpuestos.Name = "tapImpuestos";
            this.tapImpuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tapImpuestos.Size = new System.Drawing.Size(953, 569);
            this.tapImpuestos.TabIndex = 2;
            this.tapImpuestos.Text = "Impuestos";
            this.tapImpuestos.UseVisualStyleBackColor = true;
            // 
            // dtgGrid_Impuestos
            // 
            this.dtgGrid_Impuestos.AllowUserToAddRows = false;
            this.dtgGrid_Impuestos.AllowUserToDeleteRows = false;
            this.dtgGrid_Impuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrid_Impuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGrid_Impuestos.Location = new System.Drawing.Point(3, 3);
            this.dtgGrid_Impuestos.MultiSelect = false;
            this.dtgGrid_Impuestos.Name = "dtgGrid_Impuestos";
            this.dtgGrid_Impuestos.Size = new System.Drawing.Size(947, 563);
            this.dtgGrid_Impuestos.TabIndex = 0;
            this.dtgGrid_Impuestos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgGrid_Impuestos_CellMouseUp);
            // 
            // Barra
            // 
            this.Barra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Barra.AutoSize = false;
            this.Barra.BackColor = System.Drawing.Color.Transparent;
            this.Barra.Dock = System.Windows.Forms.DockStyle.None;
            this.Barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bn_Guardar,
            this.Bn_Agregar,
            this.Bn_Modificar,
            this.Bn_Eliminar,
            this.Bn_Salir});
            this.Barra.Location = new System.Drawing.Point(635, 675);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(361, 60);
            this.Barra.TabIndex = 44;
            this.Barra.Text = "ToolStrip1";
            // 
            // Bn_Guardar
            // 
            this.Bn_Guardar.AutoSize = false;
            this.Bn_Guardar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Guardar.Image = global::CATALOGO.Properties.Resources.F1;
            this.Bn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Guardar.Name = "Bn_Guardar";
            this.Bn_Guardar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Guardar.Text = "Guardar";
            this.Bn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Guardar.ToolTipText = "Guardar";
            this.Bn_Guardar.Click += new System.EventHandler(this.Bn_Guardar_Click);
            // 
            // Bn_Agregar
            // 
            this.Bn_Agregar.AutoSize = false;
            this.Bn_Agregar.Enabled = false;
            this.Bn_Agregar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Agregar.Image = global::CATALOGO.Properties.Resources.F2;
            this.Bn_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Agregar.Name = "Bn_Agregar";
            this.Bn_Agregar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Agregar.Text = "Agregar";
            this.Bn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Agregar.ToolTipText = "Agregar";
            this.Bn_Agregar.Click += new System.EventHandler(this.Bn_Agregar_Click);
            // 
            // Bn_Modificar
            // 
            this.Bn_Modificar.AutoSize = false;
            this.Bn_Modificar.Enabled = false;
            this.Bn_Modificar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Modificar.Image = global::CATALOGO.Properties.Resources.F3;
            this.Bn_Modificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Modificar.Name = "Bn_Modificar";
            this.Bn_Modificar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Modificar.Text = "Modificar";
            this.Bn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Modificar.ToolTipText = "Eliminar";
            this.Bn_Modificar.Click += new System.EventHandler(this.Bn_Modificar_Click);
            // 
            // Bn_Eliminar
            // 
            this.Bn_Eliminar.AutoSize = false;
            this.Bn_Eliminar.Enabled = false;
            this.Bn_Eliminar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Eliminar.Image = global::CATALOGO.Properties.Resources.F4;
            this.Bn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Eliminar.Name = "Bn_Eliminar";
            this.Bn_Eliminar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Eliminar.Text = "Eliminar";
            this.Bn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Eliminar.ToolTipText = "Eliminar";
            this.Bn_Eliminar.Click += new System.EventHandler(this.Bn_Eliminar_Click);
            // 
            // Bn_Salir
            // 
            this.Bn_Salir.AutoSize = false;
            this.Bn_Salir.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Salir.Image = global::CATALOGO.Properties.Resources.ESCred;
            this.Bn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Salir.Name = "Bn_Salir";
            this.Bn_Salir.Size = new System.Drawing.Size(57, 51);
            this.Bn_Salir.Text = "Salir";
            this.Bn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Salir.Click += new System.EventHandler(this.Bn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CATALOGO.Properties.Resources.BM_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // txtHablador
            // 
            this.txtHablador.Location = new System.Drawing.Point(138, 194);
            this.txtHablador.MaxLength = 150;
            this.txtHablador.Multiline = true;
            this.txtHablador.Name = "txtHablador";
            this.txtHablador.Size = new System.Drawing.Size(274, 64);
            this.txtHablador.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Halbador  :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(540, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Casa Comercial :";
            // 
            // cmbCasa_Comercial
            // 
            this.cmbCasa_Comercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasa_Comercial.FormattingEnabled = true;
            this.cmbCasa_Comercial.Location = new System.Drawing.Point(632, 146);
            this.cmbCasa_Comercial.Name = "cmbCasa_Comercial";
            this.cmbCasa_Comercial.Size = new System.Drawing.Size(274, 21);
            this.cmbCasa_Comercial.TabIndex = 8;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.tapMain);
            this.Controls.Add(this.Pb_LDCOM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductos_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).EndInit();
            this.tapMain.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContenido)).EndInit();
            this.tabSucursales.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Sugerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Utilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc_Costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            this.tapImpuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid_Impuestos)).EndInit();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox Pb_LDCOM;
        private System.Windows.Forms.TabControl tapMain;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabSucursales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnidad_Medida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.DataGridView dtgGrid;
        private System.Windows.Forms.TextBox txtSuc_Producto_Id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ToolStrip Barra;
        internal System.Windows.Forms.ToolStripButton Bn_Guardar;
        internal System.Windows.Forms.ToolStripButton Bn_Salir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.NumericUpDown txtContenido;
        private System.Windows.Forms.CheckBox chkSuc_Estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSuc_Sucursal;
        private System.Windows.Forms.NumericUpDown txtSuc_Sugerido;
        private System.Windows.Forms.NumericUpDown txtSuc_Utilidad;
        private System.Windows.Forms.NumericUpDown txtSuc_Descuento;
        private System.Windows.Forms.NumericUpDown txtSuc_Costo;
        private System.Windows.Forms.TabPage tapImpuestos;
        internal System.Windows.Forms.ToolStripButton Bn_Agregar;
        internal System.Windows.Forms.ToolStripButton Bn_Eliminar;
        internal System.Windows.Forms.ToolStripButton Bn_Modificar;
        private System.Windows.Forms.DataGridView dtgGrid_Impuestos;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkSuc_Todas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbCasa_Comercial;
        private System.Windows.Forms.TextBox txtHablador;
        private System.Windows.Forms.Label label17;
    }
}