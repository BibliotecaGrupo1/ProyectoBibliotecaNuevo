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
    public class SesionUsuario // Esta clase representa una sesión de usuario en la biblioteca
    {
        public int Id;
        private string NombreUsuario;
        public string Correo;
        public string UsuarioID;

        public SesionUsuario(string nombreUsuario, string correo)
        {
            int secuenciaID = Base.BaseDeDatos.BaseDatosSesiones.Count() + 1;
            this.Id = secuenciaID;
            this.NombreUsuario = nombreUsuario;
            this.Correo = correo;
            //this.UsuarioID = usuarioID;

            BaseDeDatos.BaseDatosSesiones.Add(this);
        }

        public void ImprimirSesionUsuario() // esto devuelve la información de la sesión de un usuario consultado
        {
            Console.WriteLine("...................................................");
            Console.WriteLine("DATOS DEL PERFIL DEL USUARIO: ");
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Nombre de Usuario: " + this.NombreUsuario);
            Console.WriteLine("Correo electrónico: " + this.Correo);
        }
    }
}
