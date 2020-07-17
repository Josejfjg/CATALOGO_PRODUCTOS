using CATALOGO.CatalogoObj;
using CATALOGO.Productos;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmPrincipal : Form
    {
        #region "Variables de ventanas"
        private frmLista_Productos _frmLista_Productos;
        private frmLista_Categorias _frmLista_Categorias;
        private frmLista_Fabricantes _frmLista_Fabricantes;
        private frmLista_Familias _frmLista_Familias;
        private frmLista_Marcas _frmLista_Marcas;
        private frmLista_Unidad_Medidas _frmLista_Unidad_Medidas;
        private frmLista_Impuestos _frmLista_Impuestos;
        private frmLista_Usuarios _frmLista_Usuarios;
        private frmLista_Casa_Comercial _frmLista_Casa_Comercial;
        private rptProductos_X_Categoria _rptProductos_X_Categoria;
        private rptProductos_Nuevos _rptProductos_Nuevos;
        private rptCatalogos _rptCatalogos;
        private rptProductos_X_Proveedor _rptProductos_X_Proveedor;
        #endregion

        #region "Variables Locales"
        private bool _Salir;
        private TTrastienda _Trastienda;
        #endregion

        public bool Execute(TTrastienda pTrastienda)
        {
            _Trastienda = pTrastienda;
            _Salir = true;
            toolEstado.Text = _Trastienda.Usuario.Nombre;
            ShowDialog();

            return _Salir;
        }

        private void Inicializa_Pantalla()
        {
            InitializeComponent();
        }



        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Inicia_Ventana(Form pForm)
        {
            pForm.WindowState = FormWindowState.Maximized;
            //pForm.Icon = New Icon(obtenerResource(My.Application.Info.AssemblyName & ".box.ico"));
            pForm.ShowIcon = true;

        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opmProductos_Click(object sender, EventArgs e)
        {
            if (_frmLista_Productos != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Productos.Salir)               //Se libera la instancia
                {
                    _frmLista_Productos.Dispose();
                    _frmLista_Productos = null;
                }
            }
            if (_frmLista_Productos == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Productos = new frmLista_Productos();          // Se crea una
                _frmLista_Productos.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Productos);
                _frmLista_Productos.Execute(_Trastienda);
            }
            else
                _frmLista_Productos.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void tsLista_Productos_Click(object sender, EventArgs e)
        {
            opmProductos_Click(null, null);
        }

        private void opmCategorias_Click(object sender, EventArgs e)
        {
            if (_frmLista_Categorias != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Categorias.Salir)               //Se libera la instancia
                {
                    _frmLista_Categorias.Dispose();
                    _frmLista_Categorias = null;
                }
            }
            if (_frmLista_Categorias == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Categorias = new frmLista_Categorias();          // Se crea una
                _frmLista_Categorias.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Categorias);
                _frmLista_Categorias.Execute(_Trastienda);
            }
            else
                _frmLista_Categorias.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmFabricantes_Click(object sender, EventArgs e)
        {
            if (_frmLista_Fabricantes != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Fabricantes.Salir)               //Se libera la instancia
                {
                    _frmLista_Fabricantes.Dispose();
                    _frmLista_Fabricantes = null;
                }
            }
            if (_frmLista_Fabricantes == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Fabricantes = new frmLista_Fabricantes();          // Se crea una
                _frmLista_Fabricantes.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Fabricantes);
                _frmLista_Fabricantes.Execute(_Trastienda);
            }
            else
                _frmLista_Fabricantes.Activate();// si ya había una ventana abierta, solo se activa   
        }
        private void opmFamilias_Click(object sender, EventArgs e)
        {
            if (_frmLista_Familias != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Familias.Salir)               //Se libera la instancia
                {
                    _frmLista_Familias.Dispose();
                    _frmLista_Familias = null;
                }
            }
            if (_frmLista_Familias == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Familias = new frmLista_Familias();          // Se crea una
                _frmLista_Familias.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Familias);
                _frmLista_Familias.Execute(_Trastienda);
            }
            else
                _frmLista_Familias.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmMarcas_Click(object sender, EventArgs e)
        {
            if (_frmLista_Marcas != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Marcas.Salir)               //Se libera la instancia
                {
                    _frmLista_Marcas.Dispose();
                    _frmLista_Marcas = null;
                }
            }
            if (_frmLista_Marcas == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Marcas = new frmLista_Marcas();          // Se crea una
                _frmLista_Marcas.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Marcas);
                _frmLista_Marcas.Execute(_Trastienda);
            }
            else
                _frmLista_Marcas.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmUnidadDeMedida_Click(object sender, EventArgs e)
        {
            if (_frmLista_Unidad_Medidas != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Unidad_Medidas.Salir)               //Se libera la instancia
                {
                    _frmLista_Unidad_Medidas.Dispose();
                    _frmLista_Unidad_Medidas = null;
                }
            }
            if (_frmLista_Unidad_Medidas == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Unidad_Medidas = new frmLista_Unidad_Medidas();          // Se crea una
                _frmLista_Unidad_Medidas.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Unidad_Medidas);
                _frmLista_Unidad_Medidas.Execute(_Trastienda);
            }
            else
                _frmLista_Unidad_Medidas.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmImpuestos_Click(object sender, EventArgs e)
        {
            if (_frmLista_Impuestos != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Impuestos.Salir)               //Se libera la instancia
                {
                    _frmLista_Impuestos.Dispose();
                    _frmLista_Impuestos = null;
                }
            }
            if (_frmLista_Impuestos == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Impuestos = new frmLista_Impuestos();          // Se crea una
                _frmLista_Impuestos.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Impuestos);
                _frmLista_Impuestos.Execute(_Trastienda);
            }
            else
                _frmLista_Impuestos.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmUsuarios_Click(object sender, EventArgs e)
        {
            if (_frmLista_Usuarios != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Usuarios.Salir)               //Se libera la instancia
                {
                    _frmLista_Usuarios.Dispose();
                    _frmLista_Usuarios = null;
                }
            }
            if (_frmLista_Usuarios == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Usuarios = new frmLista_Usuarios();          // Se crea una
                _frmLista_Usuarios.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Usuarios);
                _frmLista_Usuarios.Execute(_Trastienda);
            }
            else
                _frmLista_Usuarios.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmCasaComercial_Click(object sender, EventArgs e)
        {
            if (_frmLista_Casa_Comercial != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_frmLista_Casa_Comercial.Salir)               //Se libera la instancia
                {
                    _frmLista_Casa_Comercial.Dispose();
                    _frmLista_Casa_Comercial = null;
                }
            }
            if (_frmLista_Casa_Comercial == null)                 //Si no hay instancias de la ventana
            {
                _frmLista_Casa_Comercial = new frmLista_Casa_Comercial();          // Se crea una
                _frmLista_Casa_Comercial.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_frmLista_Casa_Comercial);
                _frmLista_Casa_Comercial.Execute(_Trastienda);
            }
            else
                _frmLista_Casa_Comercial.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmProductosNuevos_Click(object sender, EventArgs e)
        {
            if (_rptProductos_Nuevos != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_rptProductos_Nuevos.Salir)               //Se libera la instancia
                {
                    _rptProductos_Nuevos.Dispose();
                    _rptProductos_Nuevos = null;
                }
            }
            if (_rptProductos_Nuevos == null)                 //Si no hay instancias de la ventana
            {
                _rptProductos_Nuevos = new rptProductos_Nuevos();          // Se crea una
                _rptProductos_Nuevos.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_rptProductos_Nuevos);
                _rptProductos_Nuevos.Execute(_Trastienda);
            }
            else
                _rptProductos_X_Categoria.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmProductosPorCategoría_Click(object sender, EventArgs e)
        {  
            if (_rptProductos_X_Categoria != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_rptProductos_X_Categoria.Salir)               //Se libera la instancia
                {
                    _rptProductos_X_Categoria.Dispose();
                    _rptProductos_X_Categoria = null;
                }
            }
            if (_rptProductos_X_Categoria == null)                 //Si no hay instancias de la ventana
            {
                _rptProductos_X_Categoria = new rptProductos_X_Categoria();          // Se crea una
                _rptProductos_X_Categoria.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_rptProductos_X_Categoria);
                _rptProductos_X_Categoria.Execute(_Trastienda);
            }
            else
                _rptProductos_X_Categoria.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmCategorias_Todas_Click(object sender, EventArgs e)
        {
            if (_rptCatalogos != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_rptCatalogos.Salir)               //Se libera la instancia
                {
                    _rptCatalogos.Dispose();
                    _rptCatalogos = null;
                }
            }
            if (_rptCatalogos == null)                 //Si no hay instancias de la ventana
            {
                _rptCatalogos = new rptCatalogos();          // Se crea una
                _rptCatalogos.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_rptCatalogos);
                _rptCatalogos.Execute(_Trastienda);
            }
            else
                _rptCatalogos.Activate();// si ya había una ventana abierta, solo se activa   
        }

        private void opmCostoPorProveedor_Click(object sender, EventArgs e)
        {
            if (_rptProductos_X_Proveedor != null)                //Si hay una instancia
            {                                               //Y la ventana ya se cerró 
                if (_rptProductos_X_Proveedor.Salir)               //Se libera la instancia
                {
                    _rptProductos_X_Proveedor.Dispose();
                    _rptProductos_X_Proveedor = null;
                }
            }
            if (_rptProductos_X_Proveedor == null)                 //Si no hay instancias de la ventana
            {
                _rptProductos_X_Proveedor = new rptProductos_X_Proveedor();          // Se crea una
                _rptProductos_X_Proveedor.MdiParent = this;       // Se le indica el form padre
                Inicia_Ventana(_rptProductos_X_Proveedor);
                _rptProductos_X_Proveedor.Execute(_Trastienda);
            }
            else
                _rptProductos_X_Proveedor.Activate();// si ya había una ventana abierta, solo se activa   
        }
    }
}
