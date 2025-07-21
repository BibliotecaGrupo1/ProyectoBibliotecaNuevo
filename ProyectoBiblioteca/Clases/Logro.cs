using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa un logro que un usuario puede obtener en la biblioteca
    public class Logro
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public string MedallaAsociada;
        public int PuntosRecompensa;
        public TipoLogro Tipo; // Enum para tipos de logros
        public int Meta; // Por ejemplo: 5 libros leídos
    }
    // Enum para los tipos de logros
    public enum TipoLogro
    {
        PrimerLibroLeido,
        LibrosLeidos,
        FavoritosMarcados,
        // Otros tipos según necesidades
    }
}