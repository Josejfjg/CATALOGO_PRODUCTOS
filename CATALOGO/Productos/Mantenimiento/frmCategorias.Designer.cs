namespace CATALOGO
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Agregar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabSubCategorias = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSubC_Categoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSubC_Estado = new System.Windows.Forms.CheckBox();
            this.txtSubC_Descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubC_Nombre = new System.Windows.Forms.TextBox();
            this.txtSubC_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tapMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).BeginInit();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSubCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            this.tabCategoria.SuspendLayout();
            this.tapMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb_LDCOM
            // 
            this.Pb_LDCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_LDCOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_LDCOM.Image = global::CATALOGO.Properties.Resources.BM_Principal;
            this.Pb_LDCOM.Location = new System.Drawing.Point(6, 409);
            this.Pb_LDCOM.Name = "Pb_LDCOM";
            this.Pb_LDCOM.Size = new System.Drawing.Size(121, 61);
            this.Pb_LDCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_LDCOM.TabIndex = 42;
            this.Pb_LDCOM.TabStop = false;
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
            this.Barra.Location = new System.Drawing.Point(479, 406);
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
            this.pictureBox1.Size = new System.Drawing.Size(783, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // tabSubCategorias
            // 
            this.tabSubCategorias.Controls.Add(this.splitContainer1);
            this.tabSubCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabSubCategorias.Name = "tabSubCategorias";
            this.tabSubCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubCategorias.Size = new System.Drawing.Size(776, 315);
            this.tabSubCategorias.TabIndex = 1;
            this.tabSubCategorias.Text = "SubCategorias";
            this.tabSubCategorias.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtSubC_Categoria);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.chkSubC_Estado);
            this.splitContainer1.Panel1.Controls.Add(this.txtSubC_Descripcion);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtSubC_Nombre);
            this.splitContainer1.Panel1.Controls.Add(this.txtSubC_Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgGrid);
            this.splitContainer1.Size = new System.Drawing.Size(770, 309);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 7;
            // 
            // txtSubC_Categoria
            // 
            this.txtSubC_Categoria.Enabled = false;
            this.txtSubC_Categoria.Location = new System.Drawing.Point(124, 12);
            this.txtSubC_Categoria.MaxLength = 3;
            this.txtSubC_Categoria.Name = "txtSubC_Categoria";
            this.txtSubC_Categoria.Size = new System.Drawing.Size(219, 20);
            this.txtSubC_Categoria.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Categoria  :";
            // 
            // chkSubC_Estado
            // 
            this.chkSubC_Estado.AutoSize = true;
            this.chkSubC_Estado.Checked = true;
            this.chkSubC_Estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubC_Estado.Location = new System.Drawing.Point(124, 92);
            this.chkSubC_Estado.Name = "chkSubC_Estado";
            this.chkSubC_Estado.Size = new System.Drawing.Size(56, 17);
            this.chkSubC_Estado.TabIndex = 20;
            this.chkSubC_Estado.Text = "Activo";
            this.chkSubC_Estado.UseVisualStyleBackColor = true;
            // 
            // txtSubC_Descripcion
            // 
            this.txtSubC_Descripcion.Location = new System.Drawing.Point(463, 12);
            this.txtSubC_Descripcion.MaxLength = 150;
            this.txtSubC_Descripcion.Multiline = true;
            this.txtSubC_Descripcion.Name = "txtSubC_Descripcion";
            this.txtSubC_Descripcion.Size = new System.Drawing.Size(281, 68);
            this.txtSubC_Descripcion.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descripcion :";
            // 
            // txtSubC_Nombre
            // 
            this.txtSubC_Nombre.Location = new System.Drawing.Point(124, 64);
            this.txtSubC_Nombre.MaxLength = 100;
            this.txtSubC_Nombre.Name = "txtSubC_Nombre";
            this.txtSubC_Nombre.Size = new System.Drawing.Size(219, 20);
            this.txtSubC_Nombre.TabIndex = 8;
            // 
            // txtSubC_Codigo
            // 
            this.txtSubC_Codigo.Location = new System.Drawing.Point(124, 38);
            this.txtSubC_Codigo.MaxLength = 3;
            this.txtSubC_Codigo.Name = "txtSubC_Codigo";
            this.txtSubC_Codigo.Size = new System.Drawing.Size(219, 20);
            this.txtSubC_Codigo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo  :";
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
            this.dtgGrid.Size = new System.Drawing.Size(770, 186);
            this.dtgGrid.TabIndex = 0;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.label12);
            this.tabCategoria.Controls.Add(this.cmbFamilia);
            this.tabCategoria.Controls.Add(this.chkEstado);
            this.tabCategoria.Controls.Add(this.txtDescripcion);
            this.tabCategoria.Controls.Add(this.txtNombre);
            this.tabCategoria.Controls.Add(this.txtCodigo);
            this.tabCategoria.Controls.Add(this.label6);
            this.tabCategoria.Controls.Add(this.label2);
            this.tabCategoria.Controls.Add(this.label1);
            this.tabCategoria.Location = new System.Drawing.Point(4, 22);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoria.Size = new System.Drawing.Size(776, 315);
            this.tabCategoria.TabIndex = 0;
            this.tabCategoria.Text = "Categoria :";
            this.tabCategoria.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Familias :";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(135, 19);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(529, 21);
            this.cmbFamilia.TabIndex = 26;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(135, 167);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(135, 97);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(529, 64);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 71);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(529, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(135, 45);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(529, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo  :";
            // 
            // tapMain
            // 
            this.tapMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tapMain.Controls.Add(this.tabCategoria);
            this.tapMain.Controls.Add(this.tabSubCategorias);
            this.tapMain.Location = new System.Drawing.Point(-1, 62);
            this.tapMain.Name = "tapMain";
            this.tapMain.SelectedIndex = 0;
            this.tapMain.Size = new System.Drawing.Size(784, 341);
            this.tapMain.TabIndex = 43;
            this.tapMain.SelectedIndexChanged += new System.EventHandler(this.tapMain_SelectedIndexChanged);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.tapMain);
            this.Controls.Add(this.Pb_LDCOM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategorias_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategorias_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).EndInit();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSubCategorias.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            this.tapMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox Pb_LDCOM;
        internal System.Windows.Forms.ToolStrip Barra;
        internal System.Windows.Forms.ToolStripButton Bn_Guardar;
        internal System.Windows.Forms.ToolStripButton Bn_Salir;
        internal System.Windows.Forms.ToolStripButton Bn_Agregar;
        internal System.Windows.Forms.ToolStripButton Bn_Eliminar;
        internal System.Windows.Forms.ToolStripButton Bn_Modificar;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabSubCategorias;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgGrid;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tapMain;
        private System.Windows.Forms.TextBox txtSubC_Nombre;
        private System.Windows.Forms.TextBox txtSubC_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSubC_Estado;
        private System.Windows.Forms.TextBox txtSubC_Descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubC_Categoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFamilia;
    }
}