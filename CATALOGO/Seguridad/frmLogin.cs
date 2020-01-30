using CATALOGO.CatalogoObj;
using System;
using System.Windows.Forms;
namespace CATALOGO.Seguridad
{
    public partial class frmLogin : Form
    {
        #region "Variables de ventanas"      
        private TTrastienda _Trastienda;
        #endregion

        #region "Variables Locales"
        private int childFormNumber = 0;
        private bool _Salir;
        #endregion

        public bool Execute(TTrastienda pTrastienda)
        {
            _Trastienda = pTrastienda;
            _Salir = true;
            txtContrasena.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
            this.ActiveControl = txtUsuario;
            this.ShowDialog();
            return _Salir;
        }


        public frmLogin()
        {
            InitializeComponent();
        }
        #region "Eventos"

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Validar();
        }
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            frmLogin_KeyDown(null, e);
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                btnSalir_Click(null, null);
            }
            else if (e.KeyData == Keys.Enter && this.txtUsuario.Text == "")
            {
                txtUsuario.Focus();
            }
            else if (e.KeyData == Keys.Enter && this.txtContrasena.Text == "")
            {
                txtContrasena.Focus();
            }
            else if (e.KeyData == Keys.Enter)
            {
                Validar();
            }
        }
        #endregion

        private void Validar()
        {
            try
            {
                //_Trastienda.Usuario = _Trastienda.WebApiSeguridad.Valida_Usuarios(txtUsuario.Text, ClsSeguridad.GetSHA256(txtContrasena.Text));
                _Trastienda.Usuario = _Trastienda.WebApiSeguridad.Valida_Usuarios(txtUsuario.Text, txtContrasena.Text);

                if (_Trastienda.Usuario != null)
                {
                    if (_Trastienda.Usuario.Usuario_Id > 0)
                    {
                        _Salir = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Los datos digitados no son válidos");
                        txtUsuario.SelectAll();
                        txtContrasena.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Los datos digitados no son válidos");
                    txtUsuario.SelectAll();
                    txtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
