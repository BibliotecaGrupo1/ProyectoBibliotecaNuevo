using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Base;

namespace ProyectoBiblioteca.Clases
{
    [Serializable]
    public class Usuario // Esta clase representa un usuario en la biblioteca
    {
        public int Id;
        public string Nombres;
        public string Apellidos;
        public string NombreCompleto;
        public DateTime Fecha_Nacimiento;
        public int edad;
        public string NombreUsuario;
        public string Correo;
        private string Contraseña;
        public List<Libro> LibrosUsuario; // Esta lista puede ser utilizada para almacenar los libros que el usuario ha leído o está leyendo
        public List<Logro> LogrosUsuario; // Agregado: Lista para almacenar los logros obtenidos por el usuario

        // Constructor para inicializar un nuevo usuario
        public Usuario(string nombres, string apellidos, DateTime Fecha_Nacimiento, string nombreUsuario, string correo, string contraseña) //int puntosExperiencia, List<Logro> logrosObtenidos, List<LibroEstado> librosEstado)
        {
            int secuenciaID = Base.BaseDeDatos.BaseDatosUsuario.Count() + 1;

            this.Id = secuenciaID;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.NombreCompleto = nombres + " " + apellidos;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.edad = DateTime.Now.Year - Fecha_Nacimiento.Year;
            this.NombreUsuario = nombreUsuario;
            this.Correo = correo;
            this.Contraseña = contraseña;
            this.LibrosUsuario = new List<Libro>();
            this.LogrosUsuario = new List<Logro>(); // Inicialización de la lista de logros

            BaseDeDatos.BaseDatosUsuario.Add(this);
        }

        public string BuscarUsuario() // Función para devolver el nombre de usuario consultado
        {
            return this.NombreUsuario;
        }

        public bool ValidarContraseñaUsuario(string claveUser) // esto valida que la contraseña sea igual a la del usuario consultado, sirve para el inicio de sesión
        {
            return this.Contraseña == claveUser;
        }


        public void ImprimirUsuario() // esto devuelve la información del usuario consultado
        {
            Console.WriteLine(" ID: " + this.Id);
            Console.WriteLine(" Nombre Completo: " + this.NombreCompleto);
            Console.WriteLine(" Edad: " + this.edad);
            Console.WriteLine();
            Console.WriteLine("..............................................");
            Console.WriteLine();
        }

        public void ImprimirPerfilUsuario() // esto devuelve la información del usuario consultado, mostrando la lista completa para los administradores
        {
            Console.WriteLine(" ID: " + this.Id);
            Console.WriteLine(" Nombre Completo: " + this.NombreCompleto);
            Console.WriteLine(" Edad: " + this.edad);
            Console.WriteLine();
            Console.WriteLine(" Nombre de Usuario: " + this.NombreUsuario);
            Console.WriteLine(" Correo: " + this.Correo);
            Console.WriteLine();
            Console.WriteLine("..............................................");
            Console.WriteLine();
        }

        public int ObtenerID() // esto retorna la ID
        {
            return this.Id;
        }
        public void ImprimirUsuarioParaAdministrador() // esto devuelve la información del usuario consultado, mostrando la lista completa para los administradores
        {
            Console.WriteLine(" ID: " + this.Id);
            Console.WriteLine(" Nombre Completo: " + this.NombreCompleto);
            Console.WriteLine(" Edad: " + this.edad);
            Console.WriteLine(" Nombre de Usuario: " + this.NombreUsuario);
            Console.WriteLine(" Correo: " + this.Correo);
            Console.WriteLine(" Contraseña de Usuario: " + this.Contraseña);
            Console.WriteLine();
            Console.WriteLine("..............................................");
            Console.WriteLine();
        }

        public void SetNuevaContraseña(string NuevaContraseña) // este es el metodo por el que se puede modificar datos privados de un usuario como su contraseña (sirve tanto para Administradores como para Usuarios
        {
            this.Contraseña = NuevaContraseña;
        }


        public void AñadirLibroUsuario(Libro aggLibro) // Esta funcion agrega los items de la lista Libros a una nuevalista dentro de la clase Usuario como libros leidos o en lectura para un determinado Usuario
        {
            if (LibrosUsuario == null)
            {
                LibrosUsuario = new List<Libro>();
            }
            LibrosUsuario.Add(aggLibro);
        }
        public void AñadirLogro(Logro nuevoLogro)
        {
            if (LogrosUsuario == null)
            {
                LogrosUsuario = new List<Logro>();
            }
            LogrosUsuario.Add(nuevoLogro);
        }
    }
}