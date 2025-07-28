using ProyectoBiblioteca.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    [Serializable]
    public class Libro // Esta clase representa un libro en la biblioteca
    {
        public int Id;
        public string Titulo;
        public string Autor;
        public string AñoPublicacion;
        public string Estado; // Podría ser útil agregar (código ISBN para identificar libros de manera única)
        public string Genero; // Podría ser útil agregar (categoría o género del libro)

        public Libro(string titulo, string autor, string añoPublicacion, string estado, string genero) // Constructor de la clase Libros
        {
            int LibroSecuancialID = Base.BaseDeDatos.BaseDatosLibros.Count() + 1;

            this.Id = LibroSecuancialID;
            this.Titulo = titulo;
            this.Autor = autor;
            this.AñoPublicacion = añoPublicacion;
            this.Estado = estado;
            this.Genero = genero;

            BaseDeDatos.BaseDatosLibros.Add(this);
        }
        public void MostrarLibros() // Esto imprime los datos de los libros
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Título: " + this.Titulo);
            Console.WriteLine("Autor: " + this.Autor);
            Console.WriteLine("Año de Publicación: " + this.AñoPublicacion);
            Console.WriteLine("Estado del Libro: " + this.Estado);
            Console.WriteLine("Género: " + this.Genero);
            Console.WriteLine();
            Console.WriteLine("..............................................");
            Console.WriteLine();
        }

        public bool BuscarLibroID(int id)
        {
            return this.Id == id;
        }

    }
}


