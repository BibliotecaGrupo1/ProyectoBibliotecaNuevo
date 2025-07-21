using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // esta clase representa una búsqueda realizada por un usuario en la biblioteca
    public class Busqueda
    {
        public int Id;
        public int UsuarioId; // Nullable si es búsqueda sin login
        public Usuario Usuario;
        public string Termino;
        public TipoBusqueda Tipo;
        public DateTime Fecha;

        public Busqueda(int id, int usuarioId, Usuario usuario, string termino, TipoBusqueda tipo, DateTime fecha)
        {
            Id = id;
            UsuarioId = usuarioId;
            Usuario = usuario;
            Termino = termino;
            Tipo = tipo;
            Fecha = fecha;
        }
    }
    // Enum para los tipos de búsqueda
    public enum TipoBusqueda
    {
        Titulo,
        Autor,
        AñoPublicacion
    }
}
