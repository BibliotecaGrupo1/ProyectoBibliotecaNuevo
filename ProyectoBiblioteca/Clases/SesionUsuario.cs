using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa una sesión de usuario en la biblioteca
    public class SesionUsuario
    {
        //(para manejo de sesiones)
        public int Id;
        public int UsuarioId;
        public Usuario Usuario;
        public string Token;
        public DateTime FechaInicio;
        public DateTime? FechaFin;
    }
}
