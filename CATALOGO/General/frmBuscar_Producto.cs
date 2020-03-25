using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmBuscar_Producto : Form
    {
        #region "Variables privadas"
        private bool _Salir;
        private tbProductos _Producto;

        private List<tbProductos> _DTProductos;
        private TTrastienda _Trastienda;
        //private const int _clmNum = 0;
        private const int _clmId = 0;
        private const int _clmCodigo = 1;
        private const int _clmFamilia = 2;
        private const int _clmCategoria = 3;
        private const int _clmSubCategoria = 4;
        private const int _clmNombre = 5;
        //private const int _clmDescripcion = 4;
        private const int _clmCasa_Comercial = 6;
        //private const int _clmFabricante = 7;
        //private const int _clmMarca = 7;
        //private const int _clmUnidad_Medida = 8;
        //private const int _clmContenido = 9;
        private const int _clmCompuesto = 7;
       
        //private const int _clmEstado = 9;
        private const int _clmFamilia_id = 8;
        private const int _clmCategoria_id = 9;
        private const int _clmSubCategoria_id = 10;
        #endregion

        #region "Variables publicas"
        public bool Salir { get => _Salir; set => _Salir = value; }
        public tbProductos Producto { get => _Producto; set => _Producto = value; }

        #endregion

        #region "Constructor"
        public frmBuscar_Producto()
        {
            InitializeComponent();
        }
        #endregion

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda)
        {
            _Producto = new tbProductos();
            _Salir = false;

            _Trastienda = pTrastienda;
            Inicializa_Pantalla();
            dtgGrid.Enabled = true;
            this.ShowDialog();
            return _Salir;
        }
        #endregion

        #region "Metodos privados"
        private void Inicializa_Pantalla()
        {
            Configuracion_Grid();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 11;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            //this.dtgGrid.Columns[_clmNum].Name = "N°";
            //this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmId].Name = "Id";
            this.dtgGrid.Columns[_clmId].Visible = false;
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmFamilia].Name = "Familia";
            this.dtgGrid.Columns[_clmFamilia].Width = 150;
            this.dtgGrid.Columns[_clmCategoria].Name = "Categoria";
            this.dtgGrid.Columns[_clmCategoria].Width = 180;
            this.dtgGrid.Columns[_clmSubCategoria].Name = "SubCategoria";
            this.dtgGrid.Columns[_clmSubCategoria].Width = 200;
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].Visible = false;
            //this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            //this.dtgGrid.Columns[_clmDescripcion].Width = 150;
            this.dtgGrid.Columns[_clmCasa_Comercial].Name = "Casa Comercial";
            this.dtgGrid.Columns[_clmCasa_Comercial].Width = 180;
            //this.dtgGrid.Columns[_clmFabricante].Name = "Fabricante";
            //this.dtgGrid.Columns[_clmFabricante].Width = 150;
            //this.dtgGrid.Columns[_clmMarca].Name = "Marca";
            //this.dtgGrid.Columns[_clmMarca].Width = 150;
            //this.dtgGrid.Columns[_clmUnidad_Medida].Name = "Unidad de Medida";
            //this.dtgGrid.Columns[_clmUnidad_Medida].Width = 80;
            //this.dtgGrid.Columns[_clmContenido].Name = "Contenido";
            //this.dtgGrid.Columns[_clmContenido].DefaultCellStyle.Format = "#,##0.00";
            //this.dtgGrid.Columns[_clmContenido].Width = 80;
            this.dtgGrid.Columns[_clmCompuesto].Name = "Descripcion Compuesta";
            this.dtgGrid.Columns[_clmCompuesto].Width = 220;


            this.dtgGrid.Columns[_clmFamilia_id].Name = "Familia_id";
            this.dtgGrid.Columns[_clmFamilia_id].Visible = false;
            this.dtgGrid.Columns[_clmCategoria_id].Name = "Categoria_id";
            this.dtgGrid.Columns[_clmCategoria_id].Visible = false;
            this.dtgGrid.Columns[_clmSubCategoria_id].Name = "SubCategoria_id";
            this.dtgGrid.Columns[_clmSubCategoria_id].Visible = false;

            //DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            //col1.HeaderText = "Estado";
            //this.dtgGrid.Columns.Add(col1);

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
                            //dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            //dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmId].Value = _Row.Producto_Id;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.Codigo_Barras;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            //dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            dtgGrid.Rows[index].Cells[_clmCasa_Comercial].Value = _Row.Casa_Comercial_Nombre;
                            //dtgGrid.Rows[index].Cells[_clmFabricante].Value = _Row.Fabricante_Nombre;
                            //dtgGrid.Rows[index].Cells[_clmMarca].Value = _Row.Marca_Nombre;
                            //dtgGrid.Rows[index].Cells[_clmUnidad_Medida].Value = _Row.Unidad_Medida_Nombre;
                            //dtgGrid.Rows[index].Cells[_clmContenido].Value = _Row.Contenido;
                            dtgGrid.Rows[index].Cells[_clmFamilia].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCategoria].Value = _Row.Categoria_Nombre;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria].Value = _Row.SubCategorias_Nombre;
                            //dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado;
                            dtgGrid.Rows[index].Cells[_clmCompuesto].Value = _Row.Nombre + " " + _Row.Marca_Nombre + " " + _Row.Descripcion + " " + Convert.ToInt32(_Row.Contenido).ToString() + " " + _Row.Unidad_Medida_Nombre;

                            dtgGrid.Rows[index].Cells[_clmFamilia_id].Value = _Row.Familia_Id;
                            dtgGrid.Rows[index].Cells[_clmCategoria_id].Value = _Row.Categoria_Id;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria_id].Value = _Row.SubCategoria_Id;

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
            if (txtCodigo.Text.Length >= 4)
                Refrescar_Grid();
            else if (txtNombre.Text.Length >= 4)
                Refrescar_Grid();            
            else
            {
                MessageBox.Show("El Código o nombre debe contener mínimo 4 dígitos.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
            }        
        }
        private void Seleccionar()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    _Producto.Codigo_Barras = row.Cells[_clmCodigo].Value.ToString();
                    _Producto.Nombre = row.Cells[_clmNombre].Value.ToString();
                    _Producto.Familia_Id = row.Cells[_clmFamilia_id].Value.ToString();
                    _Producto.Categoria_Id = row.Cells[_clmCategoria_id].Value.ToString();
                    _Producto.SubCategoria_Id = row.Cells[_clmSubCategoria_id].Value.ToString();

                    _Salir = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar una linea", "Lista Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error iniciar la pantalla " + "\n" + ex.Message, "Lista Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos"
        private void Bn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Bn_Salir_Click(object sender, EventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void frmBuscar_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Buscar();
                    break;
                case Keys.F2:
                    Seleccionar();
                    break;
                case Keys.Enter:
                    Buscar();
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }
        private void Bn_Seleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }    
        private void dtgGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }
        #endregion   
    }
}
