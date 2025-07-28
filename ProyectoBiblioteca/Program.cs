using ProyectoBiblioteca.Base;
using ProyectoBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
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
                Console.Clear();
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
                        Console.Clear();
                        crearCuenta();
                        break;
                    case "2":
                        Console.Clear();
                        iniciarSesion();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del sistema...");
                        return;
                    case "0801":
                        Console.Clear();
                        RegistrarAdministrador();
                        break;
                    case "2001":
                        Console.Clear();
                        IniciarSesionAdmin();
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
            BaseDeDatos.GuardarDatosUsuario();
            BaseDeDatos.GuardarDatosSesionUsuario();
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
                else if (key.Key == ConsoleKey.Backspace && contraseña.Length > 0) // esa condificonal aplica que si la tecla presiona es backspace no sumará las teclas como "*" dentro de la clave
                {
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
                Console.WriteLine("Usuario encontrado: " + objnombreUsuario.BuscarUsuario()); // Una vez que la base de dato haya validado que existe el nombre de usuario escrito, lo colocará en pantalla y pedirá la clave
                Console.Write("Ingrese su contraseña: ");
                string contraseña = ContraseñaOculta();


                if (objnombreUsuario.ValidarContraseñaUsuario(contraseña)) // Esto llama a la funcion ''ValidarContraseñaUsuario'' para confirmar que la contraseña digitada pertenezca al mismo registro que el nombre de usuario digitado
                {
                    Console.WriteLine();
                    Console.WriteLine("!Sesión iniciada exitosamente!");
                    Console.Write("Presiona ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();

                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║        PLATAFORMA BIBLIOTECA VIRTUAL       ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine($"\t      Bienvenido {objnombreUsuario.BuscarUsuario()}"); // una vez dentro la consola mostrará el nombre de usuario que se usó para el inicio de sesion, mostrando su nombre de usuario y las opciones del menu
                        Console.WriteLine(" DATOS PERSONALES DEL USUARIO:");
                        Console.WriteLine("══════════════════════════════════════════════");
                        objnombreUsuario.ImprimirUsuario();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║                MENU DE USUARIO             ║");
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine(" 1. Ver Perfil de Usuario");
                        Console.WriteLine(" 2. Agregar libro a mi lista");
                        Console.WriteLine(" 3. Listar todos mis libros");
                        Console.WriteLine(" 4. Cerrar Sesión");
                        Console.WriteLine();
                        Console.Write(" Seleccione una opción: ");

                        string opcionUsuario = Console.ReadLine();
                        switch (opcionUsuario)
                        {
                            case "4": // aqui se implemente la misma logica de bucle para permanecer dentro del menu de usuario hasta que la opcion sea cerrar la sesion
                                Console.Clear();
                                Console.WriteLine("Volviendo al Menu Principal.");
                                Console.WriteLine("Presiona ENTER para continuar...");
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

        

        private static void RegistrarAdministrador() // esta funcion es para registrar un ADMINISTRADOR, obviamente oculta en el menú
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**************REGISTRO ADMINISTRADOR***************"); // Sigue el mismo protocolo de registro
            Console.Write("Ingrese su nombre de usuario de ADMIN: "); // Pide ingresar un nombre de usuario ADMIN
            string AdminUsuario = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese su fecha de nacimiento (DD/MM/AA): "); // Fecha de nacimiento del ADMIN
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Ingrese su contraseña: "); // Contraseña del ADMIN, esta parte no tiene validación de contraseña, pq al ser administradores siempre tenemos acceso al menú de ADMINISTRADORES, es solo el protocolo
            string adminContraseña = ContraseñaOculta();
            Console.WriteLine();

            Console.WriteLine("USUARIO ADMINISTRADOR REGISTRADO");
            Console.WriteLine("Ya puedes continuar como administrador.");
            
            Administradores ObjAdmin = new Administradores(AdminUsuario, fechaNacimiento, adminContraseña);
            BaseDeDatos.GuardarDatosAdministradores();
            Console.ReadLine();
            Console.Clear();
        }

        private static void IniciarSesionAdmin() // la misma lógica que en el inicio de sesion para un usuario comun
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Usuario ADMIN: ");
            string AdminUsuario = Console.ReadLine();

            Administradores objAdmin = Base.BaseDeDatos.ObtenerAdminUsuario(AdminUsuario); // verifica que el nombre de usuario de ADMINISTRADOR exista en la base de datos

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
                        Console.ForegroundColor = ConsoleColor.Red; // Esto modifica el color del menú, para distinguir entre menú principal, menu de usuario y menú de ADMINISTRADOR
                        Console.WriteLine("╔════════════════════════════════════════════╗");
                        Console.WriteLine("║             Modo Administrador             ║");  // MENU DE ADMINISTRADOR
                        Console.WriteLine("╚════════════════════════════════════════════╝");
                        Console.WriteLine($"\t     ADMIN: {objAdmin.BuscarUserAdmin()}");
                        objAdmin.ImprimirAdmin();
                        Console.WriteLine();
                        Console.WriteLine("╔════════════════════════════════════════════╗╔════════════════════════════════════════════╗");
                        Console.WriteLine("║            MENU OPCIONAL DE LIBROS         ║║           MENU OPCIONAL DE USUARIOS        ║"); // Se usó este estilo compacto para mejorar el resultado visual, y no ocupar mucho espacio en la pantalla de impresión
                        Console.WriteLine("╚════════════════════════════════════════════╝╚════════════════════════════════════════════╝");
                        Console.WriteLine(" 1. Agregar Libro.                               5. Listar Usuarios.");
                        Console.WriteLine(" 2. Ver Lista de Libros.                         6. Modificar un Usuario.");
                        Console.WriteLine(" 3. Modificar Datos de Libro.                    7. Eliminar un usuario.");
                        Console.WriteLine(" 4. Eliminar Libro.");
                        Console.WriteLine();
                        Console.WriteLine(" 8. Salir al Menú Principal");
                        Console.WriteLine();
                        Console.Write(" Seleccione una opción: ");

                        string opcionAdmin = Console.ReadLine();
                        Console.Clear();
                        switch (opcionAdmin)
                        {
                            case "1": // el bucle de opciones con operaciones solo disponibles para ADMINISTRADORES
                                Console.Clear();
                                AgregarNuevoLibro(); // Registrar un nuevo libro
                                Console.Clear();
                                break;
                            case "2":
                                Console.Clear();
                                ListaLibros(); // Lista de todos los libros
                                Console.Clear();
                                break;
                            case "3":
                                Console.Clear();
                                ModificarLibros(); // Modificar información de libros
                                Console.Clear();
                                break;
                            case "4":
                                Console.Clear();
                                EliminarLibro(); // Eliminar un libro de la lista
                                Console.Clear();
                                break;
                            case "5":
                                Console.Clear();
                                ListaUsuarios(); // Lista de Usuarios
                                Console.Clear();
                                break;
                            case "6":
                                Console.Clear();
                                ModificarUsuarioComoAdmin(); // Modificar Usuarios
                                Console.Clear();
                                break;
                            case "7":
                                Console.Clear();
                                EliminarUsuario(); // Eliminar Usuarios
                                Console.Clear();
                                break;
                            case "8":
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

        /////////////////////////       REGISTRO DE LIBROS       /////////////////////////
        private static void AgregarNuevoLibro()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║      BIENVENIDO AL REGISTRO DE LIBROS      ║"); // Este es el proceso de registrar o añadir un nuevo libro a la biblioteca
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();

            Console.Write("Ingrese el nombre del libro a registrar: "); // Nombre del libro
            string titulo = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el nombre del autor: "); //Nombre del autor
            string autor = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el año de publicación: ");   // año de publicación
            string añoPublicacion = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el estado del libro: "); // código del libro
            string estado = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Ingrese el género literario del libro: "); // género literario al que pertenece el libro
            string genero = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("El libro se ha añadido a la biblioteca correctamente.");
            Libro objLibro = new Libro(titulo, autor, añoPublicacion, estado, genero);
            Console.ReadLine();
            BaseDeDatos.GuardarDatosLibros();
            Console.Clear();
        }

        /////////////////////////       LISTA DE TODOS LOS LIBROS       /////////////////////////
        private static void ListaLibros()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║      LISTA DE LIBROS EN LA BIBLIOTECA      ║"); // Esto imprime la lista completa de todos los libros en la biblioteca
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ImprimirTodosLibros();
            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        /////////////////////////       MODIFICAR LIBROS       /////////////////////////
        private static void ModificarLibros()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║     MODIFICAR LIBROS DE LA BIBLIOTECA      ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ImprimirTodosLibros();
            Console.Write("Escriba la ID del libro que va a modificar: ");

            int libroID = Convert.ToInt32(Console.ReadLine());  // Aun en proceso :D

            Libro objLibro = Base.BaseDeDatos.BuscarLibroPorID(libroID);
            if (objLibro != null)
            {
                Console.Clear();
                Console.WriteLine("Libro seleccionado: "); // Muestra el mensaje de libro encontrado a continuación de sus datos segun la consulta
                objLibro.MostrarLibros();

                Console.Write("Ingrese el nuevo título del libro: "); // Nuevo título del libro
                string NuevoTitulo = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese el nuevo nombre del autor: "); //Nuevo nombre del autor
                string NuevoAutor = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese el año de publicación: ");   // Nuevo año de publicación
                string NuevaFechaPublicacion = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese el estado del libro: "); // Nuevo estado del libro
                string NuevoEstado = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese el nuevo género literario del libro: "); // Nuevo género literario al que pertenece el libro
                string NuevoGenero = Console.ReadLine();
                Console.WriteLine();
                objLibro.Titulo = NuevoTitulo;
                objLibro.Autor = NuevoAutor;
                objLibro.AñoPublicacion = NuevaFechaPublicacion; // se usó este diseño de código para propiedades públicas de la clase (y tambien pq no sabía como retornar con valores INT XD)
                objLibro.Estado = NuevoEstado;
                objLibro.Genero = NuevoGenero;
                Console.WriteLine("Los datos del Libro fueron modificados correctamente");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadLine();
                BaseDeDatos.GuardarDatosLibros();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se encontró el libro especificado.");
                Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        /////////////////////////       ELIMINAR LIBROS       /////////////////////////
        private static void EliminarLibro()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║      ELIMINAR LIBROS DE LA BIBLIOTECA      ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ImprimirTodosLibros();
            Console.Write("Escriba la ID del libro que va a eliminar: ");

            int libroID = Convert.ToInt32(Console.ReadLine());  // Aun en proceso :D

            Libro objLibro = Base.BaseDeDatos.BuscarLibroPorID(libroID);
            if (objLibro != null)
            {
                Console.Clear();
                Console.WriteLine("Libro seleccionado:");
                objLibro.MostrarLibros();
                Console.WriteLine("¿Está seguro que desea eliminar el libro? (S/N)");
                string confirmacion = Console.ReadLine();
                if (confirmacion?.ToUpper() == "S")
                {
                    //BaseDeDatos.EliminarLibro(idLibro); // Código #2 para modificación: Cambiado para pasar el ID en lugar del objeto
                    Base.BaseDeDatos.BaseDatosLibros.Remove(objLibro);
                    BaseDeDatos.ReorganizarIDsLibros();
                    BaseDeDatos.GuardarDatosLibros();
                    Console.WriteLine("Libro eliminado correctamente.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Operación cancelada.");
                    Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se encontró el libro especificado.");
                Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        /////////////////////////       LISTA DE USUARIOS       /////////////////////////
        private static void ListaUsuarios()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║     LISTA DE USUARIOS EN LA BIBLIOTECA     ║"); // Esto imprime la lista completa de todos los libros en la biblioteca
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ListaImprimirUsuarioADM();
            Console.WriteLine();
            Console.WriteLine("Presiona ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        /////////////////////////       MODIFICAR USUARIOS       /////////////////////////
        private static void ModificarUsuarioComoAdmin()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║    MODIFICAR USUARIOS DE LA BIBLIOTECA     ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ListaImprimirUsuarioADM();
            Console.Write("Escriba la ID del Usuario que va a modificar: ");

            int UserModID = Convert.ToInt32(Console.ReadLine());  // Aun en proceso :D

            Usuario objUsuario = Base.BaseDeDatos.BuscarUsuarioPorID(UserModID);
            if (objUsuario != null)
            {
                Console.Clear();
                Console.WriteLine("Usuario seleccionado: "); // Muestra el mensaje de Usuario encontrado a continuación de sus datos segun la consulta
                objUsuario.ImprimirUsuarioParaAdministrador();

                Console.WriteLine("Ingrese el nuevo UserName para este Usuario "); // Nuevo Nombre de Usuario para un Usuario
                string NuevoUserName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ingrese la nueva contraseña para este usuario ");   // Nueva clave para un Usuario
                string NuevaContraseña = Console.ReadLine();
                Console.WriteLine();

                objUsuario.NombreUsuario = NuevoUserName;
                objUsuario.SetNuevaContraseña(NuevaContraseña);
                Base.BaseDeDatos.BaseDatosUsuario.RemoveAt(objUsuario.ObtenerID() - 1);
                Base.BaseDeDatos.BaseDatosUsuario.Insert(objUsuario.ObtenerID() - 1, objUsuario);
                BaseDeDatos.GuardarDatosUsuario();
                Console.WriteLine("Los datos del Usuario fueron modificados correctamente");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se encontró el Usuario especificado.");
                Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        /////////////////////////       ELIMINAR USUARIOS       /////////////////////////
        private static void EliminarUsuario()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║     ELIMINAR USUARIOS DE LA BIBLIOTECA     ║"); // Esto imprime los libros y proporciona las opciones correspondientes para modificar el libro en cuestión
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine();
            BaseDeDatos.ListaImprimirUsuarioADM();
            Console.Write("Escriba la ID del Usuario que va a eliminar: ");

            int UserModID = Convert.ToInt32(Console.ReadLine());  // Aun en proceso :D

            Usuario objUsuario = Base.BaseDeDatos.BuscarUsuarioPorID(UserModID);
            if (objUsuario != null)
            {
                Console.Clear();
                Console.WriteLine("Usuario seleccionado: ");
                objUsuario.ImprimirUsuarioParaAdministrador();
                Console.WriteLine("¿Está seguro que desea eliminar este Usuario? (S/N)");
                string confirmacion = Console.ReadLine();
                if (confirmacion?.ToUpper() == "S")
                {
                    Base.BaseDeDatos.BaseDatosUsuario.Remove(objUsuario);
                    BaseDeDatos.ReorganizarIDsUsuario();
                    BaseDeDatos.GuardarDatosUsuario();
                    Console.WriteLine("Usuario eliminado correctamente.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Operación cancelada.");
                    Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se encontró al Usuario.");
                Console.WriteLine("Volviendo al menu ADMINISTRADOR...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}