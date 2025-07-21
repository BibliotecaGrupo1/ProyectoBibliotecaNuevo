using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa la relación entre un usuario y un logro obtenido en la biblioteca
    public class UsuarioLogro
    {
        //(para relación usuario-logro)
        public int Id;
        public int UsuarioId;
        public Usuario Usuario;
        public int LogroId;
        public Logro Logro;
        public DateTime FechaObtencion;

    }
}
