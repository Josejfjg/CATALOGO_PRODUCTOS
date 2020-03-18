using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmUnidad_Medidas : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbUnidad_Medida _Unidad_Medida;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbUnidad_Medida pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Unidad_Medida = pDatos;
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
        private void frmUnidad_Medidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmUnidad_Medidas_KeyDown(object sender, KeyEventArgs e)
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
            if (_Unidad_Medida.Unidad_Medida_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Unidad_Medida.Unidad_Medida_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Unidad_Medida.Nombre;
                txtDescripcion.Text = _Unidad_Medida.Descripcion;
                chkEstado.Checked = _Unidad_Medida.Estado;
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
            //    MessageBox.Show("Debe agregar el codigo", "Unidad_Medidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCodigo.Focus();
            //}
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre", "Unidad_Medidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Unidad_Medida.Unidad_Medida_Id = txtCodigo.Text;
            _Unidad_Medida.Nombre = txtNombre.Text;
            _Unidad_Medida.Descripcion = txtDescripcion.Text;
            _Unidad_Medida.Estado = chkEstado.Checked;
            _Unidad_Medida.Fecha_Crea = System.DateTime.Now;
            _Unidad_Medida.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Unidad_Medida.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbUnidad_Medida _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarUnidad_Medida(_Unidad_Medida);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarUnidad_Medida(_Unidad_Medida);
                    }

                    if (_res != null)
                        if (_res.Unidad_Medida_Id != "")
                        {
                            txtCodigo.Text = _res.Unidad_Medida_Id;
                            MessageBox.Show("Se guardaron los datos correctamente", "Unidad_Medidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar la información" + "\n" + ex.Message, "Unidad_Medidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
