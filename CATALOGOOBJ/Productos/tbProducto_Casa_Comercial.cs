using System;

namespace CATALOGOOBJ
{
    public class tbProducto_Casa_Comercial
    {
        private int _Producto_Casa_Comercial_Id;
        private int _Producto_Id;
        private string _Casa_Comercial_Id;
        private int _Sucursal_Id;
        private string _Casa_Comercial_Nombre;
        private decimal _Costo;
        private decimal _Descuento_Factura;
        private decimal _Descuento_Cliente;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;


        public int Producto_Casa_Comercial_Id { get => _Producto_Casa_Comercial_Id; set => _Producto_Casa_Comercial_Id = value; }
        public int Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal Descuento_Factura { get => _Descuento_Factura; set => _Descuento_Factura = value; }
        public decimal Descuento_Cliente { get => _Descuento_Cliente; set => _Descuento_Cliente = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public string Casa_Comercial_Id { get => _Casa_Comercial_Id; set => _Casa_Comercial_Id = value; }
        public string Casa_Comercial_Nombre { get => _Casa_Comercial_Nombre; set => _Casa_Comercial_Nombre = value; }
        public int Sucursal_Id { get => _Sucursal_Id; set => _Sucursal_Id = value; }

        public tbProducto_Casa_Comercial()
        {
            _Producto_Casa_Comercial_Id = 0;
            _Producto_Id = 0;
            _Casa_Comercial_Id = "";
            _Costo = 0;
            _Descuento_Factura = 0;
            _Descuento_Cliente = 0;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Casa_Comercial_Nombre = "";
            _Sucursal_Id = 0;

        }

    }
}
