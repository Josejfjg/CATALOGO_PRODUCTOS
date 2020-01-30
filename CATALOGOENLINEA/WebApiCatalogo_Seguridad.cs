using CATALOGOOBJ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CATALOGOENLINEA
{
    public class WebApiCatalogo_Seguridad
    {
        #region "Variables"
        private string _Conexion = "";
        #endregion

        #region "Costructor"
        public WebApiCatalogo_Seguridad(string pConexion)
        {
            _Conexion = pConexion;
        }
        #endregion

        #region "Usuarios"
        public tbUsuario Valida_Usuarios(string pLogin, string pPassword)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Valida_Usuario/";

                tbUsuario _Datos = new tbUsuario();
                _Datos.Login = pLogin;
                _Datos.Password = pPassword;
                string jsonMobile = JsonConvert.SerializeObject(_Datos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbUsuario>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbUsuario ListUsuario(tbUsuario pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Get_Usuario/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbUsuario>(Status);
                }
                else
                    throw new Exception(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<tbUsuario> ListaUsuarios()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Lista_Usuarios/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<tbUsuario>>(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbUsuario AgregarUsuario(tbUsuario pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbUsuario>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbUsuario ModifiarUsuario(tbUsuario pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbUsuario>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarUsuario(tbUsuario pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Usuario/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region "Sucursales"
        public List<tbSucursales> ListaSucursales()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Sucursales/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                if (_Result.IsSuccessStatusCode)
                {
                    string Status = _Result.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<tbSucursales>>(Status);
                }
                else
                    throw new Exception("Problemas al cargar los datos de las sucursales");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion


    }
}
