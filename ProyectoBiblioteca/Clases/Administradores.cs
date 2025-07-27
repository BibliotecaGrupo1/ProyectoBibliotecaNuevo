using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBiblioteca.Base;

namespace ProyectoBiblioteca.Clases
{
    [Serializable]
    public class Administradores
    {
        private int ID;
        private string AdminUsuario;
        private string TAG;
        private string AdminUserID;
        private DateTime FechaNacimiento;
        private int edad;
        private string AdminContraseña;

        public Administradores(string adminUsuario, DateTime fechaNacimiento, string adminContraseña)
        {
            int AdminIDSecuencial = BaseDeDatos.BaseDatosAdministradores.Count() + 1;
            
            this.ID = AdminIDSecuencial;
            this.AdminUsuario = adminUsuario;
            this.TAG = " #0010"; // Tag especifico para Administradores
            this.AdminUserID = adminUsuario + TAG;
            this.FechaNacimiento = fechaNacimiento;
            this.edad = DateTime.Now.Year - FechaNacimiento.Year;
            this.AdminContraseña = adminContraseña;

            BaseDeDatos.BaseDatosAdministradores.Add(this);
        }

        public void ImprimirAdmin()
        {
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine(" DATOS DE ADMINISTRADOR:");
            Console.WriteLine(" ID: " + this.ID);
            Console.WriteLine(" ADMIN: " + this.AdminUserID);
            Console.WriteLine(" Edad: " + this.edad);

        }

        public string BuscarUserAdmin()
        {
            return this.AdminUsuario;
        }

        public bool ValidarContraseñaAdmin(string claveUser)
        {
            return this.AdminContraseña == claveUser;
        }
    }
}
