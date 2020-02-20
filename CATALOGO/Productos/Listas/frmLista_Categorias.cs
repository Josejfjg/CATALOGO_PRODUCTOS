using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmLista_Categorias : Form
    {
        private bool _Salir;
        private List<tbCategorias> _DTCategorias;
        private List<tbFamilias> _dtFamilias;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmFamilia = 1;
        private const int _clmCodigo = 2;
        private const int _clmNombre = 3;
        private const int _clmDescripcion = 4;
        private const int _clmEstado = 5;
        private const int _clmFamilia_Id = 6;


        public bool Salir { get => _Salir; set => _Salir = value; }
        public frmLista_Categorias()
        {
            InitializeComponent();
        }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda)
        {
            _Trastienda = pTrastienda;
            Inicializa_Pantalla();
            CargarCombos();
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
            this.dtgGrid.ColumnCount = 6;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmFamilia].Name = "Familia";
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].Width = 400;
            this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            this.dtgGrid.Columns[_clmDescripcion].Width = 800;

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Estado";
            this.dtgGrid.Columns.Add(col1);

            this.dtgGrid.Columns[_clmFamilia_Id].Name = "Familia_Id";
            this.dtgGrid.Columns[_clmFamilia_Id].Visible = false;

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
                tbCategorias _tbC = new tbCategorias();
                List<tbCategorias> _Datos = new List<tbCategorias>();
                if (chkTodas.Checked)
                {
                    _tbC.Familia_Id = "";
                }
                else
                {
                    _tbC.Familia_Id = cmbFamilia.SelectedValue.ToString();
                }
                if (txtCodigo.Text != "")
                {
                    _tbC.Categoria_Id = txtCodigo.Text;
                }
                if (txtNombre.Text != "")
                {
                    _tbC.Nombre = txtNombre.Text;
                }

                dtgGrid.Rows.Clear();
                _Datos = _Trastienda.WebApiProductos.ListaCategorias(_tbC);

                if (_Datos != null)
                {
                    if (_Datos.Count > 0)
                    {
                        int j = 1;
                        foreach (tbCategorias _Row in _Datos)
                        {

                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmFamilia].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.Categoria_Id;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado;
                            dtgGrid.Rows[index].Cells[_clmFamilia_Id].Value = _Row.Familia_Id;
                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                    else
                        MessageBox.Show("No se encontraron Categorias", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron Categorias", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid.Refresh();
            }
        }
        private void Eliminar_Categoria()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    tbCategorias pro = new tbCategorias();

                    pro.Familia_Id = row.Cells[_clmFamilia_Id].Value.ToString();
                    pro.Categoria_Id = row.Cells[_clmCodigo].Value.ToString();

                    if (MessageBox.Show("Esta seguro que quiere eliminar el Categoria", "Categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tbSubCategorias _Sub = new tbSubCategorias();
                        _Sub.Familia_Id = pro.Familia_Id;
                        _Sub.Categoria_Id = pro.Categoria_Id;
                        List<tbSubCategorias> _SubCategoria = _Trastienda.WebApiProductos.ListaSubCategorias_X_Categoria(_Sub);
                        if (_SubCategoria != null)
                        {
                            if (_SubCategoria.Count > 0)
                            {
                                MessageBox.Show("Se debe elinar las subCategorias primero", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        if (_Trastienda.WebApiProductos.EliminarCategoria(pro))
                            MessageBox.Show("Se elimino el Categoria correctamente", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Se produjo un error al eliminar el Categoria", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Buscar();
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
            frmCategorias frm = new frmCategorias();
            if (frm.Execute(_Trastienda, new tbCategorias()))
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
                    tbCategorias pro = new tbCategorias();

                    pro.Familia_Id = row.Cells[_clmFamilia_Id].Value.ToString();
                    pro.Categoria_Id = row.Cells[_clmCodigo].Value.ToString();
                    pro.Nombre = row.Cells[_clmNombre].Value.ToString();
                    pro.Descripcion = row.Cells[_clmDescripcion].Value.ToString();
                    pro.Estado = Convert.ToBoolean(row.Cells[_clmEstado].Value);

                    frmCategorias frm = new frmCategorias();
                    if (frm.Execute(_Trastienda, pro))
                        Refrescar_Grid();
                    else
                        Refrescar_Grid();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar un Categoria", "Lista Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error iniciar la pantalla " + "\n" + ex.Message, "Lista Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Bn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Categoria();
        }
        private void frmLista_Categorias_KeyDown(object sender, KeyEventArgs e)
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
                    Eliminar_Categoria();
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

        private void chkTodas_CheckedChanged(object sender, EventArgs e)
        {
            cmbFamilia.Enabled = !chkTodas.Checked;
            Refrescar_Grid();
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refrescar_Grid();
        }
    }
}
