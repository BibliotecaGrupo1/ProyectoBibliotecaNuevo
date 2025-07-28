using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.Clases
{
    // Esta clase representa un logro que un usuario puede obtener en la biblioteca
    [Serializable]
    public class Logro
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public string MedallaAsociada;
        public TipoLogro Tipo; // Enum para tipos de logros
        public int Meta; // Por ejemplo: 5 libros leídos

        public Logro(int id, string nombre, string descripcion, string medallaAsociada, TipoLogro tipo, int meta)
        {
            int secuenciaID = Base.BaseDeDatos.BaseDatosUsuario.Count() + 1;
            this.Id = secuenciaID;
            Nombre = nombre;
            Descripcion = descripcion;
            MedallaAsociada = medallaAsociada;
            Tipo = tipo;
            Meta = meta;
        }
    }
    // Enum para los tipos de logros
    public enum TipoLogro
    {
        PrimerLibroAgregado,
        CincoLibrosAgregados,
        // Otros tipos según necesidades
    }
}