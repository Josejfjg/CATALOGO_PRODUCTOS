using System;

namespace CATALOGOOBJ
{
    public class tbUsuario
    {
        private int _Usuario_Id;
        private string _Nombre;
        private string _Login;
        private string _Password;
        private string _Correo;
        private bool _Estado;
        private DateTime _Fecha_Expira;
        private DateTime _Fecha_Crea;
        private int _Crea;
        private DateTime _Fecha_Modifica;
        private int _Modifica;

        public int Usuario_Id { get => _Usuario_Id; set => _Usuario_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Login { get => _Login; set => _Login = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public DateTime Fecha_Expira { get => _Fecha_Expira; set => _Fecha_Expira = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Crea { get => _Crea; set => _Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Modifica { get => _Modifica; set => _Modifica = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }

        public tbUsuario()
        {
            _Usuario_Id = 0;
            _Nombre = "";
            _Login = "";
            _Password = "";
            _Correo = "";
            _Fecha_Expira = new DateTime(1900, 01, 01);
            _Fecha_Crea = new DateTime(1900, 01, 01);
            _Crea = 0;
            _Fecha_Modifica = new DateTime(1900, 01, 01);
            _Modifica = 0;
            _Estado = true;

        }
    }
}
