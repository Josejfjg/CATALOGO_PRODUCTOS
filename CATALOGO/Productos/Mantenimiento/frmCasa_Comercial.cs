using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class frmCasa_Comercial : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbCasa_Comercial _Casa_Comercial;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbCasa_Comercial pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Casa_Comercial = pDatos;
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
        private void frmCasa_Comercial_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmCasa_Comercial_KeyDown(object sender, KeyEventArgs e)
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
            if (_Casa_Comercial.Casa_Comercial_Id != "")
            {
                _Modifica = true;

                txtCodigo.Text = _Casa_Comercial.Casa_Comercial_Id;
                txtCodigo.Enabled = false;
                txtNombre.Text = _Casa_Comercial.Nombre;
                txtDescripcion.Text = _Casa_Comercial.Descripcion;
                chkEstado.Checked = _Casa_Comercial.Estado;
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
            //    MessageBox.Show("Debe agregar el codigo", "Casa_Comercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCodigo.Focus();
            //}
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre", "Casa_Comercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }



            return res;
        }
        private void Llenar_Datos()
        {
            _Casa_Comercial.Casa_Comercial_Id = txtCodigo.Text;
            _Casa_Comercial.Nombre = txtNombre.Text;
            _Casa_Comercial.Descripcion = txtDescripcion.Text;
            _Casa_Comercial.Estado = chkEstado.Checked;
            _Casa_Comercial.Fecha_Crea = System.DateTime.Now;
            _Casa_Comercial.Usuario_Crea = _Trastienda.Usuario.Usuario_Id;
            _Casa_Comercial.Usuario_Modifica = _Trastienda.Usuario.Usuario_Id;
        }
        private void Guardar()
        {
            try
            {
                tbCasa_Comercial _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiProductos.ModifiarCasa_Comercial(_Casa_Comercial);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiProductos.AgregarCasa_Comercial(_Casa_Comercial);
                    }

                    if (_res != null)
                        if (_res.Casa_Comercial_Id != "")
                        {

                            MessageBox.Show("Se guardaron los datos correctamente", "Casa_Comercial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar la información" + "\n" + ex.Message, "Casa_Comercial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
