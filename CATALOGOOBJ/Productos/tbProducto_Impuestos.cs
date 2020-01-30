using System;

namespace CATALOGOOBJ
{
    public class tbProducto_Impuestos
    {
        private int _Detalle_Id;
        private int _Producto_Id;
        private string _Impuesto_Id;
        private string _Impuesto_Nombre;
        private bool _Estado;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;

        public int Detalle_Id { get => _Detalle_Id; set => _Detalle_Id = value; }
        public int Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public string Impuesto_Id { get => _Impuesto_Id; set => _Impuesto_Id = value; }
        public string Impuesto_Nombre { get => _Impuesto_Nombre; set => _Impuesto_Nombre = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }

        public tbProducto_Impuestos()
        {
            _Detalle_Id = 0;
            _Producto_Id = 0;
            _Impuesto_Id = "";
            _Impuesto_Nombre = "";
            _Estado = true;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Fecha_Modifica = Convert.ToDateTime("1900/01/01");
            _Usuario_Modifica = 0;
        }
    }
}
