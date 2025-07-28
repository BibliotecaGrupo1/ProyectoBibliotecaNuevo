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
        public static List<Usuario> BaseDatosUsuario = new List<Usuario>(); // Base de datos del Usuario.
        public static List<SesionUsuario> BaseDatosSesiones = new List<SesionUsuario>(); // Base de datos de las sesiones de un Usuario.
        public static List<Libro> BaseDatosLibros = new List<Libro>(); // Base de datos de los Libros en la biblioteca.
        public static List<Administradores> BaseDatosAdministradores = new List<Administradores>(); // Base de datos de los ADMINISTRADORES.

        private static string NombreBaseDatosUsuario = "DatosUsuario.dat"; // archivo de la base de datos de Usuario.
        private static string NombreBaseDatosSesionUsuario = "DatosSesionUsuario.dat"; // archivo de la base de datos de sesiones de Usuario.
        private static string NombreBaseDatosLibros = "DatosLibros.dat";// archivo de la base de datos de los libros.
        private static string NombreBaseDatosAdministradores = "DatosAdministradores.dat"; // archivo de la base de datos de los ADMINISTRADORES.



        /////////////////////////       BASE DE DATOS USUARIO       /////////////////////////
        public static void GuardarDatosUsuario() // Guarda los datos en la BSD Usuario
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream ArchivoUsuario = new FileStream(NombreBaseDatosUsuario, FileMode.Create);
            bf.Serialize(ArchivoUsuario, BaseDatosUsuario);
            ArchivoUsuario.Close();
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
            ArchivoSesionUsuario.Close();
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
            var ArchivoLibros = new FileStream(NombreBaseDatosLibros, FileMode.Create);
            bf.Serialize(ArchivoLibros, BaseDatosLibros);
            ArchivoLibros.Close();
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
            ArchivoAdministradores.Close();
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



        /////////////////////////       FUNCIONES       /////////////////////////
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

        public static Administradores ObtenerAdminUsuario(string UA) // Esto llama la función que devuelve datos privador, para confirmar que el Usuario de ADMINISTRADOR se encuentre registrado
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

        public static Libro BuscarLibroPorID(int id)
        {
            foreach (Libro libro in BaseDatosLibros)
            {
                if (libro.Id == id)
                {
                    return libro;
                }
            }
            return null;
        }

        public static Libro BuscarLibroPorCodigoID(int id) // Pendiente de revisión
        {
            foreach (Libro item in BaseDatosLibros)
            {
                if (item.BuscarLibroID(id)) // Se pasa el argumento "id" requerido
                {
                    return item;
                }
            }
            return null;
        }

        public static Usuario BuscarUsuarioPorID(int id)
        {
            foreach (Usuario User in BaseDatosUsuario)
            {
                if (User.Id == id)
                {
                    return User;
                }
            }
            return null;
        }

        public static void ImprimirTodosLibros() // llama la funcion Imprimir en la clase libros, para imprimir la lista de libros
        {
            foreach (Libro Libros in BaseDatosLibros)
            {
                Libros.MostrarLibros();
            }
        }

        public static void ImprimirDatosSesionUsuario() // llama la funcion Imprimir en la clase SesionUsuario, para imprimir los datos del perfil
        {
            foreach (SesionUsuario DatoSesionUser in BaseDatosSesiones)
            {
                DatoSesionUser.ImprimirSesionUsuario();
            }
        }

        public static void ListaImprimirUsuario() // llama la funcion de imprimir en la clase Usuarios, para imprimir los datos de los Usuarios
        {
            foreach (Usuario usuario in BaseDatosUsuario)
            {
                usuario.ImprimirUsuario();
            }
        }

        public static void ListaImprimirUsuarioADM() // llama la funcion de imprimir en la clase Usuarios, para imprimir los datos de los Usuarios
        {
            foreach (Usuario usuario in BaseDatosUsuario)
            {
                usuario.ImprimirUsuarioParaAdministrador();
            }
        }

        public static void EliminarLibro(int id) // Elimina un libro de la base de datos por su ID
        {
            Libro libroAEliminar = BuscarLibroPorID(id);
            if (libroAEliminar != null)
            {
                BaseDatosLibros.Remove(libroAEliminar);
                Console.WriteLine("Libro eliminado correctamente.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        public static void ReorganizarIDsLibros() // pendiente, posiblemente no irá en el codigo final
        {
            BaseDatosLibros = BaseDatosLibros.OrderBy(l => l.Id).ToList(); // Ordenar la lista por ID actual

            for (int i = 0; i < BaseDatosLibros.Count; i++) // Reasignar IDs secuencialmente comenzando desde 1
            {
                BaseDatosLibros[i].Id = i + 1;
            }
        }

        public static void ReorganizarIDsUsuario() // pendiente, posiblemente no irá en el codigo final
        {
            BaseDatosUsuario = BaseDatosUsuario.OrderBy(l => l.Id).ToList(); // Ordenar la lista por ID actual

            for (int i = 0; i < BaseDatosUsuario.Count; i++) // Reasignar IDs secuencialmente comenzando desde 1
            {
                BaseDatosUsuario[i].Id = i + 1;
            }
        }
    }
}