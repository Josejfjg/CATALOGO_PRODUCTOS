using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO.Productos
{
    public partial class frmLista_Productos : Form
    {
        private bool _Salir;
        private List<tbProductos> _DTProductos;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmId = 1;
        private const int _clmCodigo = 2;
        private const int _clmNombre = 3;
        private const int _clmDescripcion = 4;
        //private const int _clmCasa_Comercial = 5;
        private const int _clmFabricante = 6;
        private const int _clmMarca = 7;
        private const int _clmUnidad_Medida = 8;
        private const int _clmContenido = 9;
        private const int _clmCompuesto = 10;
        private const int _clmFamilia = 11;
        private const int _clmCategoria = 12;
        private const int _clmSubCategoria = 13;
        private const int _clmEstado = 14;

        private List<tbFamilias> _dtFamilias;
        private List<tbCategorias> _dtCategorias;
        private List<tbSubCategorias> _dtSubCategoria;

        public bool Salir { get => _Salir; set => _Salir = value; }
        public frmLista_Productos()
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
            //InitializeComponent();
            Configuracion_Grid();
            CargarCombos();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 14;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmId].Name = "Id";
            this.dtgGrid.Columns[_clmId].Visible = false;
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].Width = 130;
            this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            this.dtgGrid.Columns[_clmDescripcion].Width = 150;
            //this.dtgGrid.Columns[_clmCasa_Comercial].Name = "Casa Comercial";
            //this.dtgGrid.Columns[_clmCasa_Comercial].Width = 180;
            this.dtgGrid.Columns[_clmFabricante].Name = "Fabricante";
            this.dtgGrid.Columns[_clmFabricante].Width = 150;
            this.dtgGrid.Columns[_clmMarca].Name = "Marca";
            this.dtgGrid.Columns[_clmMarca].Width = 150;
            this.dtgGrid.Columns[_clmUnidad_Medida].Name = "Unidad de Medida";
            this.dtgGrid.Columns[_clmUnidad_Medida].Width = 80;
            this.dtgGrid.Columns[_clmContenido].Name = "Contenido";
            this.dtgGrid.Columns[_clmContenido].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid.Columns[_clmContenido].Width = 80;
            this.dtgGrid.Columns[_clmCompuesto].Name = "Descripcion Compuesta";
            this.dtgGrid.Columns[_clmCompuesto].Width = 220;
            this.dtgGrid.Columns[_clmFamilia].Name = "Familia";
            this.dtgGrid.Columns[_clmFamilia].Width = 150;
            this.dtgGrid.Columns[_clmCategoria].Name = "Categoria";
            this.dtgGrid.Columns[_clmCategoria].Width = 180;
            this.dtgGrid.Columns[_clmSubCategoria].Name = "SubCategoria";
            this.dtgGrid.Columns[_clmSubCategoria].Width = 200;


            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Estado";
            this.dtgGrid.Columns.Add(col1);

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
                tbProductos _Prod = new tbProductos();
                _Prod.Codigo_Barras = txtCodigo.Text;
                _Prod.Nombre = txtNombre.Text;
                _Prod.Familia_Id = cmbFamilia.SelectedValue.ToString();
                _Prod.Categoria_Id = cmbCategoria.SelectedValue.ToString();

                if (!chkTodas_SubCategorias.Checked)
                    _Prod.SubCategoria_Id = cmbSubCategoria.SelectedValue.ToString();
                else
                    _Prod.SubCategoria_Id = "";

                _DTProductos = _Trastienda.WebApiProductos.ListaProductos(_Prod);               
                dtgGrid.Rows.Clear();

                if (_DTProductos != null)
                {
                    if (_DTProductos.Count > 0)
                    {
                        int j = 1;
                        foreach (tbProductos _Row in _DTProductos)
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmId].Value = _Row.Producto_Id;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.Codigo_Barras;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            //dtgGrid.Rows[index].Cells[_clmCasa_Comercial].Value = _Row.Casa_Comercial_Nombre;
                            dtgGrid.Rows[index].Cells[_clmFabricante].Value = _Row.Fabricante_Nombre;
                            dtgGrid.Rows[index].Cells[_clmMarca].Value = _Row.Marca_Nombre;
                            dtgGrid.Rows[index].Cells[_clmUnidad_Medida].Value = _Row.Unidad_Medida_Nombre;
                            dtgGrid.Rows[index].Cells[_clmContenido].Value = _Row.Contenido;
                            dtgGrid.Rows[index].Cells[_clmFamilia].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCategoria].Value = _Row.Categoria_Nombre;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria].Value = _Row.SubCategorias_Nombre;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado;
                            dtgGrid.Rows[index].Cells[_clmCompuesto].Value = _Row.Nombre + " " + _Row.Marca_Nombre + " " + _Row.Descripcion + " " + Convert.ToInt32(_Row.Contenido).ToString() + " " + _Row.Unidad_Medida_Nombre;

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
        private void Eliminar_Producto()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    tbProductos pro = new tbProductos();

                    pro.Producto_Id = Convert.ToInt32(row.Cells[_clmId].Value);

                    if (MessageBox.Show("Esta seguro que quiere eliminar el producto", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_Trastienda.WebApiProductos.EliminarProducto(pro.Producto_Id))
                            MessageBox.Show("Se elimino el producto correctamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Produjo un error al eliminar el producto", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Buscar();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar un producto", "Lista Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar el producto" + "\n" + ex.Message, "Lista Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Buscar();
        }
        private void Bn_Importar_Click(object sender, EventArgs e)
        {
            try
            {
                frmImportar_Excel frm = new frmImportar_Excel();
                if (frm.Execute(_Trastienda))
                    Refrescar_Grid();
                else
                    Refrescar_Grid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error iniciar la pantalla " + "\n" + ex.Message, "Importar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Bn_Agregar_Click(null, null);
                    break;
                case Keys.F3:
                    Bn_Modificar_Click(null, null);
                    break;
                case Keys.F4:
                    Eliminar_Producto();
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
        private void Bn_Agregar_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            if (frm.Execute(_Trastienda, new tbProductos()))
                Refrescar_Grid();
            else
                Refrescar_Grid();
        }
        private void Bn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    tbProductos pro = new tbProductos();

                    pro.Producto_Id = Convert.ToInt32(row.Cells[_clmId].Value.ToString());

                    frmProductos frm = new frmProductos();
                    //frm.MdiParent = this.MdiParent;
                    if (frm.Execute(_Trastienda, pro))
                        Refrescar_Grid();
                    else
                        Refrescar_Grid();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar un producto", "Lista Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error iniciar la pantalla " + "\n" + ex.Message, "Lista Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Bn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Producto();
        }
        #endregion

    }
}
