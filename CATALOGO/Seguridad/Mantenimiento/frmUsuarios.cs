using CATALOGO.CatalogoObj;
using CATALOGOOBJ;
using System;
using System.Windows.Forms;


namespace CATALOGO
{
    public partial class frmUsuarios : Form
    {
        private bool _Salir = false;
        private bool _Modifica = false;

        private TTrastienda _Trastienda;
        private tbUsuario _Usuario;

        public bool Salir { get => _Salir; set => _Salir = value; }

        #region "Método Execute"
        public bool Execute(TTrastienda pTrastienda, tbUsuario pDatos)
        {
            Inicializa_Pantalla();
            _Trastienda = pTrastienda;
            _Usuario = pDatos;
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
        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Salir = false;
            this.Close();
        }
        private void Bn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
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
            try
            {
                dtpFechaExpira.MinDate = System.DateTime.Now;
                if (_Usuario.Usuario_Id > 0)
                {
                    _Usuario = _Trastienda.WebApiSeguridad.ListUsuario(_Usuario);
                    _Modifica = true;

                    txtCodigo.Text = _Usuario.Usuario_Id.ToString();
                    txtCodigo.Enabled = false;
                    txtNombre.Text = _Usuario.Nombre;
                    txtCorreo.Text = _Usuario.Correo;
                    txtLogin.Text = _Usuario.Login;
                    txtContrasena.Text = _Usuario.Password;
                    chkEstado.Checked = _Usuario.Estado;
                    dtpFechaExpira.MinDate = _Usuario.Fecha_Expira;
                    dtpFechaExpira.Value = _Usuario.Fecha_Expira;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar el Usuario" + "\n" + ex.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar_Pantalla()
        {
            _Modifica = false;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtLogin.Text = "";
            txtContrasena.Text = "";
            chkEstado.Checked = true;
        }
        private bool Validar_Datos()
        {
            bool res = true;
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el nombre del Usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            if (txtNombre.Text == "")
            {
                res = false;
                MessageBox.Show("Debe agregar el login del Usuario para el inicio de sesión", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            if (txtContrasena.Text.Length < 5)
            {
                res = false;
                MessageBox.Show("La contraseña debe tener un mínimo de 5 caracteres", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Focus();
            }

            return res;
        }
        private void Llenar_Datos()
        {
            _Usuario.Nombre = txtNombre.Text;
            _Usuario.Correo = txtCorreo.Text;
            _Usuario.Estado = chkEstado.Checked;
            _Usuario.Crea = _Trastienda.Usuario.Usuario_Id;
            _Usuario.Modifica = _Trastienda.Usuario.Usuario_Id;
            _Usuario.Password = ClsSeguridad.GetSHA256(txtContrasena.Text);
            _Usuario.Login = txtLogin.Text;
            _Usuario.Fecha_Expira = dtpFechaExpira.Value;

        }
        private void Guardar()
        {
            try
            {
                tbUsuario _res;

                if (Validar_Datos())
                {
                    Llenar_Datos();
                    if (_Modifica)
                    {
                        _res = _Trastienda.WebApiSeguridad.ModifiarUsuario(_Usuario);
                    }
                    else
                    {
                        _res = _Trastienda.WebApiSeguridad.AgregarUsuario(_Usuario);
                    }

                    if (_res != null)
                        if (_res.Usuario_Id > 0)
                        {
                            MessageBox.Show("Se guardo el Usuario correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _Salir = true;
                            this.Close();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al guardar el Usuario" + "\n" + ex.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
