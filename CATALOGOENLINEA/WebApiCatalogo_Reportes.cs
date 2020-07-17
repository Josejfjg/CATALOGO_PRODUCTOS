using CATALOGOOBJ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CATALOGOENLINEA
{
    public class WebApiCatalogo_Reportes
    {
        #region "Variables"
        private string _Conexion = "";
        #endregion

        #region "Costructor"
        public WebApiCatalogo_Reportes(string pConexion)
        {
            _Conexion = pConexion;
        }
        #endregion

        #region "Proveedor"
        public List<repListProductos_X_Proveedor> repListProductos_X_Proveedors(tbFiltros pFiltros)
        {
            try
            {
                HttpClient _cliente = new HttpClient();

                string _url = _Conexion + "/Reportes/RepProducto_Proveedor_Costos/";
                string jsonMobile = JsonConvert.SerializeObject(pFiltros);

                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<repListProductos_X_Proveedor>>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion


    }
}
