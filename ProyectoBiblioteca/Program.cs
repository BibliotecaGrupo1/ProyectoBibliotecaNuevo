using ProyectoBiblioteca.Base;
using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDatos.CargarDatosLibros();
            BaseDeDatos.CargarDatosAdministradores();
            BaseDeDatos.CargarDatosUsuario();
            BaseDeDatos.CargarDatosSesionUsuario();
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
                        BaseDeDatos.GuardarDatosUsuario();
                        BaseDeDatos.GuardarDatosSesionUsuario();
                        break;
                    case "2":
                        iniciarSesion();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    case "0801":
                        RegistrarAdministrador();
                        BaseDeDatos.GuardarDatosAdministradores();
                        break;
                    case "2001":
                        IniciarSesionAdmin();
                        break;
                    case "4":
                        ListaCompleta();
                        break;
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

            Console.Write("Ingrese su fecha de nacimiento (Use el formato DD/MM/AA): ");
            DateTime Fecha_Nacimiento = Convert.ToDateTime(Console.ReadLine()); // para fecha de nacimiento
            Console.WriteLine();

            Console.Write("Ingrese su nombre de usuario: ");
            string nombreUsuario = Console.ReadLine(); // para nombre de usuario
            Console.WriteLine();

            Console.Write("Ingrese su correo electrónico: ");
            string correo = Console.ReadLine(); // para correo
            Console.WriteLine();

            Console.Write("Ingrese su contraseña: ");
            string contraseña = ContraseñaOculta(); // para contraseña
            Console.WriteLine();

            Console.Write("Confirme su contraseña: ");
            string confirmacionContraseña = ContraseñaOculta(); // para confirmar contraseña
            Console.WriteLine();

            if (contraseña != confirmacionContraseña) // esto valida que la contraseña y su confirmación sean iguales
            {
                Console.WriteLine("Las contraseñas no coinciden. Intente de nuevo.");
                Console.ReadLine();
                Console.Clear();
                crearCuenta(); // vuelve a llamar al método para crear cuenta si las contraseñas no coinciden
                return;
            }

            Console.Write("Cuenta Creada con éxito! Presione Enter para continuar..."); // El mensaje que se mostrará cuando el registro se complete correctamente.
            Usuario ObjUsuario = new Usuario(nombres, apellidos, Fecha_Nacimiento, nombreUsuario, correo, contraseña);
            SesionUsuario objSesionUsuario = new SesionUsuario(nombreUsuario, correo);
            Console.ReadLine();
            Console.Clear();

        }

        public static string ContraseñaOculta() // Esta funcion permite realizar la creación de contraseña privada ocultando los caracteres e imprimiento "*" en lugar de mostrar las letras
        { 
            string contraseña = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true); // lee las letras ingresadas
                if (!char.IsControl(key.KeyChar)) // esto define un operador NOT lógico usando "!" = "si la tecla ingresada NO es una tecla de control''
                {
                    contraseña += key.KeyChar; // la funcion contraseña = contraseña + caracter, pero simplificada
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && contraseña.Length > 0) // esa condificonal aplica que si la tecla presiona es backspace
                {                                                                  // no sumará las teclas como "*" dentro de la clave
                    contraseña = contraseña.Remove(contraseña.Length - 1);         
                    Console.Write("\b \b");  // el uso del doble "\b" es para borrar correctamente los caracteres dentro del campo de la contraseña, uno coloca el cursor al final de la palabra mientras que el otro elimina correctamente los *, si se usara solo uno, borraría el caracter pero en la pantalla seguiría apareciendo el "*"
                }
                
                /*else if (key.Key == ConsoleKey.Backspace && contraseña.Length > 0) // codigo para modificar, soporta la combinación cntrl + borrar, sirve para borrar toda la palabra
                {
                    // Verifica si Ctrl está presionado SIN consumir la siguiente tecla
                    bool ctrlPresionado = (ConsoleModifiers.Control & key.Modifiers) != 0;

                    if (ctrlPresionado)
                    {
                        // Borrar toda la palabra/password
                        while (contraseña.Length > 0)
                        {
                            contraseña = contraseña.Remove(contraseña.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        // Borrado normal (un solo carácter)
                        contraseña = contraseña.Remove(contraseña.Length - 1);
                        Console.Write("\b \b");
                    }
                }*/
            }
            while (key.Key != ConsoleKey.Enter); // Mientras la tecla presionada no sea ENTER el campo seguirá recibiendo cada caracter como parte de la contraseña, exceptuando las teclas de comando
            Console.WriteLine();
            return contraseña;
        }

        // Este método es para iniciar sesión con un usuario ya existente
        private static void iniciarSesion()
        {
            Console.Clear();
            Console.Write("Ingrese su nombre de usuario: "); // aquí pedimos ingresar las credenciales como nombre de usuario

            string credencial = Console.ReadLine();

            Usuario objnombreUsuario = Base.BaseDeDatos.BuscarNombreUsuario(credencial); // Esto valida la existencia del nombre de usuario en la base de datos de Usuarios

            if (objnombreUsuario == null)  // esto es la condicional, si el usuario no existe en la base de datos Usuario, mostrará el mensaje de credencial no registrada, caso contrario, pedirá la clave.
            {
                Console.WriteLine("Usuario no registrado.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Usuario encontrado: " + objnombreUsuario.BuscarUsuario());
                Console.Write("Ingrese su contraseña: ");
                string contraseña = ContraseñaOculta();


                if (objnombreUsuario.ValidarContraseñaUsuario(contraseña))
                {
                    Console.WriteLine("!Sesión iniciada exitosamente!");
                    Console.Write("Presiona una tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();

                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║        PLATAFORMA BIBLIOTECA VIRTUAL       ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine($"\t      Bienvenido {objnombreUsuario.BuscarUsuario()}");
                        objnombreUsuario.ImprimirUsuario();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║                MENU DE USUARIO             ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine(" 3. Ver Perfil de Usuario");
                        Console.WriteLine(" 1. Agregar libro a mi lista");
                        Console.WriteLine(" 2. Listar todos mis libros");
                        Console.WriteLine(" 4. Salir al Menú Principal");
                        Console.WriteLine();
                        Console.Write(" Seleccione una opción: ");

                        string opcionUsuario = Console.ReadLine();
                        switch (opcionUsuario)
                        {
                            case "4":
                                Console.Clear();
                                Console.WriteLine("Volviendo al menu principal...");
                                Console.ReadLine();
                                Console.Clear();
                                return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, serás redirigido al menú.");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
        }

        

        private static void RegistrarAdministrador()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**************REGISTRO ADMINISTRADOR***************");
            Console.Write("Ingrese su nombre de usuario de ADMIN: ");
            string AdminUsuario = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese su fecha de nacimiento (DD/MM/AA): ");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese su contraseña: ");
            string adminContraseña = ContraseñaOculta();
            Console.WriteLine();

            Console.WriteLine("USUARIO ADMINISTRADOR REGISTRADO");
            Console.WriteLine("Ya puedes continuar como administrador.");
            
            Administradores ObjAdmin = new Administradores(AdminUsuario, fechaNacimiento, adminContraseña);
            Console.ReadLine();
            Console.Clear();
        }

        private static void IniciarSesionAdmin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Usuario ADMIN: ");
            string AdminUsuario = Console.ReadLine();

            Administradores objAdmin = Base.BaseDeDatos.ObtenerAdminUsuario(AdminUsuario);

            if (objAdmin == null)  // esto es la condicional, si el usuario no existe en la base de datos Usuario, mostrará el mensaje de credencial no registrada, caso contrario, pedirá la clave.
            {
                Console.WriteLine("ADMIN no registrado.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Usuario encontrado: " + objAdmin.BuscarUserAdmin());
                Console.Write("Ingrese su contraseña: ");
                string contraseña = ContraseñaOculta();

                if (objAdmin.ValidarContraseñaAdmin(contraseña))
                {
                    while (true)
                    {
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║             Modo Administrador             ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine($"\t     ADMIN: {objAdmin.BuscarUserAdmin()}");
                        objAdmin.ImprimirAdmin();
                        Console.WriteLine();
                        Console.WriteLine("╔════════════════════════════════════════════╗╔════════════════════════════════════════════╗");
                        Console.WriteLine("║            MENU OPCIONAL DE LIBROS         ║║           MENU OPCIONAL DE USUARIOS        ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝╚════════════════════════════════════════════╝");
                        Console.WriteLine(" 1. Agregar Libro.                               5. Listar Usuarios.");
                        Console.WriteLine(" 2. Ver Lista de Libros.                         6. Listar Sesiones de Usuario.");
                        Console.WriteLine(" 3. Modificar Datos de Libro.                    7. Modificar un Usuario.");
                        Console.WriteLine(" 4. Eliminar Libro.                              8. Eliminar un usuario.");
                        Console.WriteLine();
                        Console.WriteLine(" 9. Salir al Menú Principal");
                        Console.WriteLine();
                        Console.Write(" Seleccione una opción: ");

                        string opcionAdmin = Console.ReadLine();

                        switch (opcionAdmin)
                        {
                            case "1":
                                Console.Clear();
                                AgregarNuevoLibro();
                                BaseDeDatos.GuardarDatosLibros();
                                break;
                            case "2":
                                Console.Clear();
                                ListaLibros();
                                break;
                            case "3":
                                break;
                            case "9":
                                Console.WriteLine("Saliendo del modo ADMIN...");
                                Console.ReadLine();
                                Console.Clear();
                                return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No ha sido posible iniciar sesión");
                }
            }
        }

        private static void AgregarNuevoLibro()
        {
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║      BIENVENIDO AL REGISTRO DE LIBROS      ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();

            Console.Write("Ingrese el nombre del libro a registrar: ");
            string titulo = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el nombre del autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el año de publicación: ");
            string añoPublicacion = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el código del libro: ");
            string iSBN = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el género literario del libro: ");
            string genero = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("El libro se ha añadido a la biblioteca correctamente.");
            Libro objLibro = new Libro(titulo, autor, añoPublicacion, iSBN, genero);
            Console.ReadLine();
            Console.Clear();
        }

        private static void ListaLibros()
        {
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║      LISTA DE LIBROS EN LA BIBLIOTECA      ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ImprimirTodosLibros();
            Console.ReadLine();
        }

        private static void ListaCompleta()
        {
            Console.Clear();
            BaseDeDatos.ListaImprimirUsuario();
            BaseDeDatos.ListaImprimirAdmins();
            BaseDeDatos.ImprimirTodosLibros();
            Console.ReadLine();
            Console.Clear();
        }
    }
}