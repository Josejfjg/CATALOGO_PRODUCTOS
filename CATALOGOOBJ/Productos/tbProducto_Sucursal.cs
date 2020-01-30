using System;

namespace CATALOGOOBJ
{
    public class tbProducto_Sucursal
    {
        private int _Producto_Sucursal_Id;
        private int _Producto_Id;
        private int _Sucursal_Id;
        private string _Sucursal_Nombre;
        private bool _Sincronizado;
        private decimal _Costo;
        private decimal _Descuento;
        private decimal _Utilidad;
        private decimal _Sugerido;
        private bool _Estado;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;

        public int Producto_Sucursal_Id { get => _Producto_Sucursal_Id; set => _Producto_Sucursal_Id = value; }
        public int Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public int Sucursal_Id { get => _Sucursal_Id; set => _Sucursal_Id = value; }
        public string Sucursal_Nombre { get => _Sucursal_Nombre; set => _Sucursal_Nombre = value; }
        public bool Sincronizado { get => _Sincronizado; set => _Sincronizado = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }
        public decimal Utilidad { get => _Utilidad; set => _Utilidad = value; }
        public decimal Sugerido { get => _Sugerido; set => _Sugerido = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }


        public tbProducto_Sucursal()
        {
            _Producto_Sucursal_Id = 0;
            _Producto_Id = 0;
            _Sucursal_Id = 0;
            _Sucursal_Nombre = "";
            _Sincronizado = false;
            _Costo = 0;
            _Descuento = 0;
            _Utilidad = 0;
            _Sugerido = 0;
            _Estado = true;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Fecha_Modifica = Convert.ToDateTime("1900/01/01");
            _Usuario_Modifica = 0;
        }

    }
}