using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmCategorias : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private const int _clmNum = 0;
        private const int _clmCodigo = 1;
        private const int _clmNombre = 2;
        private const int _clmDescripcion = 3;
        private const int _clmEstado = 4;


        private TTrastienda _Trastienda;
        private List<tbSubCategorias> _dtSubCategoria;
        private List<tbFamilias> _dtFamilias;
        private tbCategorias _Categoria = new tbCategorias();

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbCategorias pCategorias)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Categoria = pCategorias;
            _Salir = false;
            CargarCombos();
            Limpiar_Pantalla();
            CargarDatos();
          
            Configuracion_Grid();
            Cargar_SubCategoria();
            Refrescar_Grid();
            Limpiar_SubCategorias();
            this.ShowDialog();
            return _Salir;
        }

        #endregion

        #region "Eventos"
        private void Bn_Salir_Click(object sender, EventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void frmCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void tapMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabCategoria":
                    Bn_Agregar.Enabled = false;
                    Bn_Modificar.Enabled = false;
                    Bn_Eliminar.Enabled = false;
                    Bn_Guardar.Enabled = true;
                    break;
                case "tabSubCategorias":
                    Bn_Agregar.Enabled = true;
                    Bn_Modificar.Enabled = true;
                    Bn_Eliminar.Enabled = true;
                    Bn_Guardar.Enabled = false;
                    break;
            }
        }
        private void Bn_Agregar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSubCategorias":
                    Agregar_SubCategoria();
                    break;
            }
        }
        private void Bn_Eliminar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSubCategorias":
                    Eliminar_SubCategoria();
                    break;
            }
        }
        private void Bn_Modificar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSubCategorias":
                    Modificar_SubCategoria();
                    break;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtSubC_Categoria.Text = txtCodigo.Text;
        }
        private void frmCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Guardar();
                    break;
                case Keys.F2:
                    if (Bn_Agregar.Enabled == true)
                        Bn_Agregar_Click(null, null);
                    break;
                case Keys.F3:
                    if (Bn_Agregar.Enabled == true)
                        Bn_Modificar_Click(null, null);
                    break;
                case Keys.F4:
                    if (Bn_Eliminar.Enabled == true)
                        Bn_Eliminar_Click(null, null);
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }

        #endregion

        #region "Metodos Privados"
        private void Inicializa_Pantalla()
        {
            InitializeComponent();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 4;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].Width = 200;
            this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            this.dtgGrid.Columns[_clmDescripcion].Width = 300;

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Activo";
            this.dtgGrid.Columns.Add(col1);
            this.dtgGrid.Columns[_clmEstado].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;
            this.dtgGrid.Refresh();
        }
        private void Refrescar_Grid()
        {
            dtgGrid.Rows.Clear();
            try
            {
                if (_dtSubCategoria != null)
                {
                    if (_dtSubCategoria.Count > 0)
                    {
                        int j = 1;
                        foreach (tbSubCategorias _Row in _dtSubCategoria)
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.SubCategoria_Id;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado;
                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron SubCategorias", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid.Refresh();
            }
        }
        private void CargarDatos()
        {
            if (_Categoria.Categoria_Id != "")
            {
                _Modifica = true;
                cmbFamilia.Text = _Categoria.Familia_Id;
                cmbFamilia.Enabled = false;
                txtCodigo.Text = _Categoria.Categoria_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Categoria.Nombre;
                txtDescripcion.Text = _Categoria.Descripcion;
                chkEstado.Checked = _Categoria.Estado;
                tapMain.Enabled = true;
                cmbFamilia.SelectedValue = _Categoria.Familia_Id;
            }
        }
        private void CargarCombos()
        {
            _dtFamilias = _Trastienda.WebApiProductos.ListaFamilia();

            if (_dtFamilias != null)
            {
                if (_dtFamilias.Count > 0)
                {
                    cmbFamilia.ValueMember = "Familia_Id";
                    cmbFamilia.DisplayMember = "Nombre";
                    cmbFamilia.DataSource = _dtFamilias;
                }
            }
        }
        private void Limpiar_Pantalla()
        {
            _Modifica = false;
            cmbFamilia.Enabled = true;
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = true;
            txtSubC_Categoria.Text = "";
        }
        private bool Validar_Datos()
        {
            bool res = true;
            if (Convert.ToInt32(cmbFamilia.SelectedValue) <= 0)
            {
                res = false;
                MessageBox.Show("Debe seleccionar una familia", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtCodigo.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el codigo del Categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre del Categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }

            return res;
        }
        private void Llenar_Datos()
        {
            _Categoria.Categoria_Id = txtCodigo.Text;
            _Categoria.Nombre = txtNombre.Text;
            _Categoria.Descripcion = txtDescripcion.Text;
            _Categoria.Estado = chkEstado.Checked;
            _Categoria.Fecha_Crea = System.DateTime.Now;
            _Categoria.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Categoria.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
            _Categoria.Familia_Id = cmbFamilia.SelectedValue.ToString();
        }
        private void Guardar()
        {
            try
            {
                if (Validar_Datos())
                {
                    Llenar_Datos();

                    tbCategorias _res;

                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarCategoria(_Categoria);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarCategoria(_Categoria);
                        _Modifica = true;
                    }
                    if (_res != null)
                        if (_res.Categoria_Id != "")
                        {
                            MessageBox.Show("Se guardo la Categoria correctamente", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            txtCodigo.Enabled = false;
                            cmbFamilia.Enabled = false;
                            tapMain.Enabled = true;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar el Categoria" + "\n" + ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_SubCategoria()
        {
            tbSubCategorias pDatos = new tbSubCategorias();
            pDatos.Familia_Id = cmbFamilia.SelectedValue.ToString();
            pDatos.Categoria_Id = _Categoria.Categoria_Id;
            _dtSubCategoria = _Trastienda.WebApiProductos.ListaSubCategorias_X_Categoria(pDatos);

        }
        private void Limpiar_SubCategorias()
        {
            chkSubC_Estado.Enabled = true;
            txtSubC_Codigo.Text = "";
            txtSubC_Descripcion.Text = "";
            txtSubC_Nombre.Text = "";
        }
        private void Agregar_SubCategoria()
        {
            try
            {
                if (txtSubC_Codigo.Text == "")
                {
                    MessageBox.Show("Debe agregar el codigo de la SubCategoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                    return;
                }
                if (txtSubC_Nombre.Text == "")
                {
                    MessageBox.Show("Debe agregar el nombre de la SubCategoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                if (txtSubC_Categoria.Text == "")
                {
                    MessageBox.Show("Se debe guardar priemero la categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                if (_Modifica)
                {
                    tbSubCategorias _tb = new tbSubCategorias();
                    _tb.Familia_Id = cmbFamilia.SelectedValue.ToString();
                    _tb.SubCategoria_Id = txtSubC_Codigo.Text;
                    _tb.Categoria_Id = txtCodigo.Text;
                    _tb.Nombre = txtSubC_Nombre.Text;
                    _tb.Descripcion = txtSubC_Descripcion.Text;
                    _tb.Estado = chkSubC_Estado.Checked;
                    _tb.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;

                    tbSubCategorias _res = null; ;

                    tbSubCategorias product = _dtSubCategoria.FirstOrDefault(x => x.SubCategoria_Id == _tb.SubCategoria_Id);
                    if (product != null)
                    {
                        if (MessageBox.Show("Ya existe el SubCategoria para la categoria : " + txtCodigo.Text + " \n ¿Desea modificarla?", "Categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _tb.Usuario_Crea = product.Usuario_Crea;
                            _tb.Fecha_Crea = product.Fecha_Crea;
                            _tb.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;

                            _res = _Trastienda.WebApiProductos.ModifiarSubCategoria(_tb);
                        }
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarSubCategoria(_tb);
                    }
                    if (_res != null)
                        if (_res.SubCategoria_Id != "")
                        {
                            MessageBox.Show("Se guardo la subCategoria correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            Cargar_SubCategoria();
                            Refrescar_Grid();
                            Limpiar_SubCategorias();
                        }
                }
                else
                    MessageBox.Show("Se debe guardar priemero la categoria", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar la relacion entre subCategoria con categoria " + "\n" + ex.Message, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Eliminar_SubCategoria()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    tbSubCategorias pro = new tbSubCategorias();

                    pro.Familia_Id = _Categoria.Familia_Id;
                    pro.Categoria_Id = _Categoria.Categoria_Id;
                    pro.SubCategoria_Id = row.Cells[_clmCodigo].Value.ToString();

                    if (MessageBox.Show("Esta seguro que quiere eliminar la SubCategoria", "SubCategoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_Trastienda.WebApiProductos.EliminarSubCategoria(pro))
                        {
                            MessageBox.Show("Se elimino la SubCategoria correctamente", "SubCategoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar_SubCategoria();
                            Refrescar_Grid();
                        }
                        else
                            MessageBox.Show("Se produjo un error al eliminar la SubCategoria", "SubCategoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bede seleccionar un Categoria", "Lista Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar el Categoria" + "\n" + ex.Message, "Lista Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modificar_SubCategoria()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    txtSubC_Codigo.Text = row.Cells[_clmCodigo].Value.ToString();
                    txtSubC_Nombre.Text = row.Cells[_clmNombre].Value.ToString();
                    txtSubC_Descripcion.Text = row.Cells[_clmDescripcion].Value.ToString();
                    chkSubC_Estado.Checked = Convert.ToBoolean(row.Cells[_clmEstado].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos de la relacion entre Categoria con sucursal seleccionada " + "\n" + ex.Message, "Categoria por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

    }
}
