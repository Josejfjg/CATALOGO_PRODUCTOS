using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmImpuestos : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbImpuestos _Impuesto;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbImpuestos pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Impuesto = pDatos;
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
        private void frmImpuestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmImpuestos_KeyDown(object sender, KeyEventArgs e)
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
            if (_Impuesto.Impuesto_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Impuesto.Impuesto_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Impuesto.Nombre;
                txtDescripcion.Text = _Impuesto.Descripcion;
                chkEstado.Checked = _Impuesto.Estado;
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
                MessageBox.Show("Debe agregar el codigo", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Impuesto.Impuesto_Id = txtCodigo.Text;
            _Impuesto.Nombre = txtNombre.Text;
            _Impuesto.Descripcion = txtDescripcion.Text;
            _Impuesto.Estado = chkEstado.Checked;
            _Impuesto.Fecha_Crea = System.DateTime.Now;
            _Impuesto.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Impuesto.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbImpuestos _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarImpuesto(_Impuesto);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarImpuesto(_Impuesto);
                    }

                    if (_res != null)
                        if (_res.Impuesto_Id != "")
                        {
                            MessageBox.Show("Se guardaron los datos correctamente", "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar la información" + "\n" + ex.Message, "Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
