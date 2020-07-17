using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO.Productos
{
    public partial class rptProductos_X_Proveedor : Form
    {
        private bool _Salir;
        private List<repListProductos_X_Proveedor> _DTProductos;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmCodigo_Barras = 1;
        private const int _clmFamilia= 2;
        private const int _clmCategoria = 3;
        private const int _clmSubCategoria = 4;
        private const int _clmDescripcion_Compuesta = 5;
        private const int _clmCosto= 6;
        private const int _clmDescuento_Cliente = 7;
        private const int _clmDescuento_Factura = 8;
        private const int _clmSucursal = 9;
        private const int _clmUtilidad = 10;
        private const int _clmSugerido = 11;
        private const int _clmEstado = 12;

        private List<tbFamilias> _dtFamilias;
        private List<tbCategorias> _dtCategorias;
        private List<tbSubCategorias> _dtSubCategoria;

        public bool Salir { get => _Salir; set => _Salir = value; }
        public rptProductos_X_Proveedor()
        {
            InitializeComponent();
        }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda)
        {
            _Trastienda = pTrastienda;
            Inicializa_Pantalla();
            _Salir = false;
            dtgGrid.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
            Show();
            return _Salir;
        }
        #endregion

        #region "Metodos privados"
        private void Inicializa_Pantalla()
        {
            Configuracion_Grid();
            CargarCombos();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 13;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmCodigo_Barras].Name = "Codigo";
            this.dtgGrid.Columns[_clmFamilia].Name = "Familia";
            this.dtgGrid.Columns[_clmFamilia].Width = 150;
            this.dtgGrid.Columns[_clmCategoria].Name = "Categoria";
            this.dtgGrid.Columns[_clmCategoria].Width = 150;
            this.dtgGrid.Columns[_clmSubCategoria].Name = "SubCategoria";
            this.dtgGrid.Columns[_clmSubCategoria].Width = 150;
            this.dtgGrid.Columns[_clmDescripcion_Compuesta].Name = "Producto";
            this.dtgGrid.Columns[_clmSubCategoria].Width = 200;
            this.dtgGrid.Columns[_clmCosto].Name = "Costo";
            this.dtgGrid.Columns[_clmCosto].Width = 80;
            this.dtgGrid.Columns[_clmDescuento_Cliente].Name = "Descuento Cliente";
            this.dtgGrid.Columns[_clmDescuento_Cliente].Width = 80;
            this.dtgGrid.Columns[_clmDescuento_Factura].Name = "Descuento Factura";
            this.dtgGrid.Columns[_clmDescuento_Factura].Width = 80;
            this.dtgGrid.Columns[_clmSucursal].Name = "Sucursal";
            this.dtgGrid.Columns[_clmSucursal].Width = 80;
            this.dtgGrid.Columns[_clmUtilidad].Name = "Utilidad";
            this.dtgGrid.Columns[_clmUtilidad].Width = 80;
            this.dtgGrid.Columns[_clmSugerido].Name = "Precio Sugerido";
            this.dtgGrid.Columns[_clmSugerido].Width = 80;
            this.dtgGrid.Columns[_clmEstado].Name = "Estado";
            this.dtgGrid.Columns[_clmEstado].Width = 60;

            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;

            dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            this.dtgGrid.Refresh();
        }
        private void Refrescar_Grid()
        {
            try
            {  
                tbFiltros _filtros = new tbFiltros();
                _filtros.Sucursal_Id = Convert.ToInt32(cmbSuc_Sucursal.SelectedValue.ToString());
                _filtros.Familia_Id = cmbFamilia.SelectedValue.ToString();
                _filtros.Categoria_Id = cmbCategoria.SelectedValue.ToString();

                if (!chkTodas_SubCategorias.Checked)
                    _filtros.SubCategoria_Id = cmbSubCategoria.SelectedValue.ToString();
                else
                    _filtros.SubCategoria_Id = "";
                
                if (chkFechas.Checked)
                {
                    _filtros.Fecha_Inicio = dtpFecha_Inicio.Value;
                    _filtros.Fecha_Fin = dtpFecha_Fin.Value;
                }

                _DTProductos = _Trastienda.WebApiReportes.repListProductos_X_Proveedors(_filtros);               
                dtgGrid.Rows.Clear();

                if (_DTProductos != null)
                {
                    if (_DTProductos.Count > 0)
                    {
                        int j = 1;
                        foreach (repListProductos_X_Proveedor _Row in _DTProductos)
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmCodigo_Barras].Value = _Row.Codigo_Barras;
                            dtgGrid.Rows[index].Cells[_clmFamilia].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCategoria].Value = _Row.Categoria_Nombre;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria].Value = _Row.SubCategorias_Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion_Compuesta].Value = _Row.Descripcion_Compuesta;
                            dtgGrid.Rows[index].Cells[_clmCosto].Value = _Row.Costo;
                            dtgGrid.Rows[index].Cells[_clmDescuento_Cliente].Value = _Row.Descuento_Cliente;
                            dtgGrid.Rows[index].Cells[_clmDescuento_Factura].Value = _Row.Descuento_Factura;
                            dtgGrid.Rows[index].Cells[_clmSucursal].Value = _Row.Sucursal;
                            dtgGrid.Rows[index].Cells[_clmUtilidad].Value = _Row.Utilidad;
                            dtgGrid.Rows[index].Cells[_clmSugerido].Value = _Row.Precio_Sugerido;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado ? "Activo" : "Inactivo";                           

                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                    else
                        MessageBox.Show("No se encontraron productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron productos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Problemas al cargar los productos. /n/n " + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtgGrid.Refresh();
            }
        }
        private void Buscar()
        {
            Refrescar_Grid();
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

          List<tbSucursales>  _dtSucursales = _Trastienda.WebApiSeguridad.ListaSucursales();
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
                    //cmbSubCategoria.SelectedValue = ;                   
                }
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
                }
            }
        }
        #endregion

        #region "Eventos"
        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Categoria();
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_SubCategoria();
        }
        private void cmbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgGrid.Rows.Clear();
            //Buscar();
        }       
        private void chkTodas_SubCategorias_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTodas_SubCategorias.Checked)
                cmbSubCategoria.Enabled = true;
            else
                cmbSubCategoria.Enabled = false;
            Buscar();
        }
        private void frmLista_Productos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Buscar();
                    break;
                case Keys.F2:
                    Bn_Exportar_Click(null, null);
                    break;                
                case Keys.Enter:
                    Buscar();
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }
        private void frmLista_Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = true;
        }
        private void Bn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Bn_Salir_Click(object sender, EventArgs e)
        {
            _Salir = true;
            this.Close();
        }   
        private void Bn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {                
                Program.Exportar_Excel_DataGrid(dtgGrid);

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Problemas al exportar los productos. /n/n " + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechas.Checked)
                panelFechas.Enabled = true;
            else
                panelFechas.Enabled = false;
        }

        #endregion

       

    }
}
