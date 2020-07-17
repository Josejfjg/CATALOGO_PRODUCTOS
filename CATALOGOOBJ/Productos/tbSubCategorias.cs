using System;

namespace CATALOGOOBJ
{
    public class tbSubCategorias
    {
        private string _Familia_Id;
        private string _Categoria_Id;
        private string _SubCategoria_Id;
        private string _Nombre;
        private string _Descripcion;
        private bool _Estado;
        private string _Categoria_Nombre;
        private string _Familia_Nombre;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;

        public string Familia_Id { get => _Familia_Id; set => _Familia_Id = value; }
        public string SubCategoria_Id { get => _SubCategoria_Id; set => _SubCategoria_Id = value; }
        public string Categoria_Id { get => _Categoria_Id; set => _Categoria_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public string Categoria_Nombre { get => _Categoria_Nombre; set => _Categoria_Nombre = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }
        public string Familia_Nombre { get => _Familia_Nombre; set => _Familia_Nombre = value; }

        public tbSubCategorias()
        {
            _Familia_Id = "";
            _Categoria_Id = "";
            _SubCategoria_Id = "";
            _Nombre = "";
            _Descripcion = "";
            _Estado = true;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Fecha_Modifica = Convert.ToDateTime("1900/01/01");
            _Usuario_Modifica = 0;
            _Categoria_Nombre = "";

        }
    }
}
