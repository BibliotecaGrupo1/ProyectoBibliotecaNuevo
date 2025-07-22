using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Base
{
    internal class BaseDeDatos
    {
        public static List<Usuario> BaseDatosUsuario = new List<Usuario>(); // Base de datos del Usuario
        public static List<Libro> BaseDatosLibros = new List<Libro>();
        public static List<LibroEstado> BaseDatosLibrosEstados = new List<LibroEstado>();
        public static List<SesionUsuario> BaseDatosSesiones = new List<SesionUsuario>();
        public static List<UsuarioLogro> BaseDatosUsuarioLogros = new List<UsuarioLogro>();
        public static List<Logro> BaseDatosLogros = new List<Logro>();

        private static string NombreBaseDatosUsuario = "Datos.dat";
        
        public static void GuardarDatos()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(NombreBaseDatosUsuario, FileMode.Create);
            bf.Serialize(fs, NombreBaseDatosUsuario);
        }

        public static Usuario BuscarNombreUsuario(string usuario) // Esto llama la función que devuelve datos privador, para confirmar que el usuario se encuentre registrado
        {
            foreach (Usuario user in BaseDatosUsuario)
            {
                if (user.BuscarUsuario() == usuario)
                {
                    return user;
                }
            }
            return null;
        }

        public static Usuario BuscarContraseñaUsuario(string key) // Esto llama la función que devuelve datos privador, para confirmar que la contraseña sea igual a la del registro
        {
            foreach (Usuario llave in BaseDatosUsuario)
            {
                if (llave.BuscarContraseña() == key)
                {
                    return llave;
                }
            }
            return null;
        }

        public static Libro GetLibroPorCodigo(string codigo) // Pendiente de revisión
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
