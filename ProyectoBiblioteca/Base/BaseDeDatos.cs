using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Base
{
    internal class BaseDeDatos
    {
        public static List<Usuario> BaseDatosUsuario = new List<Usuario>();
        public static List<Libro> BaseDatosLibros = new List<Libro>();
        public static List<LibroEstado> BaseDatosLibrosEstados = new List<LibroEstado>();
        public static List<SesionUsuario> BaseDatosSesiones = new List<SesionUsuario>();
        public static List<UsuarioLogro> BaseDatosUsuarioLogros = new List<UsuarioLogro>();
        public static List<Logro> BaseDatosLogros = new List<Logro>();

    

     public static Libro GetLibroPorCodigo(string codigo)
        {
            foreach (var item in BaseDatosLibros)
            {
                if (item.getCodigo() == codigo)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
