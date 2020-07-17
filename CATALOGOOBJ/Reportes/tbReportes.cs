using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATALOGOOBJ
{
    public class repListProductos_X_Proveedor
    {

        private string _Codigo_Barras;
        private string _Familia_Nombre;
        private string _Categoria_Nombre;
        private string _SubCategorias_Nombre;
        private string _Descripcion_Compuesta;
        private bool _Estado;
        private decimal _Costo;
        private decimal _Descuento_Cliente;
        private decimal _Descuento_Factura;
        private string _Sucursal;
        private decimal _Utilidad;
        private decimal _Precio_Sugerido;


        public string Codigo_Barras { get => _Codigo_Barras; set => _Codigo_Barras = value; }
        public string Familia_Nombre { get => _Familia_Nombre; set => _Familia_Nombre = value; }
        public string Categoria_Nombre { get => _Categoria_Nombre; set => _Categoria_Nombre = value; }
        public string SubCategorias_Nombre { get => _SubCategorias_Nombre; set => _SubCategorias_Nombre = value; }
        public string Descripcion_Compuesta { get => _Descripcion_Compuesta; set => _Descripcion_Compuesta = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal Descuento_Cliente { get => _Descuento_Cliente; set => _Descuento_Cliente = value; }
        public decimal Descuento_Factura { get => _Descuento_Factura; set => _Descuento_Factura = value; }
        public string Sucursal { get => _Sucursal; set => _Sucursal = value; }
        public decimal Utilidad { get => _Utilidad; set => _Utilidad = value; }
        public decimal Precio_Sugerido { get => _Precio_Sugerido; set => _Precio_Sugerido = value; }

        public repListProductos_X_Proveedor()
        {
            _Codigo_Barras = "";
            _Familia_Nombre = "";
            _Categoria_Nombre = "";
            _SubCategorias_Nombre = "";
            _Descripcion_Compuesta = "";
            _Estado = false;
            _Costo = 0;
            _Descuento_Cliente = 0;
            _Descuento_Factura = 0;
            _Sucursal = "";
            _Costo = 0;
            _Precio_Sugerido = 0;
        }

    }
}
