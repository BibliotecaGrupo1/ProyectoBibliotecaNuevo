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
        public static List<Libro> BaseDatosLibros = new List<Libro>(); // Base de datos de los Libros en la biblioteca
        public static List<LibroEstado> BaseDatosLibrosEstados = new List<LibroEstado>();
        public static List<UsuarioLogro> BaseDatosUsuarioLogros = new List<UsuarioLogro>();
        public static List<Logro> BaseDatosLogros = new List<Logro>();
        public static List<Administradores> BaseDatosAdministradores = new List<Administradores>();

        private static string NombreBaseDatosUsuario = "DatosUsuario.dat"; // archivo de la base de datos de Usuario.
        private static string NombreBaseDatosSesionUsuario = "DatosSesionUsuario.dat"; // archivo de la base de datos de sesiones de Usuario.
        private static string NombreBaseDatosLibros = "DatosLibros.dat";
        private static string NombreBaseDatosAdministradores = "DatosAdministradores.dat"; // BDS Administradores



        /////////////////////////       BASE DE DATOS USUARIO       /////////////////////////
        public static void GuardarDatosUsuario() // Guarda los datos en la BSD Usuario
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoUsuario = new FileStream(NombreBaseDatosUsuario, FileMode.Create);
            bf.Serialize(ArchivoUsuario, BaseDatosUsuario);
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



        /////////////////////////       BASE DE DATOS PERFIL USUARIO       /////////////////////////
        public static void GuardarDatosSesionUsuario() // Guarda los datos en la BSD SesionUsuario
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoSesionUsuario = new FileStream(NombreBaseDatosSesionUsuario, FileMode.Create);
            bf.Serialize(ArchivoSesionUsuario, BaseDatosSesiones);
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



        /////////////////////////       BASE DE DATOS LIBROS       /////////////////////////
        public static void GuardarDatosLibros() // Guarda los datos en la BSD Libros
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoLibros = new FileStream(NombreBaseDatosLibros, FileMode.Create);
            bf.Serialize(ArchivoLibros, BaseDatosLibros);
        }
        public static void CargarDatosLibros() // Carga los datos de la BSD Sesiones
        {
            if (File.Exists(NombreBaseDatosLibros))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream ArchivoLibro = new FileStream(NombreBaseDatosLibros, FileMode.Open);
                BaseDatosLibros = (List<Libro>)bf.Deserialize(ArchivoLibro);
                ArchivoLibro.Close();
            }
        }



        /////////////////////////       BASE DE DATOS ADMINISTRADORES       /////////////////////////
        public static void GuardarDatosAdministradores() // Guarda los datos en la BSD Administradores
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoAdministradores = new FileStream(NombreBaseDatosAdministradores, FileMode.Create);
            bf.Serialize(ArchivoAdministradores, BaseDatosAdministradores);
        }
        public static void CargarDatosAdministradores() // Carga los datos de la BSD Administradores
        {
            if (File.Exists(NombreBaseDatosAdministradores))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream ArchivoAdministrator = new FileStream(NombreBaseDatosAdministradores, FileMode.Open);
                BaseDatosAdministradores = (List<Administradores>)bf.Deserialize(ArchivoAdministrator);
                ArchivoAdministrator.Close();
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

        public static Administradores ObtenerAdminUsuario(string UA) // Esto llama la función que devuelve datos privador, para confirmar que el usuario se encuentre registrado
        {
            foreach (Administradores userADMIN in BaseDatosAdministradores)
            {
                if (userADMIN.BuscarUserAdmin() == UA)
                {
                    return userADMIN;
                }
            }
            return null;
        }

        public static Libro BuscarLibroPorCodigoID(int id) // Pendiente de revisión
        {
            foreach (Libro item in BaseDatosLibros)
            {
                if (item.BuscarLibroID() == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void ImprimirTodosLibros()
        {
            foreach (Libro Libros in BaseDatosLibros)
            {
                Libros.MostrarLibros();
            }
        }

        public static void ImprimirDatosSesionUsuario()
        {
            foreach (SesionUsuario DatoSesionUser in BaseDatosSesiones)
            {
                DatoSesionUser.ImprimirSesionUsuario();
            }
        }

        public static void ListaImprimirAdmins()
        {
            foreach (Administradores administradores in BaseDatosAdministradores)
            {
                administradores.ImprimirAdmin();
            }
        }

        public static void ListaImprimirUsuario()
        {
            foreach (Usuario usuario in BaseDatosUsuario)
            {
                usuario.ImprimirUsuario();
            }
        }
    }
}