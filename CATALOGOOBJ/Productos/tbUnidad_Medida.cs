﻿using System;

namespace CATALOGOOBJ
{
    public class tbUnidad_Medida
    {
        private string _Unidad_Medida_Id;
        private string _Nombre;
        private string _Descripcion;
        private bool _Estado;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;

        public string Unidad_Medida_Id { get => _Unidad_Medida_Id; set => _Unidad_Medida_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }

        public tbUnidad_Medida()
        {
            _Unidad_Medida_Id = "";
            _Nombre = "";
            _Descripcion = "";
            _Estado = true;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Fecha_Modifica = Convert.ToDateTime("1900/01/01");
            _Usuario_Modifica = 0;

        }
    }
}
