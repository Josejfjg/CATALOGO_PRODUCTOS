using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class rptCatalogos : Form
    {
        private bool _Salir;
        private List<tbCategorias> _DTCategorias;
        private List<tbFamilias> _dtFamilias;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmFamilia_Id = 1;
        private const int _clmFamilia_Nombre = 2;
        private const int _clmCategoria_Id = 3;
        private const int _clmCategoria_Nombre = 4;
        private const int _clmSubCategoria_Id = 5;
        private const int _clmSubCategoria_Nombre = 6;


        public bool Salir { get => _Salir; set => _Salir = value; }
        public rptCatalogos()
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

        private void Inicializa_Pantalla()
        {
            Configuracion_Grid();
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 7;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmFamilia_Id].Name = "Código Familia";
            this.dtgGrid.Columns[_clmFamilia_Nombre].Name = "Familia";
            this.dtgGrid.Columns[_clmCategoria_Id].Name = "Código Categoría";
            this.dtgGrid.Columns[_clmCategoria_Nombre].Name = "Categoría";
            this.dtgGrid.Columns[_clmSubCategoria_Id].Name = "Código SubCategoría";
            this.dtgGrid.Columns[_clmSubCategoria_Nombre].Name = "SubCategoría";

            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;
            dtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                //columnas al ancho del DataGridview para que no quede espacio en blanco
            this.dtgGrid.Refresh();
        }
        private void Refrescar_Grid()
        {
            try
            {
                List<tbSubCategorias> _Datos = new List<tbSubCategorias>();

                dtgGrid.Rows.Clear();
                tbSubCategorias _tb = new tbSubCategorias();
                _tb.Familia_Id = "";
                _tb.Categoria_Id = "";
                _tb.SubCategoria_Id = "";
                _Datos = _Trastienda.WebApiProductos.ListaSubCategorias(_tb);

                if (_Datos != null)
                {
                    if (_Datos.Count > 0)
                    {
                        int j = 1;
                        foreach (tbSubCategorias _Row in _Datos)
                        {

                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmFamilia_Id].Value = _Row.Familia_Id;
                            dtgGrid.Rows[index].Cells[_clmFamilia_Nombre].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCategoria_Id].Value = _Row.Categoria_Id;
                            dtgGrid.Rows[index].Cells[_clmCategoria_Nombre].Value = _Row.Categoria_Nombre;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria_Id].Value = _Row.SubCategoria_Id;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria_Nombre].Value = _Row.Nombre;

                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                    else
                        MessageBox.Show("No se encontraron datos", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid.Refresh();
            }
        }
        private void Buscar()
        {
            Refrescar_Grid();
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
        private void frmLista_Categorias_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Buscar();
                    break;
                case Keys.F2:
                    Bn_Exportar_Click(null, null);
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }
        private void frmLista_Categorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = true;
        }
        private void Bn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Exportar_Excel_DataGrid(dtgGrid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Problemas al exportar. /n/n " + ex.Message, "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
