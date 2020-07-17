namespace CATALOGO.Productos
{
    partial class rptProductos_X_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptProductos_X_Proveedor));
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Exportar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbSuc_Sucursal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkTodas_SubCategorias = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha_Fin = new System.Windows.Forms.Label();
            this.dtpFecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Barra.AutoSize = false;
            this.Barra.BackColor = System.Drawing.Color.Transparent;
            this.Barra.Dock = System.Windows.Forms.DockStyle.None;
            this.Barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Barra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bn_Buscar,
            this.Bn_Exportar,
            this.Bn_Salir});
            this.Barra.Location = new System.Drawing.Point(706, 550);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(195, 60);
            this.Barra.TabIndex = 41;
            this.Barra.Text = "ToolStrip1";
            // 
            // Bn_Buscar
            // 
            this.Bn_Buscar.AutoSize = false;
            this.Bn_Buscar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Buscar.Image = global::CATALOGO.Properties.Resources.F1;
            this.Bn_Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Buscar.Name = "Bn_Buscar";
            this.Bn_Buscar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Buscar.Text = "Buscar";
            this.Bn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Buscar.Click += new System.EventHandler(this.Bn_Buscar_Click);
            // 
            // Bn_Exportar
            // 
            this.Bn_Exportar.AutoSize = false;
            this.Bn_Exportar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Bn_Exportar.Image = global::CATALOGO.Properties.Resources.F2;
            this.Bn_Exportar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Bn_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bn_Exportar.Name = "Bn_Exportar";
            this.Bn_Exportar.Size = new System.Drawing.Size(57, 51);
            this.Bn_Exportar.Text = "Exportar";
            this.Bn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bn_Exportar.Click += new System.EventHandler(this.Bn_Exportar_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkTodas_SubCategorias);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSuc_Sucursal);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSubCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.panelFechas);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFamilia);
            this.splitContainer1.Panel1.Controls.Add(this.chkFechas);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgGrid);
            this.splitContainer1.Size = new System.Drawing.Size(885, 539);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 43;
            // 
            // cmbSuc_Sucursal
            // 
            this.cmbSuc_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuc_Sucursal.FormattingEnabled = true;
            this.cmbSuc_Sucursal.Location = new System.Drawing.Point(137, 99);
            this.cmbSuc_Sucursal.Name = "cmbSuc_Sucursal";
            this.cmbSuc_Sucursal.Size = new System.Drawing.Size(331, 21);
            this.cmbSuc_Sucursal.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Sucursal :";
            // 
            // chkTodas_SubCategorias
            // 
            this.chkTodas_SubCategorias.AutoSize = true;
            this.chkTodas_SubCategorias.Location = new System.Drawing.Point(720, 129);
            this.chkTodas_SubCategorias.Name = "chkTodas_SubCategorias";
            this.chkTodas_SubCategorias.Size = new System.Drawing.Size(143, 17);
            this.chkTodas_SubCategorias.TabIndex = 51;
            this.chkTodas_SubCategorias.Text = "Todas las subcategorías";
            this.chkTodas_SubCategorias.UseVisualStyleBackColor = true;
            this.chkTodas_SubCategorias.CheckedChanged += new System.EventHandler(this.chkTodas_SubCategorias_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "SubCategoria :";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(575, 127);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(139, 21);
            this.cmbSubCategoria.TabIndex = 49;
            this.cmbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(343, 126);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(139, 21);
            this.cmbCategoria.TabIndex = 47;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Familias :";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(137, 126);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(139, 21);
            this.cmbFamilia.TabIndex = 45;
            this.cmbFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFamilia_SelectedIndexChanged);
            // 
            // panelFechas
            // 
            this.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFechas.Controls.Add(this.label1);
            this.panelFechas.Controls.Add(this.lblFecha_Fin);
            this.panelFechas.Controls.Add(this.dtpFecha_Fin);
            this.panelFechas.Controls.Add(this.dtpFecha_Inicio);
            this.panelFechas.Location = new System.Drawing.Point(158, 171);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(722, 31);
            this.panelFechas.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Fecha Inicio :";
            // 
            // lblFecha_Fin
            // 
            this.lblFecha_Fin.AutoSize = true;
            this.lblFecha_Fin.Location = new System.Drawing.Point(333, 9);
            this.lblFecha_Fin.Name = "lblFecha_Fin";
            this.lblFecha_Fin.Size = new System.Drawing.Size(60, 13);
            this.lblFecha_Fin.TabIndex = 54;
            this.lblFecha_Fin.Text = "Fecha Fin :";
            // 
            // dtpFecha_Fin
            // 
            this.dtpFecha_Fin.Location = new System.Drawing.Point(416, 5);
            this.dtpFecha_Fin.Name = "dtpFecha_Fin";
            this.dtpFecha_Fin.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha_Fin.TabIndex = 53;
            // 
            // dtpFecha_Inicio
            // 
            this.dtpFecha_Inicio.Location = new System.Drawing.Point(94, 5);
            this.dtpFecha_Inicio.Name = "dtpFecha_Inicio";
            this.dtpFecha_Inicio.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha_Inicio.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Activar Filtro";
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(137, 180);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(15, 14);
            this.chkFechas.TabIndex = 57;
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CATALOGO.Properties.Resources.BM_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // dtgGrid
            // 
            this.dtgGrid.AllowUserToAddRows = false;
            this.dtgGrid.AllowUserToDeleteRows = false;
            this.dtgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGrid.Location = new System.Drawing.Point(0, 0);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            this.dtgGrid.RowHeadersWidth = 51;
            this.dtgGrid.Size = new System.Drawing.Size(885, 321);
            this.dtgGrid.TabIndex = 0;
            // 
            // Pb_LDCOM
            // 
            this.Pb_LDCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_LDCOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_LDCOM.Image = global::CATALOGO.Properties.Resources.BM_Principal;
            this.Pb_LDCOM.Location = new System.Drawing.Point(6, 549);
            this.Pb_LDCOM.Name = "Pb_LDCOM";
            this.Pb_LDCOM.Size = new System.Drawing.Size(121, 61);
            this.Pb_LDCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_LDCOM.TabIndex = 42;
            this.Pb_LDCOM.TabStop = false;
            // 
            // rptProductos_X_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Pb_LDCOM);
            this.Controls.Add(this.Barra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "rptProductos_X_Proveedor";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Productos por Categoría";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLista_Productos_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLista_Productos_KeyDown);
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip Barra;
        internal System.Windows.Forms.ToolStripButton Bn_Salir;
        internal System.Windows.Forms.PictureBox Pb_LDCOM;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.ToolStripButton Bn_Buscar;
        private System.Windows.Forms.DataGridView dtgGrid;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.CheckBox chkTodas_SubCategorias;
        internal System.Windows.Forms.ToolStripButton Bn_Exportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha_Fin;
        private System.Windows.Forms.DateTimePicker dtpFecha_Fin;
        private System.Windows.Forms.DateTimePicker dtpFecha_Inicio;
        private System.Windows.Forms.Panel panelFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.ComboBox cmbSuc_Sucursal;
        private System.Windows.Forms.Label label11;
    }
}