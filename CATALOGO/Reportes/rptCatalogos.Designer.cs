namespace CATALOGO
{
    partial class rptCatalogos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgGrid = new System.Windows.Forms.DataGridView();
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.Bn_Buscar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Exportar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).BeginInit();
            this.Barra.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgGrid);
            this.splitContainer1.Size = new System.Drawing.Size(979, 555);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CATALOGO.Properties.Resources.BM_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 88);
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
            this.dtgGrid.Size = new System.Drawing.Size(979, 440);
            this.dtgGrid.TabIndex = 0;
            // 
            // Pb_LDCOM
            // 
            this.Pb_LDCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pb_LDCOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_LDCOM.Image = global::CATALOGO.Properties.Resources.BM_Principal;
            this.Pb_LDCOM.Location = new System.Drawing.Point(6, 575);
            this.Pb_LDCOM.Name = "Pb_LDCOM";
            this.Pb_LDCOM.Size = new System.Drawing.Size(121, 61);
            this.Pb_LDCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_LDCOM.TabIndex = 42;
            this.Pb_LDCOM.TabStop = false;
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
            // Barra
            // 
            this.Barra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Barra.AutoSize = false;
            this.Barra.BackColor = System.Drawing.Color.Transparent;
            this.Barra.Dock = System.Windows.Forms.DockStyle.None;
            this.Barra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bn_Buscar,
            this.Bn_Exportar,
            this.Bn_Salir});
            this.Barra.Location = new System.Drawing.Point(803, 576);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(192, 60);
            this.Barra.TabIndex = 41;
            this.Barra.Text = "ToolStrip1";
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
            // rptCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Pb_LDCOM);
            this.Controls.Add(this.Barra);
            this.KeyPreview = true;
            this.Name = "rptCatalogos";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Categorías";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLista_Categorias_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLista_Categorias_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).EndInit();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox Pb_LDCOM;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgGrid;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ToolStripButton Bn_Buscar;
        internal System.Windows.Forms.ToolStripButton Bn_Salir;
        internal System.Windows.Forms.ToolStrip Barra;
        internal System.Windows.Forms.ToolStripButton Bn_Exportar;
    }
}