using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmMarcas : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbMarcas _Marca;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbMarcas pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Marca = pDatos;
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
        private void frmMarcas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmMarcas_KeyDown(object sender, KeyEventArgs e)
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
            if (_Marca.Marca_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Marca.Marca_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Marca.Nombre;
                txtDescripcion.Text = _Marca.Descripcion;
                chkEstado.Checked = _Marca.Estado;
            }

        }
        private void Limpiar_Pantalla()
        {
            _Modifica = false;
            txtCodigo.Text = "";
            //txtCodigo.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = true;
        }
        private bool Validar_Datos()
        {
            bool res = true;
            //if (txtCodigo.Text == "")
            //{
            //    res = false;
            //    MessageBox.Show("Debe agregar el codigo", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCodigo.Focus();
            //}
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Marca.Marca_Id = txtCodigo.Text;
            _Marca.Nombre = txtNombre.Text;
            _Marca.Descripcion = txtDescripcion.Text;
            _Marca.Estado = chkEstado.Checked;
            _Marca.Fecha_Crea = System.DateTime.Now;
            _Marca.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Marca.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbMarcas _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarMarca(_Marca);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarMarca(_Marca);
                    }

                    if (_res != null)
                        if (_res.Marca_Id != "")
                        {
                            txtCodigo.Text = _res.Marca_Id;
                            MessageBox.Show("Se guardaron los datos correctamente", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar la información" + "\n" + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
