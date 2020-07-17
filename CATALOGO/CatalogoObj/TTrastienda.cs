using CATALOGOENLINEA;
using CATALOGOOBJ;
using System.Configuration;

namespace CATALOGO.CatalogoObj
{
    public class TTrastienda
    {
        private tbUsuario _Usuario;
        //private ClsSeguridad _Seguridad;
        private CATALOGOENLINEA.WebApiCatalogo_Productos webApiProductos;
        private CATALOGOENLINEA.WebApiCatalogo_Seguridad webApiSeguridad;
        private CATALOGOENLINEA.WebApiCatalogo_Reportes webApiReportes;
        public tbUsuario Usuario { get => _Usuario; set => _Usuario = value; }
        //public ClsSeguridad Seguridad { get => _Seguridad; set => _Seguridad = value; }
        public WebApiCatalogo_Productos WebApiProductos { get => webApiProductos; set => webApiProductos = value; }
        public WebApiCatalogo_Seguridad WebApiSeguridad { get => webApiSeguridad; set => webApiSeguridad = value; }
        public WebApiCatalogo_Reportes WebApiReportes { get => webApiReportes; set => webApiReportes = value; }

        public TTrastienda()
        {
            _Usuario = new tbUsuario();
            //_Seguridad = new ClsSeguridad();
            webApiProductos = new WebApiCatalogo_Productos(ConfigurationManager.ConnectionStrings["CATALOGO.Properties.Settings.Conexion"].ConnectionString);
            WebApiSeguridad = new WebApiCatalogo_Seguridad(ConfigurationManager.ConnectionStrings["CATALOGO.Properties.Settings.Conexion"].ConnectionString);
            webApiReportes = new WebApiCatalogo_Reportes(ConfigurationManager.ConnectionStrings["CATALOGO.Properties.Settings.Conexion"].ConnectionString);
        }
    }


}
