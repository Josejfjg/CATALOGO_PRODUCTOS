using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO.Productos
{
    public partial class frmProductos : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private const int _colNum = 0;
        private const int _colCodigo = 1;
        private const int _colSuc_Id = 2;
        private const int _colNombre = 3;
        private const int _colCosto = 4;
        private const int _colDescuento = 5;
        private const int _colUtilidad = 6;
        private const int _colSugerido = 7;
        private const int _colSincronizado = 8;
        private const int _colEstado = 9;

        private const int _colImp_Impuesto_id = 1;
        private const int _colImp_Nombre = 2;
        private const int _colImp_Descripcion = 3;
        private const int _colImp_Activo = 4;

        private TTrastienda _Trastienda;
        private List<tbCategorias> _dtCategorias;
        private List<tbFabricantes> _dtFabricantes;
        private List<tbMarcas> _dtMarcas;
        private List<tbSubCategorias> _dtSubCategoria;
        private List<tbFamilias> _dtFamilias;
        private List<tbUnidad_Medida> _dtUnidad_Medida;
        private List<tbSucursales> _dtSucursales;
        private List<tbImpuestos> _dtImpuestos;
        private tbProductos _Producto = new tbProductos();
        private List<tbCasa_Comercial> _dtCasa_Comercial;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbProductos pProductos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Producto = pProductos;
            _Salir = false;
            Limpiar_Pantalla();
            CargarCombos();
            CargarDatos();
            Configuracion_Grid();
            Configuracion_Grid_Impuestos();
            Refrescar_Grid_Impuestos();
            Refrescar_Grid();
            Limpiar_Sucursales();
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
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_SubCategoria();
        }
        private void frmProductos_FormClosed(object sender, FormClosedEventArgs e)
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
                case "tabProducto":
                    Bn_Agregar.Enabled = false;
                    Bn_Modificar.Enabled = false;
                    Bn_Eliminar.Enabled = false;
                    Bn_Guardar.Enabled = true;
                    break;
                case "tabSucursales":
                    Bn_Agregar.Enabled = true;
                    Bn_Modificar.Enabled = true;
                    Bn_Eliminar.Enabled = true;
                    Bn_Guardar.Enabled = true;
                    break;
                case "tapImpuestos":
                    Bn_Agregar.Enabled = false;
                    Bn_Modificar.Enabled = false;
                    Bn_Eliminar.Enabled = false;
                    Bn_Guardar.Enabled = true;
                    break;

            }
        }
        private void Bn_Agregar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSucursales":
                    Agregar_Sucursales();
                    break;
            }
        }
        private void Bn_Eliminar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSucursales":
                    Eliminar_Sucursal();
                    break;
            }
        }
        private void Bn_Modificar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSucursales":
                    Modificar_Sucursal();
                    break;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtSuc_Producto_Id.Text = txtCodigo.Text;
        }
        private void dtgGrid_Impuestos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgGrid_Impuestos.SelectedRows.Count > 0)
            {
                _Producto.Impuestos.Remove(_Producto.Impuestos.FirstOrDefault(x => x.Impuesto_Id == this.dtgGrid_Impuestos.SelectedRows[0].Cells[_colImp_Impuesto_id].Value.ToString()));

                if (!Convert.ToBoolean(this.dtgGrid_Impuestos.SelectedRows[0].Cells[_colImp_Activo].Value))
                {
                    tbProducto_Impuestos tb = new tbProducto_Impuestos();
                    //tb.Producto_Id = txtCodigo.Text;
                    tb.Impuesto_Id = this.dtgGrid_Impuestos.SelectedRows[0].Cells[_colImp_Impuesto_id].Value.ToString();
                    tb.Estado = true;
                    tb.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
                    _Producto.Impuestos.Add(tb);
                }
                //else
                //    _Producto.Impuestos.Remove(_Producto.Impuestos.FirstOrDefault(x => x.Impuesto_Id == Convert.ToInt32(this.dtgGrid_Impuestos.SelectedRows[0].Cells[_colImp_Impuesto_id].Value)));


            }
        }
        private void frmProductos_KeyDown(object sender, KeyEventArgs e)
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
        private void chkSuc_Todas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSuc_Todas.Checked)
                {
                    cmbSuc_Sucursal.Enabled = false;
                }
                else
                {
                    cmbSuc_Sucursal.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Categoria();
        }
        #endregion

        #region "Metodos Privados"
        private void Inicializa_Pantalla()
        {
            InitializeComponent();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 8;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_colNum].Name = "N°";
            this.dtgGrid.Columns[_colCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_colSuc_Id].Name = "Suc_Id";
            this.dtgGrid.Columns[_colNombre].Name = "Nombre";
            this.dtgGrid.Columns[_colCosto].Name = "Costo";
            //this.dtgGrid.Columns[_colImp_Impuesto_id].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgGrid.Columns[_colCosto].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid.Columns[_colDescuento].Name = "Descuento";
            this.dtgGrid.Columns[_colDescuento].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid.Columns[_colUtilidad].Name = "Utilidad";
            this.dtgGrid.Columns[_colUtilidad].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid.Columns[_colSugerido].Name = "Sugerido";
            this.dtgGrid.Columns[_colSugerido].DefaultCellStyle.Format = "#,##0.00";

            this.dtgGrid.Columns[_colNum].Width = 30;
            this.dtgGrid.Columns[_colNombre].Width = 200;
            this.dtgGrid.Columns[_colSuc_Id].Visible = false;

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Sincronizado";
            this.dtgGrid.Columns.Add(col1);

            DataGridViewCheckBoxColumn col2 = new DataGridViewCheckBoxColumn();
            col2.HeaderText = "Activo";
            this.dtgGrid.Columns.Add(col2);

            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;
            dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                //columnas al ancho del DataGridview para que no quede espacio en blanco
            this.dtgGrid.Refresh();
        }
        private void Refrescar_Grid()
        {
            dtgGrid.Rows.Clear();
            try
            {
                if (_Producto.Sucursales != null)
                {
                    if (_Producto.Sucursales.Count > 0)
                    {
                        int j = 1;
                        foreach (tbProducto_Sucursal _Row in _Producto.Sucursales)
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_colNum].Value = j;
                            dtgGrid.Rows[index].Cells[_colNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_colCodigo].Value = txtCodigo.Text;
                            dtgGrid.Rows[index].Cells[_colSuc_Id].Value = _Row.Sucursal_Id;
                            dtgGrid.Rows[index].Cells[_colNombre].Value = _Row.Sucursal_Nombre;
                            dtgGrid.Rows[index].Cells[_colCosto].Value = _Row.Costo;
                            dtgGrid.Rows[index].Cells[_colDescuento].Value = _Row.Descuento;
                            dtgGrid.Rows[index].Cells[_colUtilidad].Value = _Row.Utilidad;
                            dtgGrid.Rows[index].Cells[_colSugerido].Value = _Row.Sugerido;
                            dtgGrid.Rows[index].Cells[_colSincronizado].Value = _Row.Sincronizado;
                            dtgGrid.Rows[index].Cells[_colEstado].Value = _Row.Estado;

                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _dtImpuestos = _Trastienda.WebApiProductos.ListaImpuestos();

            if (_Producto.Producto_Id > 0)
            {
                _Modifica = true;
                _Producto = _Trastienda.WebApiProductos.GetProducto(_Producto.Producto_Id);

                txtCodigo.Text = _Producto.Codigo_Barras;
                txtCodigo.Enabled = false;

                txtNombre.Text = _Producto.Nombre;
                txtDescripcion.Text = _Producto.Descripcion;
                cmbUnidad_Medida.SelectedValue = _Producto.Unidad_Medida_Id;
                txtContenido.Value = _Producto.Contenido;
                cmbFamilia.SelectedValue = _Producto.Familia_Id;
                cmbCategoria.SelectedValue = _Producto.Categoria_Id;
                cmbSubCategoria.SelectedValue = _Producto.SubCategoria_Id;
                cmbMarca.SelectedValue = _Producto.Marca_Id;
                cmbFabricante.SelectedValue = _Producto.Fabricante_Id;
                chkEstado.Checked = _Producto.Estado;
                cmbCasa_Comercial.SelectedValue = _Producto.Casa_Comercial_Id;
                txtHablador.Text = _Producto.Descripcion_Corta;

                //Cargar_SubCategoria(_Producto.SubCategoria_Id);
                txtSuc_Producto_Id.Text = _Producto.Nombre + " " + _Producto.Marca_Nombre + " " + _Producto.Descripcion + " " + Convert.ToInt32(_Producto.Contenido).ToString() + " " + _Producto.Unidad_Medida_Nombre;

            }
        }
        private void Limpiar_Pantalla()
        {
            _Modifica = false;
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtContenido.Value = 0;
            chkEstado.Checked = true;
        }
        private void CargarCombos()
        {

            _dtFabricantes = _Trastienda.WebApiProductos.ListaFabricantes();
            _dtFamilias = _Trastienda.WebApiProductos.ListaFamilia();
            _dtMarcas = _Trastienda.WebApiProductos.ListaMarcas();
            _dtUnidad_Medida = _Trastienda.WebApiProductos.ListaUnidad_Medida();

            _dtCasa_Comercial = _Trastienda.WebApiProductos.ListaCasa_Comercial();

            _dtSucursales = _Trastienda.WebApiSeguridad.ListaSucursales();

            if (_dtFabricantes != null)
            {
                if (_dtFabricantes.Count > 0)
                {
                    cmbFabricante.ValueMember = "Fabricante_Id";
                    cmbFabricante.DisplayMember = "Nombre";
                    cmbFabricante.DataSource = _dtFabricantes;
                }
            }
            if (_dtFamilias != null)
            {
                if (_dtFamilias.Count > 0)
                {
                    cmbFamilia.ValueMember = "Familia_Id";
                    cmbFamilia.DisplayMember = "Nombre";
                    cmbFamilia.DataSource = _dtFamilias;
                }
            }
            if (_dtMarcas != null)
            {
                if (_dtCategorias.Count > 0)
                {
                    cmbMarca.ValueMember = "Marca_Id";
                    cmbMarca.DisplayMember = "Nombre";
                    cmbMarca.DataSource = _dtMarcas;
                }
            }
            if (_dtUnidad_Medida != null)
            {
                if (_dtUnidad_Medida.Count > 0)
                {
                    cmbUnidad_Medida.ValueMember = "Unidad_Medida_Id";
                    cmbUnidad_Medida.DisplayMember = "Nombre";
                    cmbUnidad_Medida.DataSource = _dtUnidad_Medida;
                }
            }

            /*SUCURSALES*/
            if (_dtSucursales != null)
            {
                if (_dtSucursales.Count > 0)
                {
                    cmbSuc_Sucursal.ValueMember = "Sucursal_Id";
                    cmbSuc_Sucursal.DisplayMember = "Nombre";
                    cmbSuc_Sucursal.DataSource = _dtSucursales;
                    cmbSuc_Sucursal.SelectedItem = 1;
                }
            }

            if (_dtCasa_Comercial != null)
            {
                if (_dtCasa_Comercial.Count > 0)
                {
                    cmbCasa_Comercial.ValueMember = "Casa_Comercial_Id";
                    cmbCasa_Comercial.DisplayMember = "Nombre";
                    cmbCasa_Comercial.DataSource = _dtCasa_Comercial;
                }
            }
        }
        private bool Validar_Datos()
        {
            bool res = true;
            if (txtCodigo.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el codigo del producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtContenido.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el contenido del producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContenido.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre del producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }

            return res;
        }
        private void Llenar_Datos()
        {
            _Producto.Codigo_Barras = txtCodigo.Text;
            _Producto.Fabricante_Id = cmbFabricante.SelectedValue.ToString();
            _Producto.Marca_Id = cmbMarca.SelectedValue.ToString();
            _Producto.Unidad_Medida_Id = cmbUnidad_Medida.SelectedValue.ToString();
            _Producto.Familia_Id = cmbFamilia.SelectedValue.ToString();
            _Producto.Categoria_Id = cmbCategoria.SelectedValue.ToString();
            _Producto.SubCategoria_Id = cmbSubCategoria.SelectedValue.ToString();
            _Producto.Nombre = txtNombre.Text;
            _Producto.Descripcion = txtDescripcion.Text;
            _Producto.Contenido = txtContenido.Value;
            _Producto.Estado = chkEstado.Checked;
            _Producto.Fecha_Crea = System.DateTime.Now;
            _Producto.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Producto.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;

            _Producto.Descripcion_Corta = txtHablador.Text;
            _Producto.Casa_Comercial_Id = cmbCasa_Comercial.SelectedValue.ToString();
            if (_Producto.Sucursales.Count == 0)
            {
                _Producto.Sucursales = new List<tbProducto_Sucursal>();
            }

            if (_Producto.Impuestos.Count == 0)
            {
                _Producto.Impuestos = new List<tbProducto_Impuestos>();
            }
        }
        private void Guardar()
        {
            try
            {
                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        tbProductos _res = _Trastienda.WebApiProductos.ModifiarProductos(_Producto);
                        if (_res != null)
                            if (_res.Producto_Id > 0)
                            {
                                MessageBox.Show("Se guardo el producto correctamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _Salir = true;
                                this.Close();
                            }
                    }
                    else
                    {
                        tbProductos _res = _Trastienda.WebApiProductos.AgregarProductos(_Producto);
                        if (_res != null)
                            if (_res.Producto_Id > 0)
                            {
                                MessageBox.Show("Se guardo el producto correctamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _Salir = true;
                                this.Close();
                            }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar el producto" + "\n" + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cargar_SubCategoria()
        {
            tbSubCategorias _tb = new tbSubCategorias();
            _tb.Familia_Id = cmbFamilia.SelectedValue.ToString();
            _tb.Categoria_Id = cmbCategoria.SelectedValue.ToString();
            _dtSubCategoria = _Trastienda.WebApiProductos.ListaSubCategorias(_tb);

            if (_dtSubCategoria != null)
            {
                if (_dtSubCategoria.Count > 0)
                {
                    cmbSubCategoria.ValueMember = "SubCategoria_Id";
                    cmbSubCategoria.DisplayMember = "Nombre";
                    cmbSubCategoria.DataSource = _dtSubCategoria;
                    if (_Modifica)
                        cmbSubCategoria.SelectedValue = _Producto.SubCategoria_Id;
                }
            }
        }
        private void Limpiar_Sucursales()
        {
            cmbSuc_Sucursal.Enabled = true;
            cmbSuc_Sucursal.SelectedItem = 1;
            txtSuc_Costo.Value = 0;
            txtSuc_Descuento.Value = 0;
            txtSuc_Utilidad.Value = 0;
            txtSuc_Sugerido.Value = 0;
            chkSuc_Estado.Checked = true;
            chkSuc_Todas.Checked = false;
            //chkSuc_Todas.Enabled = true;
        }
        private void Agregar_Sucursal(int pId, string pNombre)
        {
            try
            {
                tbProducto_Sucursal _tb = new tbProducto_Sucursal();
                _tb.Sucursal_Id = pId;
                _tb.Sucursal_Nombre = pNombre;
                _tb.Costo = txtSuc_Costo.Value;
                _tb.Descuento = txtSuc_Descuento.Value;
                _tb.Utilidad = txtSuc_Utilidad.Value;
                _tb.Sugerido = txtSuc_Sugerido.Value;
                _tb.Estado = chkSuc_Estado.Checked;
                _tb.Sincronizado = false;
                _tb.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;

                tbProducto_Sucursal product = _Producto.Sucursales.FirstOrDefault(x => x.Sucursal_Id == pId);
                if (product != null)
                {
                    if (MessageBox.Show("Ya existe el producto para la sucursal : " + pNombre + " \n ¿Desea modificarlo?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _tb.Usuario_Crea = product.Usuario_Crea;
                        _tb.Fecha_Crea = product.Fecha_Crea;
                        product = _tb;
                        product.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
                        _Producto.Sucursales.Remove(_Producto.Sucursales.FirstOrDefault(x => x.Sucursal_Id == Convert.ToInt32(_tb.Sucursal_Id)));
                        _Producto.Sucursales.Add(_tb);
                    }
                }
                else
                {
                    _Producto.Sucursales.Add(_tb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar la relacion entre producto con sucursal " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Sucursales()
        {
            try
            {
                if (chkSuc_Todas.Checked)
                {
                    foreach (tbSucursales _Row in _dtSucursales)
                    {
                        Agregar_Sucursal(_Row.Sucursal_Id, _Row.Nombre);
                    }
                }
                else
                {
                    Agregar_Sucursal(Convert.ToInt32(cmbSuc_Sucursal.SelectedValue), cmbSuc_Sucursal.Text);
                }
                Limpiar_Sucursales();
                Refrescar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar la relacion entre producto con sucursal " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar_Sucursales();
                Refrescar_Grid();
            }
        }
        private void Eliminar_Sucursal()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];

                    if (MessageBox.Show("Esta seguro que quiere eliminar el producto", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Producto.Sucursales.Remove(_Producto.Sucursales.FirstOrDefault(x => x.Sucursal_Id == Convert.ToInt32(row.Cells[_colSuc_Id].Value)));
                        Refrescar_Grid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar la relacion entre producto con sucursal " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modificar_Sucursal()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];

                    cmbSuc_Sucursal.Enabled = false;
                    //chkSuc_Todas.Enabled = false;
                    cmbSuc_Sucursal.SelectedValue = Convert.ToInt32(row.Cells[_colSuc_Id].Value);
                    txtSuc_Costo.Value = Convert.ToDecimal(row.Cells[_colCosto].Value);
                    txtSuc_Descuento.Value = Convert.ToDecimal(row.Cells[_colDescuento].Value); ;
                    txtSuc_Utilidad.Value = Convert.ToDecimal(row.Cells[_colUtilidad].Value); ;
                    txtSuc_Sugerido.Value = Convert.ToDecimal(row.Cells[_colSugerido].Value); ;
                    chkSuc_Estado.Checked = Convert.ToBoolean(row.Cells[_colEstado].Value); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos de la relacion entre producto con sucursal seleccionada " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Configuracion_Grid_Impuestos()
        {
            this.dtgGrid_Impuestos.ColumnCount = 4;

            this.dtgGrid_Impuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid_Impuestos.RowHeadersVisible = false;

            this.dtgGrid_Impuestos.Columns[_colNum].Name = "N°";
            this.dtgGrid_Impuestos.Columns[_colNum].ReadOnly = true;

            this.dtgGrid_Impuestos.Columns[_colImp_Impuesto_id].Name = "Codigo";
            this.dtgGrid_Impuestos.Columns[_colImp_Impuesto_id].ReadOnly = true;

            this.dtgGrid_Impuestos.Columns[_colImp_Nombre].Name = "Nombre";
            this.dtgGrid_Impuestos.Columns[_colImp_Nombre].ReadOnly = true;

            this.dtgGrid_Impuestos.Columns[_colImp_Descripcion].Name = "Descripcion";
            this.dtgGrid_Impuestos.Columns[_colImp_Descripcion].ReadOnly = true;
            this.dtgGrid_Impuestos.Columns[_colImp_Descripcion].Width = 370;

            this.dtgGrid_Impuestos.Columns[_colNum].Width = 30;
            this.dtgGrid_Impuestos.Columns[_colImp_Nombre].Width = 330;

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "Activo";
            this.dtgGrid_Impuestos.Columns.Add(col);

            this.dtgGrid_Impuestos.Columns[_colImp_Activo].ReadOnly = false;

            this.dtgGrid_Impuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid_Impuestos.MultiSelect = false;
            this.dtgGrid_Impuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                //columnas al ancho del DataGridview para que no quede espacio en blanco
            this.dtgGrid_Impuestos.Refresh();
        }
        private void Refrescar_Grid_Impuestos()
        {
            try
            {
                dtgGrid_Impuestos.Rows.Clear();
                if (_dtImpuestos != null)
                {
                    int j = 1;
                    foreach (tbImpuestos _Row in _dtImpuestos)
                    {
                        var index = dtgGrid_Impuestos.Rows.Add();
                        dtgGrid_Impuestos.Rows[index].Cells[_colNum].Value = j;
                        dtgGrid_Impuestos.Rows[index].Cells[_colNum].Tag = j - 1;

                        dtgGrid_Impuestos.Rows[index].Cells[_colImp_Impuesto_id].Value = _Row.Impuesto_Id;
                        dtgGrid_Impuestos.Rows[index].Cells[_colImp_Nombre].Value = _Row.Nombre;
                        dtgGrid_Impuestos.Rows[index].Cells[_colImp_Descripcion].Value = _Row.Descripcion;

                        bool _estado = false;
                        if (_Producto.Impuestos != null)
                        {
                            if (_Producto.Impuestos.Count > 0)
                            {
                                tbProducto_Impuestos product = _Producto.Impuestos.FirstOrDefault(x => x.Impuesto_Id == _Row.Impuesto_Id.ToString());
                                if (product != null)
                                    _estado = product.Impuesto_Id != "";
                            }
                        }
                        dtgGrid_Impuestos.Rows[index].Cells[_colImp_Activo].Value = _estado;

                        dtgGrid_Impuestos.AutoGenerateColumns = true;
                        j++;
                    }


                }
                else
                {
                    MessageBox.Show("No se encontraron impuestos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid_Impuestos.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid_Impuestos.Refresh();
            }
        }
        private void Cargar_Categoria()
        {
            tbCategorias _tb = new tbCategorias();
            _tb.Familia_Id = cmbFamilia.SelectedValue.ToString();
            _dtCategorias = _Trastienda.WebApiProductos.ListaCategorias(_tb);

            if (_dtCategorias != null)
            {
                if (_dtCategorias.Count > 0)
                {
                    cmbCategoria.ValueMember = "Categoria_Id";
                    cmbCategoria.DisplayMember = "Nombre";
                    cmbCategoria.DataSource = _dtCategorias;
                    if (_Modifica)
                        cmbCategoria.SelectedValue = _Producto.Categoria_Id;
                }
            }
        }

        #endregion

        private void txtHablador_TextChanged(object sender, EventArgs e)
        {
            if (txtHablador.Text.Length > 0)
                lblHablador_Lent.Text = txtHablador.Text.Length.ToString();
            else
                lblHablador_Lent.Text = "";
        }
    }
}
