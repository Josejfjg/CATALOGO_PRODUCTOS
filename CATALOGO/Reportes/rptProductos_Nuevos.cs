﻿using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CATALOGO.Productos
{
    public partial class rptProductos_Nuevos : Form
    {
        private bool _Salir;
        private List<tbProductos> _DTProductos;
        private TTrastienda _Trastienda;
        private const int _clmNum = 0;
        private const int _clmCodigo = 1;
        private const int _clmNombre = 2;
        private const int _clmDescripcion = 3;
        private const int _clmFabricante = 4;
        private const int _clmMarca = 5;
        private const int _clmUnidad_Medida = 6;
        private const int _clmContenido = 7;
        private const int _clmCompuesto = 8;
        private const int _clmFamilia = 9;
        private const int _clmCategoria = 10;
        private const int _clmSubCategoria = 11;
        private const int _clmEstado = 12;
        private const int _clmCreado = 13;
        private const int _clmUsuario_Crea = 14;
        private const int _clmModificado = 15;
        private const int _clmusuario_Modifica = 16;

        public bool Salir { get => _Salir; set => _Salir = value; }
        public rptProductos_Nuevos()
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
        }
        private void Configuracion_Grid()
        {
            this.dtgGrid.ColumnCount = 17;

            this.dtgGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgGrid.RowHeadersVisible = false;

            this.dtgGrid.Columns[_clmNum].Name = "N°";
            this.dtgGrid.Columns[_clmCodigo].Name = "Codigo";
            this.dtgGrid.Columns[_clmNombre].Name = "Nombre";
            this.dtgGrid.Columns[_clmDescripcion].Name = "Descripcion";
            this.dtgGrid.Columns[_clmFabricante].Name = "Fabricante";
            this.dtgGrid.Columns[_clmMarca].Name = "Marca";
            this.dtgGrid.Columns[_clmUnidad_Medida].Name = "Unidad de Medida";
            this.dtgGrid.Columns[_clmContenido].Name = "Contenido";
            this.dtgGrid.Columns[_clmContenido].DefaultCellStyle.Format = "#,##0.00";
            this.dtgGrid.Columns[_clmCompuesto].Name = "Descripcion Compuesta";
            this.dtgGrid.Columns[_clmFamilia].Name = "Familia";
            this.dtgGrid.Columns[_clmCategoria].Name = "Categoria";
            this.dtgGrid.Columns[_clmSubCategoria].Name = "SubCategoria";
            this.dtgGrid.Columns[_clmEstado].Name = "Estado";
            this.dtgGrid.Columns[_clmCreado].Name = "Creado";
            this.dtgGrid.Columns[_clmUsuario_Crea].Name = "Usuario Crea";
            this.dtgGrid.Columns[_clmModificado].Name = "Modificado";
            this.dtgGrid.Columns[_clmusuario_Modifica].Name = "Usuario Modifica";

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
                _filtros.Fecha_Inicio = dtpFecha_Inicio.Value;
                _filtros.Fecha_Fin = dtpFecha_Fin.Value;
                _DTProductos = _Trastienda.WebApiProductos.ListaProductos_Nuevos(_filtros);               
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
                            dtgGrid.Rows[index].Cells[_clmCodigo].Value = _Row.Codigo_Barras;
                            dtgGrid.Rows[index].Cells[_clmNombre].Value = _Row.Nombre;
                            dtgGrid.Rows[index].Cells[_clmDescripcion].Value = _Row.Descripcion;
                            dtgGrid.Rows[index].Cells[_clmFabricante].Value = _Row.Fabricante_Nombre;
                            dtgGrid.Rows[index].Cells[_clmMarca].Value = _Row.Marca_Nombre;
                            dtgGrid.Rows[index].Cells[_clmUnidad_Medida].Value = _Row.Unidad_Medida_Nombre;
                            dtgGrid.Rows[index].Cells[_clmContenido].Value = _Row.Contenido;
                            dtgGrid.Rows[index].Cells[_clmFamilia].Value = _Row.Familia_Nombre;
                            dtgGrid.Rows[index].Cells[_clmCategoria].Value = _Row.Categoria_Nombre;
                            dtgGrid.Rows[index].Cells[_clmSubCategoria].Value = _Row.SubCategorias_Nombre;
                            dtgGrid.Rows[index].Cells[_clmEstado].Value = _Row.Estado ? "Activo" : "Inactivo";
                            dtgGrid.Rows[index].Cells[_clmCreado].Value = _Row.Fecha_Crea.ToString("dd/MM/yyyy");
                            dtgGrid.Rows[index].Cells[_clmUsuario_Crea].Value = _Row.Usuario_Crea_Nombre;
                            dtgGrid.Rows[index].Cells[_clmModificado].Value = _Row.Fecha_Modifica.ToString("dd/MM/yyyy") == "01/01/1900" ? "": _Row.Fecha_Modifica.ToString("dd/MM/yyyy");
                            dtgGrid.Rows[index].Cells[_clmusuario_Modifica].Value = _Row.Usuario_Modifica_Nombre;
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
        private void Buscar()
        {
            Refrescar_Grid();
        }

        #endregion

        #region "Eventos"       
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

        #endregion

     
    }
}
