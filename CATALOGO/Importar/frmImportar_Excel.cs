using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmImportar_Excel : Form
    {
        private bool _Salir = false;
        private TTrastienda _Trastienda;
        private DataSet _DatosExcel = new DataSet();
        private string _MessasErrorValidation = string.Empty;
        List<ExcelProductos> _ListProductos = new List<ExcelProductos>();

        private List<ExcelProductos> _DTProductos;
        private const int _clmNum = 0;
        private const int _clmId = 1;
        private const int _clmCodigo = 2;
        private const int _clmNombre = 3;
        private const int _clmDescripcion = 4;
        private const int _clmCasa_Comercial = 5;
        private const int _clmFabricante = 6;
        private const int _clmMarca = 7;
        private const int _clmUnidad_Medida = 8;
        private const int _clmContenido = 9;
        private const int _clmFamilia = 10;
        private const int _clmCategoria = 11;
        private const int _clmSubCategoria = 12;
        private const int _clmError = 13;

        private List<tbCategorias> _dtCategorias;
        private List<tbFabricantes> _dtFabricantes;
        private List<tbMarcas> _dtMarcas;
        private List<tbSubCategorias> _dtSubCategoria;
        private List<tbFamilias> _dtFamilias;
        private List<tbUnidad_Medida> _dtUnidad_Medida;
        private List<tbCasa_Comercial> _dtCasa_Comercial;

        private string[] _ListaColumnas = new string[11] { "CODIGO BARRAS",
                                                           "CASA COMERCIAL",
                                                            "FABRICANTE",
                                                            "PRODUCTO",
                                                            "MARCA",
                                                            "DESCRIPCION",
                                                            "DESCRIPCION CORTA",
                                                            "UNDAD UNIDAD DE MEDIDA",
                                                            "FAMILIA",
                                                            "CATEGORIA",
                                                            "SUBCATEGORIA" };

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Salir = false;
            this.ShowDialog();
            return _Salir;
        }

        #endregion

        #region "Eventos"
        private void Inicializa_Pantalla()
        {
            InitializeComponent();
            Bn_Guardar.Enabled = false;
            Bn_Validar.Enabled = false;
        }
        private void Bn_Salir_Click(object sender, EventArgs e)
        {
            Bn_Guardar.Enabled = false;
            Bn_Validar.Enabled = false;
            _Salir = false;
            this.Close();
        }
        private void Bn_Importar_Click(object sender, EventArgs e)
        {
            Bn_Guardar.Enabled = false;
            Bn_Validar.Enabled = false;
            if (Buscar_Ubicacion_Excel())
                Bn_Validar.Enabled = true;
        }
        private void Bn_Validar_Click(object sender, EventArgs e)
        {
            try
            {
                Bn_Guardar.Enabled = false;
                _ListProductos = new List<ExcelProductos>();
                //dtgGrid.DataSource = null;
                dtgGrid.Refresh();
                Configuracion_Grid();
                if (ValidaDatosExcel())
                {
                    Bn_Guardar.Enabled = true;
                }
                Refrescar_Grid();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region "Metodos Privados"
        private bool Buscar_Ubicacion_Excel()
        {
            try
            {
                //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                                 //solo los archivos excel

                dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

                dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

                //si al seleccionar el archivo damos Ok
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //el nombre del archivo sera asignado al textbox
                    txtDirectorio.Text = dialog.FileName;
                    return ImportarExcel(dialog.FileName); //se manda a llamar al metodo
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se genero un problema al cargar los datos desde excel.", "Importar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ImportarExcel(string archivo)
        {
            //Declaramos las variables
            OleDbConnection conexion = null;
            DataSet dataset = null;
            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            string consultaHojaExcel = "SELECT * FROM [PRODUCTOS$]";

            /**************AQUÍ INTENTO HACER LA EXPORTACIÓN DE LOS DISTINTOS RANGOS********/

            string cadenaConexionArchivoExcell = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + archivo + ";Extended Properties=" + '"' + "Excel 12.0 Xml;HDR=YES" + '"';
            //para archivos de 97-2003 usar la siguiente cadena


            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer

            try
            {
                conexion = default(OleDbConnection);
                //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                conexion = new OleDbConnection(cadenaConexionArchivoExcell);//creamos la conexion con la hoja de excel
                conexion.Open(); //abrimos la conexion

                OleDbCommand oledbCmd = default(OleDbCommand);
                oledbCmd = new OleDbCommand(consultaHojaExcel, conexion);

                dataadapter = new OleDbDataAdapter(oledbCmd); //traemos los datos de la hoja y las guardamos en un dataSdapter         
                //dataadapter.SelectCommand = oledbCmd;

                dataset = new DataSet(); // creamos la instancia del objeto DataSet
                dataadapter.Fill(dataset, "PRODUCTOS");
                //dataadapter.Fill(dataset);//llenamos el dataset

                _DatosExcel = dataset;
                Configuracion_Grid();

                //dtgGrid.DataSource = dataset.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                Refrescar_Grid_Excel();

                conexion.Close();//cerramos la conexion
                dtgGrid.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega

                dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
                return true;
            }
            catch (Exception ex)
            {
                //en caso de haber una excepcion que nos mande un mensaje de error
                throw new Exception(ex.Message);
            }
        }
        private bool ValidaDatosExcel()
        {
            bool _resul = true;

            try
            {
                if (_DatosExcel.Tables.Count > 0)
                {
                    foreach (string _str in _ListaColumnas)
                    {

                        if (!_DatosExcel.Tables[0].Columns.Contains(_str))
                        {
                            SetMessasError("No se encontro la columna " + _str);
                            _resul = false;
                        }

                    }
                    if (_resul)
                    {
                        CargarDatos();
                        foreach (DataRow row in _DatosExcel.Tables[0].Rows)
                        {
                            ExcelProductos _Prod = new ExcelProductos();

                            //CODIGO BARRAS
                            if (row["CODIGO BARRAS"].ToString() != "")
                                _Prod.Codigo_Barras = row["CODIGO BARRAS"].ToString();
                            else
                            {
                                _resul = false;
                                SetMessasError("El Código de barras esta vacío");
                            }


                            //tbCasa_Comercial _Casa = new tbCasa_Comercial();
                            //_Casa = _dtCasa_Comercial.Find(x => x.Nombre == row["CASA COMERCIAL"].ToString());
                            //if (_Casa == null)
                            //{
                            //    _resul = false;
                            //    SetMessasError("Error con la casa comercial");
                            //}
                            //else
                            //{
                            //    _Prod.Casa_Comercial_Id = _Casa.Casa_Comercial_Id;
                            //    _Prod.Casa_Comercial_Nombre = _Casa.Nombre;
                            //}

                            tbFabricantes _Fabricante = new tbFabricantes();
                            _Fabricante = _dtFabricantes.Find(x => x.Nombre == row["FABRICANTE"].ToString());
                            if (_Fabricante == null)
                            {
                                _resul = false;
                                SetMessasError("Error con el fabricante");
                            }
                            else
                            {
                                _Prod.Fabricante_Id = _Fabricante.Fabricante_Id;
                                _Prod.Fabricante_Nombre = _Fabricante.Nombre;
                            }
                            //"PRODUCTO"
                            _Prod.Nombre = row["PRODUCTO"].ToString();
                            if (_Prod.Nombre == "")
                            {
                                _resul = false;
                                SetMessasError("El producto esta vacío");
                            }

                            tbMarcas _marcas = new tbMarcas();
                            _marcas = _dtMarcas.Find(x => x.Nombre == row["MARCA"].ToString());
                            if (_marcas == null)
                            {
                                _resul = false;
                                SetMessasError("Error con el fabricante");
                            }
                            else
                            {
                                _Prod.Marca_Id = _marcas.Marca_Id;
                                _Prod.Marca_Nombre = _marcas.Nombre;
                            }

                            //"DESCRIPCION"
                            _Prod.Descripcion = row["DESCRIPCION"].ToString();
                            if (_Prod.Descripcion == "")
                            {
                                _resul = false;
                                SetMessasError("La descipción esta vacía");
                            }

                            //"DESCRIPCION CORTA"
                            _Prod.Descripcion_Corta = row["DESCRIPCION CORTA"].ToString();
                            if (_Prod.Descripcion_Corta == "")
                            {
                                _resul = false;
                                SetMessasError("La descipción corta esta vacía");
                            }

                            //"UNDAD UNIDAD DE MEDIDA"
                            _Prod.Unidad_Medida_Id = row["UNDAD UNIDAD DE MEDIDA"].ToString();
                            if (_Prod.Unidad_Medida_Id == "")
                            {
                                _resul = false;
                                SetMessasError("La unidad de medida esta vacía");
                            }

                            //"FAMILIA"
                            tbFamilias _Familia = new tbFamilias();
                            _Familia = _dtFamilias.Find(x => x.Nombre == row["FAMILIA"].ToString());
                            if (_Familia == null)
                            {
                                _resul = false;
                                SetMessasError("Error!! No se encontro la familia");
                            }
                            else
                            {
                                _Prod.Familia_Id = _Familia.Familia_Id;
                                _Prod.Familia_Nombre = _Familia.Nombre;
                            }

                            //"CATEGORIA"
                            tbCategorias _Categoria = new tbCategorias();
                            _Categoria = _dtCategorias.Find(x => x.Nombre == row["CATEGORIA"].ToString() && x.Familia_Id == _Prod.Familia_Id);
                            if (_Categoria == null)
                            {
                                _resul = false;
                                SetMessasError("Error!! No se encontro la categoría");
                            }
                            else
                            {
                                _Prod.Categoria_Id = _Categoria.Categoria_Id;
                                _Prod.Categoria_Nombre = _Categoria.Nombre;
                            }

                            //"SUBCATEGORIA"
                            tbSubCategorias _SubCategorias = new tbSubCategorias();
                            _SubCategorias = _dtSubCategoria.Find(x => x.Nombre == row["SUBCATEGORIA"].ToString() && x.Familia_Id == _Prod.Familia_Id && x.Categoria_Id == _Prod.Categoria_Id);
                            if (_SubCategorias == null)
                            {
                                _resul = false;
                                SetMessasError("Error!! No se encontro la subcategoría");
                            }
                            else
                            {
                                _Prod.SubCategoria_Id = _SubCategorias.SubCategoria_Id;
                                _Prod.SubCategorias_Nombre = _SubCategorias.Nombre;
                            }

                            _Prod.Error = _MessasErrorValidation;

                            _ListProductos.Add(_Prod);
                        }
                    }
                    else
                        _ListProductos.Add(new ExcelProductos(_MessasErrorValidation));

                }
                return _resul;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void SetMessasError(string pStr)
        {
            if (pStr != string.Empty)
                _MessasErrorValidation = _MessasErrorValidation + pStr + " \n";
        }
        private void CargarDatos()
        {
            _dtFabricantes = _Trastienda.WebApiProductos.ListaFabricantes();
            _dtMarcas = _Trastienda.WebApiProductos.ListaMarcas();
            _dtUnidad_Medida = _Trastienda.WebApiProductos.ListaUnidad_Medida();
            _dtFamilias = _Trastienda.WebApiProductos.ListaFamilia();
            _dtCasa_Comercial = _Trastienda.WebApiProductos.ListaCasa_Comercial();
            _dtSubCategoria = _Trastienda.WebApiProductos.ListaSubCategorias(new tbSubCategorias());
            _dtCategorias = _Trastienda.WebApiProductos.ListaCategorias(new tbCategorias());
        }
        private void Configuracion_Grid()
        {
            DataTable dt = (DataTable)dtgGrid.DataSource;
            dt.Clear();

            this.dtgGrid.DataSource = null;
            this.dtgGrid = new System.Windows.Forms.DataGridView();

            this.Controls.Add(dtgGrid);

            dtgGrid.ColumnCount = 14;

            dtgGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dtgGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgGrid.ColumnHeadersDefaultCellStyle.Font = new Font(dtgGrid.Font, FontStyle.Bold);
            dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dtgGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtgGrid.GridColor = Color.Black;
            dtgGrid.RowHeadersVisible = false;


            dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dtgGrid.RowHeadersVisible = false;

            dtgGrid.Columns[_clmNum].Name = "N°";
            dtgGrid.Columns[_clmNum].Width = 30;

            int i = 0;
            foreach (DataColumn column in _DatosExcel.Tables[0].Columns)
            {
                i += 1;
                dtgGrid.Columns[i].Name = column.ColumnName;

                //dtgGrid.Columns[_clmId].Name = "Id";
                //dtgGrid.Columns[_clmId].Visible = false;
                //dtgGrid.Columns[_clmCodigo].Name = "Codigo";
                //dtgGrid.Columns[_clmNombre].Name = "Nombre";
                //dtgGrid.Columns[_clmNombre].Width = 130;
                //dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
                //dtgGrid.Columns[_clmDescripcion].Width = 150;
                //dtgGrid.Columns[_clmCasa_Comercial].Name = "Casa Comercial";
                //dtgGrid.Columns[_clmCasa_Comercial].Width = 180;
                //dtgGrid.Columns[_clmFabricante].Name = "Fabricante";
                //dtgGrid.Columns[_clmFabricante].Width = 150;
                //dtgGrid.Columns[_clmMarca].Name = "Marca";
                //dtgGrid.Columns[_clmMarca].Width = 150;
                //dtgGrid.Columns[_clmUnidad_Medida].Name = "Unidad de Medida";
                //dtgGrid.Columns[_clmUnidad_Medida].Width = 80;
                //dtgGrid.Columns[_clmContenido].Name = "Contenido";
                //dtgGrid.Columns[_clmContenido].DefaultCellStyle.Format = "#,##0.00";
                //dtgGrid.Columns[_clmContenido].Width = 80;
                //dtgGrid.Columns[_clmFamilia].Name = "Familia";
                //dtgGrid.Columns[_clmFamilia].Width = 150;
                //dtgGrid.Columns[_clmCategoria].Name = "Categoria";
                //dtgGrid.Columns[_clmCategoria].Width = 180;
                //dtgGrid.Columns[_clmSubCategoria].Name = "SubCategoria";
                //dtgGrid.Columns[_clmSubCategoria].Width = 200; 
            }
            dtgGrid.Columns[_clmError].Name = "Error";
            dtgGrid.Columns[_clmError].Width = 200;


            dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGrid.MultiSelect = false;
            dtgGrid.Refresh();
        }
        private void Refrescar_Grid_Excel()
        {
            try
            {
                dtgGrid.Rows.Clear();

                if (_ListProductos != null)
                {
                    if (_ListProductos.Count > 0)
                    {
                        int j = 1;
                        foreach (DataRow _Row in _DatosExcel.Tables[0].Rows)
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;

                            for (int y = 0; y < _DatosExcel.Tables[0].Columns.Count; y++)
                            {
                                dtgGrid.Rows[index].Cells[y + 1].Value = _Row[y];

                            }
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

                dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)                
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Problemas al cargar los productos. /n/n " + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtgGrid.Refresh();
            }
        }
        private void Refrescar_Grid()
        {
            try
            {
                dtgGrid.Rows.Clear();

                if (_ListProductos != null)
                {
                    if (_ListProductos.Count > 0)
                    {
                        int j = 1;
                        foreach (ExcelProductos _Row in _ListProductos)
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
                            dtgGrid.Rows[index].Cells[_clmError].Value = _Row.Error;

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

                dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                    //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)                
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Problemas al cargar los productos. /n/n " + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dtgGrid.Refresh();
            }
        }
        #endregion


        public class ExcelProductos : tbProductos
        {
            public string Error { get; set; }

            public ExcelProductos()
            { }

            public ExcelProductos(string pError)
            {
                Error = pError;
            }
        }
    }
}