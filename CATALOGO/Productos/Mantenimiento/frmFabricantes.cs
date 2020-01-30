using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmFabricantes : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbFabricantes _Fabricante;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbFabricantes pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Fabricante = pDatos;
            _Salir = false;
            Limpiar_Pantalla();
            CargarDatos();
            this.ShowDialog();
            return _Salir;
        }

        #endregion

        #region "Eventos"
        private void Bn_Salir_Click(object sender, EventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void frmFabricantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmFabricantes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Guardar();
                    break;
                case Keys.Escape:
                    Bn_Salir_Click(null, null);
                    break;
            }
        }
        #endregion

        #region "Metodos Privados"
        private void Inicializa_Pantalla()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            if (_Fabricante.Fabricante_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Fabricante.Fabricante_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Fabricante.Nombre;
                txtDescripcion.Text = _Fabricante.Descripcion;
                chkEstado.Checked = _Fabricante.Estado;
            }

        }
        private void Limpiar_Pantalla()
        {
            _Modifica = false;
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = true;
        }
        private bool Validar_Datos()
        {
            bool res = true;
            if (txtCodigo.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el codigo del fabricante", "Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre del fabricante", "Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Fabricante.Fabricante_Id = txtCodigo.Text;
            _Fabricante.Nombre = txtNombre.Text;
            _Fabricante.Descripcion = txtDescripcion.Text;
            _Fabricante.Estado = chkEstado.Checked;
            _Fabricante.Fecha_Crea = System.DateTime.Now;
            _Fabricante.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Fabricante.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbFabricantes _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarFabricante(_Fabricante);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarFabricante(_Fabricante);
                    }

                    if (_res != null)
                        if (_res.Fabricante_Id != "")
                        {
                            MessageBox.Show("Se guardo el fabricante correctamente", "Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar el fabricante" + "\n" + ex.Message, "Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
