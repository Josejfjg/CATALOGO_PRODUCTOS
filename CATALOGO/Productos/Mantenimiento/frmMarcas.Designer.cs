namespace CATALOGO
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.Pb_LDCOM = new System.Windows.Forms.PictureBox();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.Bn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.Bn_Salir = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).BeginInit();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Bn_Salir});
            this.Barra.Location = new System.Drawing.Point(665, 410);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(153, 60);
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(169, 208);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(550, 64);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Descripcion :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 161);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(550, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(169, 115);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(550, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Codigo :";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(169, 296);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 4;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 476);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Pb_LDCOM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMarcas_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMarcas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_LDCOM)).EndInit();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox Pb_LDCOM;
        internal System.Windows.Forms.ToolStrip Barra;
        internal System.Windows.Forms.ToolStripButton Bn_Guardar;
        internal System.Windows.Forms.ToolStripButton Bn_Salir;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEstado;
    }
}