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
        public List<Libro> LibrosFavoritos;

        //public int PuntosExperiencia;
        //List<Logro> LogrosObtenidos;
        //List<LibroEstado> LibrosEstados;

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
            this.LibrosFavoritos = new List<Libro>();

            
            //this.PuntosExperiencia = puntosExperiencia; (agregar esto al constructor)
            //this.LogrosObtenidos = List<Logro> logrosObtenidos;
            //this.LibrosEstados = librosEstado;

            BaseDeDatos.BaseDatosUsuario.Add(this);
        }

        public string BuscarUsuario() // Función para devolver datos privados, devuelve el nombre de usuario
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

        public int ObtenerID()
        {
            return this.Id;
        }
        public void ImprimirUsuarioParaAdministrador() // esto devuelve la información del usuario consultado
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

        public void SetNuevaContraseña(string NuevaContraseña)
        {
            this.Contraseña = NuevaContraseña;
        }

        public void AñadirFAvorito(Libro aggLibroFav) // Esta funcion agrega los items de la lista Libros a una nuevalista dentro de la clase Usuario como favoritos para un determinado Usuario
        {
            LibrosFavoritos.Add(aggLibroFav);
        }
    }
}