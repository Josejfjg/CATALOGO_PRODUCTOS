using CATALOGOOBJ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CATALOGOENLINEA
{
    public class WebApiCatalogo_Productos
    {
        #region "Variables"
        private string _Conexion = "";
        #endregion

        #region "Costructor"
        public WebApiCatalogo_Productos(string pConexion)
        {
            _Conexion = pConexion;
        }
        #endregion

        #region "Productos"

        public List<tbProductos> ListaProductos(tbProductos pProductos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();

                string _url = _Conexion + "/Productos/ListaProductos/";
                string jsonMobile = JsonConvert.SerializeObject(pProductos);

                //var _Result = _cliente.GetAsync(_url).Result;
                //string Status = _Result.Content.ReadAsStringAsync().Result;

                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbProductos>>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbProductos AgregarProductos(tbProductos pProductos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Productos/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pProductos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbProductos>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbProductos ModifiarProductos(tbProductos pProductos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Productos/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pProductos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbProductos>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbProductos GetProducto(int pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Productos/";

                var _Result = _cliente.GetAsync(_url + pId).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbProductos>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarProducto(int pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Productos/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "Categorias"
        public List<tbCategorias> ListaCategorias(tbCategorias pCategorias)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Categorias/";
                string jsonMobile = JsonConvert.SerializeObject(pCategorias);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbCategorias>>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbCategorias AgregarCategoria(tbCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Categorias/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbCategorias>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbCategorias ModifiarCategoria(tbCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Categorias/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbCategorias>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarCategoria(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Categorias/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "Fabricante"
        public List<tbFabricantes> ListaFabricantes()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Fabricantes/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbFabricantes>>(Status);
                }
                else
                    throw new Exception(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbFabricantes AgregarFabricante(tbFabricantes pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Fabricantes/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbFabricantes>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbFabricantes ModifiarFabricante(tbFabricantes pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Fabricantes/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbFabricantes>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarFabricante(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Fabricantes/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "Familia"
        public List<tbFamilias> ListaFamilia()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Familias/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbFamilias>>(Status);
                }
                else
                    throw new Exception(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbFamilias AgregarFamilia(tbFamilias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Familias/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbFamilias>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbFamilias ModifiarFamilia(tbFamilias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Familias/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbFamilias>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarFamilia(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Familias/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "Marcas"
        public List<tbMarcas> ListaMarcas()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Marcas/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<tbMarcas>>(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbMarcas AgregarMarca(tbMarcas pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Marcas/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbMarcas>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbMarcas ModifiarMarca(tbMarcas pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Marcas/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbMarcas>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarMarca(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Marcas/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "SubCategorias"
        public List<tbSubCategorias> ListaSubCategorias(tbSubCategorias pSubCategoria)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/SubCategorias/";
                string jsonMobile = JsonConvert.SerializeObject(pSubCategoria);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbSubCategorias>>(Status);
                }
                else
                    throw new Exception(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<tbSubCategorias> ListaSubCategorias_X_Categoria(tbSubCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/SubCategorias/SubCategorias_X_Categoria/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbSubCategorias>>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbSubCategorias AgregarSubCategoria(tbSubCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/SubCategorias/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbSubCategorias>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbSubCategorias ModifiarSubCategoria(tbSubCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/SubCategorias/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbSubCategorias>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarSubCategoria(tbSubCategorias pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/SubCategorias/Eliminar/";
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

        #region "Unidad_Medida"
        public List<tbUnidad_Medida> ListaUnidad_Medida()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Unidad_Medida/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<tbUnidad_Medida>>(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbUnidad_Medida AgregarUnidad_Medida(tbUnidad_Medida pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Unidad_Medida/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbUnidad_Medida>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbUnidad_Medida ModifiarUnidad_Medida(tbUnidad_Medida pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Unidad_Medida/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbUnidad_Medida>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarUnidad_Medida(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Unidad_Medida/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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

        #region "Impuestos"
        public List<tbImpuestos> ListaImpuestos()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Impuestos/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<tbImpuestos>>(Status);
                }
                else
                    throw new Exception("Problemas al cargar los impuestos \n" + Status);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbImpuestos AgregarImpuesto(tbImpuestos pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Impuestos/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbImpuestos>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbImpuestos ModifiarImpuesto(tbImpuestos pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Impuestos/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbImpuestos>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarImpuesto(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Impuestos/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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
        #region "Casa_Comercial"
        public List<tbCasa_Comercial> ListaCasa_Comercial()
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Casa_Comercial/";

                string jsonMobile = JsonConvert.SerializeObject("");
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<tbCasa_Comercial>>(Status);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbCasa_Comercial AgregarCasa_Comercial(tbCasa_Comercial pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Casa_Comercial/Agregar/";

                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<tbCasa_Comercial>(Status);
                }
                else
                    throw new Exception(Status);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public tbCasa_Comercial ModifiarCasa_Comercial(tbCasa_Comercial pDatos)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Casa_Comercial/Modificar/";
                string jsonMobile = JsonConvert.SerializeObject(pDatos);
                var _Result = _cliente.PostAsync(_url, new StringContent(jsonMobile, Encoding.UTF8, "application/json")).Result;
                string Status = _Result.Content.ReadAsStringAsync().Result;
                if (_Result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<tbCasa_Comercial>(Status);
                }
                else
                    throw new Exception(_Result.RequestMessage.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarCasa_Comercial(string pId)
        {
            try
            {
                HttpClient _cliente = new HttpClient();
                string _url = _Conexion + "/Casa_Comercial/Eliminar/";
                string jsonMobile = JsonConvert.SerializeObject(pId);
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
    }

}

