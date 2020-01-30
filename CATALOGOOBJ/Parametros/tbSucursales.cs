using System;

namespace CATALOGOOBJ
{
    public class tbSucursales
    {
        private int _Sucursal_Id;
        private string _Nombre;
        private bool _Estado;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;

        public int Sucursal_Id { get => _Sucursal_Id; set => _Sucursal_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }
    }
}
