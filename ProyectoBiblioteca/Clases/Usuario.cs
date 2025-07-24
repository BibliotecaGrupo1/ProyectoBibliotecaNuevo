using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Base;
using ProyectoBiblioteca.Clases;

namespace ProyectoBiblioteca.Clases
{
    [Serializable]
    // Esta clase representa un usuario en la biblioteca
    public class Usuario
    {
        private int Id;
        private string Nombres;
        private string Apellidos;
        private string NombreCompleto;
        private DateTime Fecha_Nacimiento;
        private int edad;
        private string NombreUsuario;
        private string Correo;
        public string Contraseña; // Debería almacenarse como hash(pero no lo vamos a hacer no mms que flojera)
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
            
            //this.PuntosExperiencia = puntosExperiencia; (agregar esto al constructor)
            //this.LogrosObtenidos = List<Logro> logrosObtenidos;
            //this.LibrosEstados = librosEstado;

            BaseDeDatos.BaseDatosUsuario.Add(this);
        }

        public string BuscarUsuario() // Función para devolver datos privados, devuelve el nombre de usuario
        {
            return this.NombreUsuario;
        }

        public string BuscarCorreo() // Función para devolver datos privados, devuelve el correo electrónico
        {
            return this.Correo;
        }


        public void ImprimirUsuario() // esto devuelve la información del usuario consultado
        {
            Console.WriteLine("==========================================");
            Console.WriteLine(" DATOS PERSONALES DEL USUARIO:");
            Console.WriteLine(" ID: " + this.Id); //
            Console.WriteLine(" Nombre Completo: " + this.NombreCompleto);//
            Console.WriteLine(" Edad: " + this.edad); //
        }
    }
}