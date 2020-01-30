using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmFamilias : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbFamilias _Familia;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbFamilias pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Familia = pDatos;
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
        private void frmFamilias_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmFamilias_KeyDown(object sender, KeyEventArgs e)
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
            if (_Familia.Familia_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Familia.Familia_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Familia.Nombre;
                txtDescripcion.Text = _Familia.Descripcion;
                chkEstado.Checked = _Familia.Estado;
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
                MessageBox.Show("Debe agregar el codigo de la familia", "Familias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre de la familia", "Familias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Familia.Familia_Id = txtCodigo.Text;
            _Familia.Nombre = txtNombre.Text;
            _Familia.Descripcion = txtDescripcion.Text;
            _Familia.Estado = chkEstado.Checked;
            _Familia.Fecha_Crea = System.DateTime.Now;
            _Familia.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Familia.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbFamilias _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarFamilia(_Familia);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarFamilia(_Familia);
                    }

                    if (_res != null)
                        if (_res.Familia_Id != "")
                        {
                            MessageBox.Show("Se guardo la familia correctamente", "Familias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar la familia" + "\n" + ex.Message, "Familias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
