using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Esto es el menú principal del programa
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░██████╗░██╗██████╗░██╗░░░░░██╗░█████╗░████████╗███████╗░█████╗░░█████╗░░░");
                Console.WriteLine("░░██╔══██╗██║██╔══██╗██║░░░░░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██╔══██╗░░");
                Console.WriteLine("░░██████╦╝██║██████╦╝██║░░░░░██║██║░░██║░░░██║░░░█████╗░░██║░░╚═╝███████║░░");
                Console.WriteLine("░░██╔══██╗██║██╔══██╗██║░░░░░██║██║░░██║░░░██║░░░██╔══╝░░██║░░██╗██╔══██║░░");
                Console.WriteLine("░░██████╦╝██║██████╦╝███████╗██║╚█████╔╝░░░██║░░░███████╗╚█████╔╝██║░░██║░░");
                Console.WriteLine("░░╚═════╝░╚═╝╚═════╝░╚══════╝╚═╝░╚════╝░░░░╚═╝░░░╚══════╝░╚════╝░╚═╝░░╚═╝░░");
                Console.WriteLine("░░░░░░░░░░██╗░░░██╗██╗██████╗░████████╗██╗░░░██╗░█████╗░██╗░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░██║░░░██║██║██╔══██╗╚══██╔══╝██║░░░██║██╔══██╗██║░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░╚██╗░██╔╝██║██████╔╝░░░██║░░░██║░░░██║███████║██║░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░╚████╔╝░██║██╔══██╗░░░██║░░░██║░░░██║██╔══██║██║░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░╚██╔╝░░██║██║░░██║░░░██║░░░╚██████╔╝██║░░██║███████╗░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░╚═╝░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚══════╝░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░╔════════════════════════════════════════════╗░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║        MENU        DE      OPCIONES        ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░╠════════════════════════════════════════════╣░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║            1. Iniciar Sesión               ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║            2. Registrarse                  ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║            3. salir                        ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░╠════════════════════════════════════════════╣░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║            Ingrese una Opcion:             ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░╚════════════════════════════════════════════╝░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                string opcion = Console.ReadLine();

                // esta parte del código es para validar la opción ingresada por el usuario
                switch (opcion)
                {
                    case "1":
                        iniciarSesion();
                        break;
                    case "2":
                        crearCuenta();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        
                        return;
                }
            }
        }
        // Este método es para crear una cuenta de usuario
        private static void crearCuenta()
        {
            // Aquí se implementa la lógica para crear una cuenta de usuario
           Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************INGRESE UN NUEVO USUARIO***************");
            Console.WriteLine();
            
            // Solicitar al usuario que ingrese sus datos
            Console.WriteLine();
            Console.Write("Ingrese su nombre completo: ");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su correo:  ");
            string correo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese su contraseña:   ");
            string contraseña = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Cuenta Creada con éxito! Presione Enter para continuar...");
  
            Usuario ObjUsuario = new Usuario(0, nombre, "", nombreUsuario, contraseña, correo, 0, new List<Logro>(), new List<LibroEstado>());
            Console.ReadLine();

        }
        // Este método es para iniciar sesión con un usuario ya existente
        private static void iniciarSesion()
        {
            Console.Clear();

            Console.Write("Ingrese su correo o nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.Clear();    

            Console.WriteLine("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            Console.ReadLine();
            Console.Clear();
            while (true)
            {
                // Aquí se implementa la lógica para verificar las credenciales del usuario
                // Por simplicidad, asumimos que las credenciales son correctas si el usuario y la contraseña no están vacíos
                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("¡Inicio de sesión exitoso!");
                    Console.WriteLine("Bienvenido, " + usuario + "!");
                    Console.ReadLine();
                    Console.WriteLine("Ingrese su libro a buscar por (codigo, nombre, autor o año) : ");
                    String busqueda = Console.ReadLine();
                    Libro objLibroConsulta = Base.BaseDeDatos.GetLibroPorCodigo(busqueda);
                    if (objLibroConsulta == null)
                    {
                        Console.WriteLine("No se encontró un libro con la busqueda proporcionada.");

                    }
                    else
                    {
                        Console.WriteLine("Libro encontrado:");
                        objLibroConsulta.Imprimir();
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Credenciales incorrectas. Intente nuevamente.");
                    Console.ReadLine();
                    return;
                }
            }

        }
    }
}
