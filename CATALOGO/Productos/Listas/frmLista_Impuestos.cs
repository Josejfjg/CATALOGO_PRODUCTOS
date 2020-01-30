using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmLista_Impuestos : Form
    {
        private bool _Salir;
        private List<tbImpuestos> _DTImpuestos;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmCodigo = 1;
        private const int _clmNombre = 2;
        private const int _clmDescripcion = 3;
        private const int _clmEstado = 4;


        public bool Salir { get => _Salir; set => _Salir = value; }
        public frmLista_Impuestos()
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
            this.dtgGrid.ColumnCount = 4;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmNum].Width = 30;
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmNombre].Width = 400;
            this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            this.dtgGrid.Columns[_clmDescripcion].Width = 800;

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.HeaderText = "Estado";
            this.dtgGrid.Columns.Add(col1);

            this.dtgGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrid.MultiSelect = false;
            this.dtgGrid.Refresh();
        }

        private void Refrescar_Grid()
        {
            try
            {
                _DTImpuestos = _Trastienda.WebApiProductos.ListaImpuestos();
                List<tbImpuestos> _Datos = _DTImpuestos;
                if (txtCodigo.Text != "")
                {
                    _Datos = _DTImpuestos.Where(x => x.Impuesto_Id == Convert.ToString(txtCodigo.Text)).ToList();
                }
                if (txtNombre.Text != "")
                {
                    _Datos = _DTImpuestos.Where(x => x.Nombre == Convert.ToString(txtNombre.Text)).ToList();
                }
                dtgGrid.Rows.Clear();

                if (_Datos != null)
                {
                    if (_Datos.Count > 0)
                    {
                        int j = 1;
                        foreach (tbImpuestos _Row in _Datos)
                        {

                            var index = dtgGrid.Rows.Add();
                            dtgGrid.Rows[index].Cells[_clmNum].Value = j;
                            dtgGrid.Rows[index].Cells[_clmNum].Tag = j - 1;
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.Impuesto_Id;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado;
                            dtgGrid.AutoGenerateColumns = true;
                            j++;
                        }
                    }
                    else
                        MessageBox.Show("No se encontraron datos", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.dtgGrid.Refresh();

            }
            catch (Exception ex)
            {
                this.dtgGrid.Refresh();
            }
        }

        private void Eliminar_Impuesto()
        {
            try
            {
                if (dtgGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dtgGrid.SelectedRows[0];
                    tbImpuestos pro = new tbImpuestos();

                    pro.Impuesto_Id = row.Cells[_clmCodigo].Value.ToString();

                    if (MessageBox.Show("Esta seguro que quiere eliminar los datos", "Impuestos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_Trastienda.WebApiProductos.EliminarImpuesto(pro.Impuesto_Id))
                            MessageBox.Show("Se eliminaron los datos correctamente", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Se produjo un error al eliminar los datos", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Buscar();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar una linea", "Lista Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar los datos" + "\n" + ex.Message, "Lista Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Bn_Agregar_Click(object sender, EventArgs e)
        {
            frmImpuestos frm = new frmImpuestos();
            if (frm.Execute(_Trastienda, new tbImpuestos()))
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
                    tbImpuestos pro = new tbImpuestos();

                    pro.Impuesto_Id = row.Cells[_clmCodigo].Value.ToString();
                    pro.Nombre = row.Cells[_clmNombre].Value.ToString();
                    pro.Descripcion = row.Cells[_clmDescripcion].Value.ToString();
                    pro.Estado = Convert.ToBoolean(row.Cells[_clmEstado].Value);

                    frmImpuestos frm = new frmImpuestos();
                    if (frm.Execute(_Trastienda, pro))
                        Refrescar_Grid();
                    else
                        Refrescar_Grid();
                }
                else
                {
                    MessageBox.Show("Bede seleccionar una linea", "Lista Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error iniciar la pantalla " + "\n" + ex.Message, "Lista Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Bn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Impuesto();
        }

        private void frmLista_Impuestos_KeyDown(object sender, KeyEventArgs e)
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
                    Eliminar_Impuesto();
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }

        private void frmLista_Impuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = true;
        }
    }
}
