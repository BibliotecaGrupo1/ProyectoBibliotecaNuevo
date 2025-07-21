using ProyectoBiblioteca.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa un usuario en la biblioteca
    public class Usuario
    {

        private int Id;
        private string Nombres;
        private string Apellidos;
        private string NombreUsuario;
        private string Contraseña; // Debería almacenarse como hash(pero no lo vamos a hacer no mms que flojera)
        private string Correo;
        public int PuntosExperiencia;
        List<Logro> LogrosObtenidos;
        List<LibroEstado> LibrosEstados;

        // Constructor para inicializar un nuevo usuario
        public Usuario(int id, string nombres, string apellidos, string nombreUsuario, string contraseña, string correo, int puntosExperiencia, List<Logro> logrosObtenidos, List<LibroEstado> librosEstados)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Correo = correo;
            PuntosExperiencia = puntosExperiencia;
            LogrosObtenidos = logrosObtenidos;
            LibrosEstados = librosEstados;
            BaseDeDatos.BaseDatosUsuario.Add(this);

        }













    }
}
