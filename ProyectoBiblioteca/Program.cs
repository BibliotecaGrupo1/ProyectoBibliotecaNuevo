using ProyectoBiblioteca.Base;
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
            BaseDeDatos.CargarDatos();
            MenuPrincipal(); // esto llama la función de menu principal del programa
        }

        public static void MenuPrincipal() // Esto es el menú principal del programa
        {
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
                Console.WriteLine("░░░░░░░░░░░░░░░║            1. Registrarse                  ║░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░║            2. Iniciar Sesión               ║░░░░░░░░░░░░░░");
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
                        crearCuenta();
                        BaseDeDatos.GuardarDatos();
                        break;
                    case "2":
                        iniciarSesion();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida, intentar de nuevo.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
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
            Console.Write("Ingrese sus nombre: "); // para nombres
            string nombres = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese sus apellidos: ");
            string apellidos = Console.ReadLine(); // para apellidos
            Console.WriteLine();

            Console.Write("Ingrese su fecha de nacimiento: ");
            DateTime Fecha_Nacimiento = Convert.ToDateTime(Console.ReadLine()); // para fecha de nacimiento
            Console.WriteLine();

            Console.Write("Ingrese su nombre de usuario: ");
            string nombreUsuario = Console.ReadLine(); // para nombre de usuario
            Console.WriteLine();

            Console.Write("Ingrese su correo electrónico: ");
            string correo = Console.ReadLine(); // para correo
            Console.WriteLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseña = Console.ReadLine(); // para contraseña
            Console.WriteLine();

            Console.Write("Cuenta Creada con éxito! Presione Enter para continuar...");


            Usuario ObjUsuario = new Usuario(nombres, apellidos, Fecha_Nacimiento, nombreUsuario, correo, contraseña);
            Console.ReadLine();
            Console.Clear();

        }
        // Este método es para iniciar sesión con un usuario ya existente
        private static void iniciarSesion()
        {
            Console.Clear();

            Console.Write("Ingrese su nombre de usuario: "); // aquí pedimos ingresar las credenciales como nombre de usuario o correo electrónico
            string credencial = Console.ReadLine();

            Usuario objnombreUsuario = Base.BaseDeDatos.BuscarNombreUsuario(credencial); // Esto valida la existencia del nombre de usuario en la base de datos de Usuarios
            if (objnombreUsuario == null) // esto es la condicional, si el usuario no existe en la base de datos Usuario, mostrará el mensaje de credencial no registrada, caso contrario, pedirá la clave.
            {
                Console.WriteLine("Usuario no registrado.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Usuario encontrado: " + credencial);
                Console.Write("Ingrese su contraseña: ");
                string claveiniciosesion = Console.ReadLine();

                Usuario objclaveUsuario = Base.BaseDeDatos.BuscarContraseñaUsuario(claveiniciosesion); // esto validará que la clave sea igual a la registrada junto con el usuario
                if (objclaveUsuario == null)
                {
                    Console.WriteLine("Contraseña incorrecta, serás redirigido al menú.");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("!Sesión iniciada exitosamente!");
                    Console.Write("Presiona una tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    SesionIniciadaMenu();
                }
            }

            //nota adicional para actualizar xd




        }

        private static void SesionIniciadaMenu()
        {
            Console.WriteLine("Bienvenido");
        }
    }
}
