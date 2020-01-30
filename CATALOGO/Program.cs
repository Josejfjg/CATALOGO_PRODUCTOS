using System;
using System.Windows.Forms;

namespace CATALOGO
{
    public static class Program
    {


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(_frmLogin.Execute(_Trastienda));

            CatalogoObj.TTrastienda _Trastienda = new CatalogoObj.TTrastienda();

            Seguridad.frmLogin _frmLogin = new Seguridad.frmLogin();


            if (!_frmLogin.Execute(_Trastienda))
            {
                frmPrincipal _frmPrincipal = new frmPrincipal();
                _frmPrincipal.Execute(_Trastienda);

            }
        }
    }
}
