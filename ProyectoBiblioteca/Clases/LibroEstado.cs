using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa el estado de un libro para un usuario específico
    public class LibroEstado

    {
        //(para relación usuario-libro)
        public int Id;
        public int UsuarioId;
        public Usuario Usuario;
        public int LibroId;
        public Libro Libro;
        public EstadoLectura Estado; // Enum para los estados
        public bool EsFavorito;
        public DateTime FechaActualizacion;
    }
    // Enum para los estados de lectura
    public enum EstadoLectura
    {
        Leido,
        NoLeido,
        Pendiente,
        Abandonado
    }
}