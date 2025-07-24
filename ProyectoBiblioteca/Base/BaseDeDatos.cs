using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Base
{
    public static class BaseDeDatos
    {
        public static List<Usuario> BaseDatosUsuario = new List<Usuario>(); // Base de datos del Usuario
        public static List<SesionUsuario> BaseDatosSesiones = new List<SesionUsuario>(); // Base de datos de las sesiones de un Usuario
        public static List<Libro> BaseDatosLibros = new List<Libro>();
        public static List<LibroEstado> BaseDatosLibrosEstados = new List<LibroEstado>();
        public static List<UsuarioLogro> BaseDatosUsuarioLogros = new List<UsuarioLogro>();
        public static List<Logro> BaseDatosLogros = new List<Logro>();

        private static string NombreBaseDatosUsuario = "DatosUsuario.dat"; // archivo de la base de datos de Usuario.
        private static string NombreBaseDatosSesionUsuario = "DatosSesionUsuario.dat"; // archivo de la base de datos de sesiones de Usuario.

        public static void GuardarDatosUsuario() // Guarda los datos en la BSD Usuario
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoUsuario = new FileStream(NombreBaseDatosUsuario, FileMode.Create);
            bf.Serialize(ArchivoUsuario, BaseDatosUsuario);
        }

        public static void GuardarDatosSesionUsuario() // Guarda los datos en la BSD SesionUsuario
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoSesionUsuario = new FileStream(NombreBaseDatosSesionUsuario, FileMode.Create);
            bf.Serialize(ArchivoSesionUsuario, BaseDatosSesiones);
        }

        public static void CargarDatosUsuario() // Carga los datos de la BSD Usuario
        {
            if (File.Exists(NombreBaseDatosUsuario))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream ArchivoUsuario = new FileStream(NombreBaseDatosUsuario, FileMode.Open);
                BaseDatosUsuario = (List<Usuario>)bf.Deserialize(ArchivoUsuario);
                ArchivoUsuario.Close();
            }
        }

        public static void CargarDatosSesionUsuario() // Carga los datos de la BSD Sesiones
        {
            if (File.Exists(NombreBaseDatosSesionUsuario))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream ArchivoSesionUsuario = new FileStream(NombreBaseDatosSesionUsuario, FileMode.Open);
                BaseDatosSesiones = (List<SesionUsuario>)bf.Deserialize(ArchivoSesionUsuario);
                ArchivoSesionUsuario.Close();
            }
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

        /*public static void ImprimirDatosDeUsuario()
        {
            foreach (Usuario DatoUser in BaseDatosUsuario)
            {
                DatoUser.ImprimirUsuario();
            }
        }

        public static void ImprimirDatosSesionUsuario()
        {
            foreach (SesionUsuario DatoSesionUser in BaseDatosSesiones)
            {
                DatoSesionUser.ImprimirSesionUsuario();
            }
        }*/
    }
}