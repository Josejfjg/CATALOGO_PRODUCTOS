using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
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
        private const int _colUtilidad = 5;
        private const int _colSugerido = 6;
        private const int _colSincronizado = 7;
        private const int _colEstado = 8;

        private const int _colImp_Impuesto_id = 1;
        private const int _colImp_Nombre = 2;
        private const int _colImp_Descripcion = 3;
        private const int _colImp_Activo = 4;

        private const int _colProveedor_Num = 0;
        private const int _colProveedor_Codigo = 1;
        private const int _colProveedor_Nombre = 2;
        private const int _colProveedor_Costo = 3;
        private const int _colProveedor_Descuento_Cliente = 4;
        private const int _colProveedor_Descuento_Factura = 5;


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
            Configuracion_Grid_Proveedor();
            Limpiar_Proveedor();
            Refrescar_Grid_Proveedor();
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
        private void Bn_Modificar_Click(object sender, EventArgs e)
        {
            switch (tapMain.SelectedTab.Name)
            {
                case "tabSucursales":
                    Modificar_Sucursal();
                    break;
                case "tabProveedor":
                    Modificar_Proveedores();
                    break;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtSuc_Producto_Id.Text = txtCodigo.Text;
            txtProv_Producto_Id.Text = txtSuc_Producto_Id.Text;
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
                MessageBox.Show("Se produjo un error" + "\n" + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Categoria();
        }
        private void txtHablador_TextChanged(object sender, EventArgs e)
        {
            if (txtHablador.Text.Length > 0)
                lblHablador_Lent.Text = txtHablador.Text.Length.ToString();
            else
                lblHablador_Lent.Text = "";
        }
        private void btnBuscar_Fabricante_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Codigo", typeof(string));
                table.Columns.Add("Nombre", typeof(string));
                foreach (tbFabricantes str in _dtFabricantes)
                {
                    DataRow row = table.NewRow();
                    row["Codigo"] = str.Fabricante_Id;
                    row["Nombre"] = str.Nombre;
                    table.Rows.Add(row);
                }

                frmBuscar frm = new frmBuscar();
                if (frm.Execute(_Trastienda, table))
                {
                    txtCodigo_Fabricante.Text = frm.Codigo;
                    txtNombre_Fabricante.Text = frm.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar el fabricante" + "\n" + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Marca_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Codigo", typeof(string));
                table.Columns.Add("Nombre", typeof(string));
                foreach (tbMarcas str in _dtMarcas)
                {
                    DataRow row = table.NewRow();
                    row["Codigo"] = str.Marca_Id;
                    row["Nombre"] = str.Nombre;
                    table.Rows.Add(row);
                }

                frmBuscar frm = new frmBuscar();
                if (frm.Execute(_Trastienda, table))
                {
                    txtCodigo_Marca.Text = frm.Codigo;
                    txtNombre_Marca.Text = frm.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar la casa comercial" + "\n" + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Proveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Codigo", typeof(string));
                table.Columns.Add("Nombre", typeof(string));
                foreach (tbCasa_Comercial str in _dtCasa_Comercial)
                {
                    DataRow row = table.NewRow();
                    row["Codigo"] = str.Casa_Comercial_Id;
                    row["Nombre"] = str.Nombre;
                    table.Rows.Add(row);
                }

                frmBuscar frm = new frmBuscar();
                if (frm.Execute(_Trastienda, table))
                {
                    txtCodigo_Proveedor.Text = frm.Codigo;
                    txtNombre_Proveedor.Text = frm.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar el proveedor" + "\n" + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bnProv_Mas_Click(object sender, EventArgs e)
        {
            Agregar_Proveedores();
        }
        private void bnProv_Menos_Click(object sender, EventArgs e)
        { 
            Eliminar_Proveedores();          
        }
        private void bmSuc_Mas_Click(object sender, EventArgs e)
        {
            Agregar_Sucursales();
        }

        private void bnSuc_Menos_Click(object sender, EventArgs e)
        {
            Eliminar_Sucursal();
        }
        #endregion

        #region "Metodos Privados"
        private void Inicializa_Pantalla()
        {
            InitializeComponent();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 7;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_colNum].Name = "N°";
            this.dtgGrid.Columns[_colCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_colSuc_Id].Name = "Suc_Id";
            this.dtgGrid.Columns[_colNombre].Name = "Nombre";
            this.dtgGrid.Columns[_colCosto].Name = "Costo";
            this.dtgGrid.Columns[_colCosto].DefaultCellStyle.Format = "#,##0.00";
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
                throw new Exception(ex.Message);
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
                txtCodigo_Marca.Text = _Producto.Marca_Id;
                txtNombre_Marca.Text = _Producto.Marca_Nombre;
                txtCodigo_Fabricante.Text = _Producto.Fabricante_Id;
                txtNombre_Fabricante.Text = _Producto.Fabricante_Nombre;
                chkEstado.Checked = _Producto.Estado;
                txtHablador.Text = _Producto.Descripcion_Corta;
                txtSuc_Producto_Id.Text = _Producto.Nombre + " " + _Producto.Marca_Nombre + " " + _Producto.Descripcion + " " + Convert.ToInt32(_Producto.Contenido).ToString() + " " + _Producto.Unidad_Medida_Nombre;
                txtProv_Producto_Id.Text = txtSuc_Producto_Id.Text;
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


            if (_dtFamilias != null)
            {
                if (_dtFamilias.Count > 0)
                {
                    cmbFamilia.ValueMember = "Familia_Id";
                    cmbFamilia.DisplayMember = "Nombre";
                    cmbFamilia.DataSource = _dtFamilias;
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
        }
        private bool Validar_Datos()
        {
            bool res = true;
            string message = "";

            if (txtCodigo.Text == "")
            {
                res = false;
                message += "Debe agregar el codigo del producto ";
                txtCodigo.Focus();
            }
            if (txtContenido.Text == "")
            {
                res = false;
                message += "\n" + "Debe agregar el contenido del producto ";
                txtContenido.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                message +=  "\n" + "Debe agregar el nombre del producto ";
                txtNombre.Focus();
            }
            if (txtCodigo_Fabricante.Text == "")
            {
                res = false;
                message += "\n" + "Debe agregar un fabricante ";
                txtCodigo_Fabricante.Focus();
            }

            if (txtCodigo_Marca.Text == "")
            {
                res = false;
                message += "\n" + "Debe agregar una marca ";
            }

            if(!res)
                MessageBox.Show(message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return res;
        }
        private void Llenar_Datos()
        {
            _Producto.Codigo_Barras = txtCodigo.Text;
            _Producto.Fabricante_Id = txtCodigo_Fabricante.Text;
            _Producto.Marca_Id = txtCodigo_Marca.Text;
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
            //_Producto.Casa_Comercial_Id = txtCodigo_Casa_Comercial.Text;
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
                    cmbSuc_Sucursal.SelectedValue = Convert.ToInt32(row.Cells[_colSuc_Id].Value);
                    txtSuc_Costo.Value = Convert.ToDecimal(row.Cells[_colCosto].Value);                   
                    txtSuc_Utilidad.Value = Convert.ToDecimal(row.Cells[_colUtilidad].Value); 
                    txtSuc_Sugerido.Value = Convert.ToDecimal(row.Cells[_colSugerido].Value); 
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
        private void Agregar_Proveedores()
        {
            try
            {
                if (txtCodigo_Proveedor.Text != "")
                {
                    tbProducto_Casa_Comercial _tb = new tbProducto_Casa_Comercial();
                    _tb.Casa_Comercial_Id = txtCodigo_Proveedor.Text;
                    _tb.Casa_Comercial_Nombre = txtNombre_Proveedor.Text;
                    _tb.Costo = txtProv_Costo.Value;
                    _tb.Descuento_Cliente = txtProv_Descuento_Cliente.Value;
                    _tb.Descuento_Factura = txtProv_Descuento_Factura.Value;
                    _tb.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;

                    tbProducto_Casa_Comercial product = _Producto.Casas_Comerciales.FirstOrDefault(x => x.Casa_Comercial_Id == _tb.Casa_Comercial_Id);
                    if (product != null)
                    {
                        if (MessageBox.Show("Ya existe el proveedor : " + txtNombre_Proveedor + " \n ¿Desea modificarlo?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _tb.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
                            product = _tb;

                            _Producto.Casas_Comerciales.Remove(_Producto.Casas_Comerciales.FirstOrDefault(x => x.Casa_Comercial_Id == _tb.Casa_Comercial_Id));
                            _Producto.Casas_Comerciales.Add(_tb);
                        }
                    }
                    else
                    {
                        _Producto.Casas_Comerciales.Add(_tb);
                    }

                    Limpiar_Proveedor();
                    Refrescar_Grid_Proveedor();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un proveedor", "Producto por Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo_Proveedor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al agregar la relacion entre producto y proveedor " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar_Proveedor();
                Refrescar_Grid();
            }
        }
        private void Eliminar_Proveedores()
        {
            try
            {
                if (dtgGrid_Proveedor.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid_Proveedor.SelectedRows[0];

                    if (MessageBox.Show("Esta seguro que quiere eliminar proveedor", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Producto.Casas_Comerciales.Remove(_Producto.Casas_Comerciales.FirstOrDefault(x => x.Casa_Comercial_Id == row.Cells[_colProveedor_Codigo].Value.ToString()));
                        Refrescar_Grid_Proveedor();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar la relacion entre producto y proveedor " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modificar_Proveedores()
        {
            try
            {
                if (dtgGrid_Proveedor.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid_Proveedor.SelectedRows[0];

                    txtCodigo_Proveedor.Text = row.Cells[_colProveedor_Codigo].Value.ToString();
                    txtNombre_Proveedor.Text = row.Cells[_colProveedor_Nombre].Value.ToString();
                    txtProv_Costo.Value = Convert.ToDecimal(row.Cells[_colProveedor_Costo].Value);
                    txtProv_Descuento_Cliente.Value = Convert.ToDecimal(row.Cells[_colProveedor_Descuento_Cliente].Value);
                    txtProv_Descuento_Factura.Value = Convert.ToDecimal(row.Cells[_colProveedor_Descuento_Factura].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos de la relacion entre producto con sucursal seleccionada " + "\n" + ex.Message, "Producto por Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar_Proveedor()
        {
            txtProv_Costo.Value = 0;
            txtProv_Descuento_Cliente.Value = 0;
            txtProv_Descuento_Factura.Value = 0;
            txtCodigo_Proveedor.Text = "";
            txtNombre_Proveedor.Text = "";
        }
        private void Configuracion_Grid_Proveedor()
        {
            this.dtgGrid_Proveedor.ColumnCount = 6;

            this.dtgGrid_Proveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid_Proveedor.RowHeadersVisible = false;

            this.dtgGrid_Proveedor .Columns[_colNum].Name = "N°";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Codigo].Name = "Codigo";           
            this.dtgGrid_Proveedor.Columns[_colProveedor_Nombre].Name = "Proveedor";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Costo].Name = "Costo";
            this.dtgGrid_Proveedor.Columns[_colCosto].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Descuento_Cliente].Name = "Descuento Cliente";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Descuento_Cliente].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Descuento_Factura].Name = "Descuento Factura";
            this.dtgGrid_Proveedor.Columns[_colProveedor_Descuento_Factura].DefaultCellStyle.Format = "#,##0.00";

            this.dtgGrid_Proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid_Proveedor.MultiSelect = false;
            this.dtgGrid_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                //columnas al ancho del DataGridview para que no quede espacio en blanco
            this.dtgGrid_Proveedor.Refresh();
        }
        private void Refrescar_Grid_Proveedor()
        {
            dtgGrid_Proveedor.Rows.Clear();
            try
            {
                if (_Producto.Casas_Comerciales != null)
                {
                    if (_Producto.Casas_Comerciales.Count > 0)
                    {
                        int j = 1;
                        foreach (tbProducto_Casa_Comercial _Row in _Producto.Casas_Comerciales)
                        {
                            var index = dtgGrid_Proveedor.Rows.Add();
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Num].Value = j;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Num].Tag = j - 1;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Codigo].Value = _Row.Casa_Comercial_Id;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Nombre].Value = _Row.Casa_Comercial_Nombre;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Costo].Value = _Row.Costo;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Descuento_Cliente].Value = _Row.Descuento_Cliente;
                            dtgGrid_Proveedor.Rows[index].Cells[_colProveedor_Descuento_Factura].Value = _Row.Descuento_Factura;
                            dtgGrid_Proveedor.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid_Proveedor.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid_Proveedor.Refresh();
                throw new Exception(ex.Message);
            }
        }



        #endregion

    }
}
