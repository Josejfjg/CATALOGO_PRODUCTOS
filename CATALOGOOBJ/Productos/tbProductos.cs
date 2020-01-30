using System;
using System.Collections.Generic;

namespace CATALOGOOBJ
{
    public class tbProductos
    {
        private int _Producto_Id;
        private string _Codigo_Barras;
        private string _Fabricante_Id;
        private string _Fabricante_Nombre;
        private string _Marca_Id;
        private string _Marca_Nombre;
        private string _Unidad_Medida_Id;
        private string _Unidad_Medida_Nombre;
        private string _Familia_Id;
        private string _Familia_Nombre;
        private string _Categoria_Id;
        private string _Categoria_Nombre;
        private string _SubCategoria_Id;
        private string _SubCategorias_Nombre;
        private string _Casa_Comercial_Id;
        private string _Casa_Comercial_Nombre;
        private string _Nombre;
        private string _Descripcion;
        private string _Descripcion_Corta;
        private decimal _Contenido;
        private bool _Estado;
        private DateTime _Fecha_Crea;
        private int _Usuario_Crea;
        private DateTime _Fecha_Modifica;
        private int _Usuario_Modifica;
        private List<tbProducto_Sucursal> _Sucursales;
        private List<tbProducto_Impuestos> _Impuestos;


        public int Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public string Codigo_Barras { get => _Codigo_Barras; set => _Codigo_Barras = value; }
        public string Fabricante_Id { get => _Fabricante_Id; set => _Fabricante_Id = value; }
        public string Marca_Id { get => _Marca_Id; set => _Marca_Id = value; }
        public string Unidad_Medida_Id { get => _Unidad_Medida_Id; set => _Unidad_Medida_Id = value; }
        public string Familia_Id { get => _Familia_Id; set => _Familia_Id = value; }
        public string Categoria_Id { get => _Categoria_Id; set => _Categoria_Id = value; }
        public string SubCategoria_Id { get => _SubCategoria_Id; set => _SubCategoria_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public decimal Contenido { get => _Contenido; set => _Contenido = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Crea { get => _Fecha_Crea; set => _Fecha_Crea = value; }
        public int Usuario_Crea { get => _Usuario_Crea; set => _Usuario_Crea = value; }
        public DateTime Fecha_Modifica { get => _Fecha_Modifica; set => _Fecha_Modifica = value; }
        public int Usuario_Modifica { get => _Usuario_Modifica; set => _Usuario_Modifica = value; }
        public List<tbProducto_Sucursal> Sucursales { get => _Sucursales; set => _Sucursales = value; }
        public List<tbProducto_Impuestos> Impuestos { get => _Impuestos; set => _Impuestos = value; }
        public string Fabricante_Nombre { get => _Fabricante_Nombre; set => _Fabricante_Nombre = value; }
        public string Marca_Nombre { get => _Marca_Nombre; set => _Marca_Nombre = value; }
        public string Unidad_Medida_Nombre { get => _Unidad_Medida_Nombre; set => _Unidad_Medida_Nombre = value; }
        public string Familia_Nombre { get => _Familia_Nombre; set => _Familia_Nombre = value; }
        public string Categoria_Nombre { get => _Categoria_Nombre; set => _Categoria_Nombre = value; }
        public string SubCategorias_Nombre { get => _SubCategorias_Nombre; set => _SubCategorias_Nombre = value; }
        public string Casa_Comercial_Id { get => _Casa_Comercial_Id; set => _Casa_Comercial_Id = value; }
        public string Casa_Comercial_Nombre { get => _Casa_Comercial_Nombre; set => _Casa_Comercial_Nombre = value; }
        public string Descripcion_Corta { get => _Descripcion_Corta; set => _Descripcion_Corta = value; }

        public tbProductos()
        {
            _Codigo_Barras = "";
            _Producto_Id = 0;
            _Fabricante_Id = "";
            _Fabricante_Nombre = "";
            _Marca_Id = "";
            _Marca_Nombre = "";
            _Unidad_Medida_Id = "";
            _Unidad_Medida_Nombre = "";
            _Familia_Id = "";
            _Familia_Nombre = "";
            _Categoria_Id = "";
            _Categoria_Nombre = "";
            _SubCategoria_Id = "";
            SubCategorias_Nombre = "";
            _Nombre = "";
            _Descripcion = "";
            _Contenido = 0;
            _Estado = true;
            _Fecha_Crea = Convert.ToDateTime("1900/01/01");
            _Usuario_Crea = 0;
            _Fecha_Modifica = Convert.ToDateTime("1900/01/01");
            _Usuario_Modifica = 0;
            _Sucursales = new List<tbProducto_Sucursal>();
            _Impuestos = new List<tbProducto_Impuestos>();
            _Descripcion_Corta = "";
            _Casa_Comercial_Id = "";
            _Casa_Comercial_Nombre = "";
        }
    }
}