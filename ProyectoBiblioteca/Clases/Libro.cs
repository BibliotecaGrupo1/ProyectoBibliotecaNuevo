using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa un libro en la biblioteca
    public class Libro
    {
        public int Id;
        public string Titulo;
        public string Autor;
        public int AñoPublicacion;
        public string ISBN; // Podría ser útil agregar (código ISBN para identificar libros de manera única)
        public string Genero; // Podría ser útil agregar (categoría o género del libro)
    }
}

