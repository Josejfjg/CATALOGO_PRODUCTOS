using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATALOGOOBJ
{
    public class tbFiltros
    {
        private DateTime _Fecha_Inicio;
        private DateTime _Fecha_Fin;
        private string _Id;
        private bool _Estado;
        private string _Familia_Id;
        private string _Categoria_Id;
        private string _SubCategoria_Id;
        private int _Sucursal_Id;

        public DateTime Fecha_Inicio { get => _Fecha_Inicio; set => _Fecha_Inicio = value; }
        public DateTime Fecha_Fin { get => _Fecha_Fin; set => _Fecha_Fin = value; }
        public string Id { get => _Id; set => _Id = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public string Familia_Id { get => _Familia_Id; set => _Familia_Id = value; }
        public string Categoria_Id { get => _Categoria_Id; set => _Categoria_Id = value; }
        public string SubCategoria_Id { get => _SubCategoria_Id; set => _SubCategoria_Id = value; }
        public int Sucursal_Id { get => _Sucursal_Id; set => _Sucursal_Id = value; }

        public tbFiltros()
        {
            Fecha_Inicio = Convert.ToDateTime("1900/01/01");
            Fecha_Fin = Convert.ToDateTime("1900/01/01");
            Id = "";
            Estado = false;
            _Familia_Id = "";
            _Categoria_Id = "";
            _SubCategoria_Id = "";
            _Sucursal_Id = 0;
        }
    
    }
}
