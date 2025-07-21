using ProyectoBiblioteca.Base;
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

        public Libro(int id, string titulo, string autor, int añoPublicacion, string iSBN, string genero)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            ISBN = iSBN;
            Genero = genero;
        }
        public void Imprimir()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año de Publicación: " + AñoPublicacion);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Género: " + Genero);
        }
        // Método para obtener el código del libro (ISBN)
        public string getCodigo()
        {
            return ISBN;
        }

    }
    }


