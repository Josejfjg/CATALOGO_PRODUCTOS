namespace CATALOGO.Productos
{
    partial class rptProductos_Nuevos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptProductos_Nuevos));
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Exportar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha_Fin = new System.Windows.Forms.Label();
            this.dtpFecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblFecha_Fin);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha_Fin);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha_Inicio);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgGrid);
            this.splitContainer1.Size = new System.Drawing.Size(885, 539);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fecha Inicio";
            // 
            // lblFecha_Fin
            // 
            this.lblFecha_Fin.AutoSize = true;
            this.lblFecha_Fin.Location = new System.Drawing.Point(351, 111);
            this.lblFecha_Fin.Name = "lblFecha_Fin";
            this.lblFecha_Fin.Size = new System.Drawing.Size(54, 13);
            this.lblFecha_Fin.TabIndex = 47;
            this.lblFecha_Fin.Text = "Fecha Fin";
            // 
            // dtpFecha_Fin
            // 
            this.dtpFecha_Fin.Location = new System.Drawing.Point(411, 105);
            this.dtpFecha_Fin.Name = "dtpFecha_Fin";
            this.dtpFecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Fin.TabIndex = 2;
            // 
            // dtpFecha_Inicio
            // 
            this.dtpFecha_Inicio.Location = new System.Drawing.Point(95, 105);
            this.dtpFecha_Inicio.Name = "dtpFecha_Inicio";
            this.dtpFecha_Inicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Inicio.TabIndex = 1;
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
            this.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgGrid.Location = new System.Drawing.Point(0, 0);
            this.dtgGrid.Name = "dtgGrid";
            this.dtgGrid.ReadOnly = true;
            this.dtgGrid.RowHeadersWidth = 51;
            this.dtgGrid.Size = new System.Drawing.Size(885, 390);
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
            // rptProductos_Nuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Pb_LDCOM);
            this.Controls.Add(this.Barra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "rptProductos_Nuevos";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Productos Nuevos o Modificados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLista_Productos_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLista_Productos_KeyDown);
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        internal System.Windows.Forms.ToolStripButton Bn_Exportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha_Fin;
        private System.Windows.Forms.DateTimePicker dtpFecha_Fin;
        private System.Windows.Forms.DateTimePicker dtpFecha_Inicio;
    }
}