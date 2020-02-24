using CATALOGO.CatalogoObj;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmBuscar : Form
    {
        #region "Variables privadas"
        private bool _Salir;
        private string _Codigo;
        private string _Nombre;

        private DataTable _Datos;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmCodigo = 1;
        private const int _clmNombre = 2;
        #endregion

        #region "Variables publicas"
        public bool Salir { get => _Salir; set => _Salir = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        #endregion

        #region "Constructor"
        public frmBuscar()
        {
            InitializeComponent();
        }
        #endregion

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, DataTable pDataTable)
        {
            _Datos = new DataTable();
            _Codigo = "";
            _Nombre = "";
            _Salir = false;

            _Trastienda = pTrastienda;
            _Datos = pDataTable;
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
            this.dtgGrid.ColumnCount = 3;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;
            this.dtgGrid.Refresh();
        }
        private void Refrescar_Grid()
        {
            try
            {
                if (_Datos != null)
                {
                    if (_Datos.Rows.Count > 0)
                    {
                        dtgGrid.Rows.Clear();

                        int j = 1;
                        foreach (DataRow _Row in _Datos.Select().Where(x => x["Codigo"].ToString().ToUpper().Contains(Convert.ToString(txtCodigo.Text.ToUpper())) &&
                                                                 x["Nombre"].ToString().ToUpper().Contains(Convert.ToString(txtNombre.Text.ToUpper()))).ToList())
                        {
                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row["Codigo"];
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row["Nombre"];
                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                    else
                        MessageBox.Show("No se encontraron datos", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid.Refresh();
                throw new Exception(ex.Message);

            }
        }
        private void Buscar()
        {
            Refrescar_Grid();
        }
        private void Seleccionar()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    _Codigo = row.Cells[_clmCodigo].Value.ToString();
                    _Nombre = row.Cells[_clmNombre].Value.ToString();
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
        private void frmBuscar_KeyDown(object sender, KeyEventArgs e)
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
        //private void frmBuscar_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    _Salir = false;
        //}
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
