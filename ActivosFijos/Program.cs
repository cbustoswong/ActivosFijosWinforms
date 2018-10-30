using ActivosFijos.Models;
using ActivosFijos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivosFijos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DefaultUsersAndRoles();
            Application.Run(new FrmLogin());
        }

        static void DefaultUsersAndRoles()
        {
            using (ActivosEntities db = new ActivosEntities())
            {
                // If Admin user doesn't exist, then this block hasn't been run before
                if (db.Usuarios.FirstOrDefault(u => u.Usuario == "admin") != null)
                    return;

                var RoleAdmin = db.Roles.Add(new Roles { Nombre = "Admin" });
                var RoleRRHH = db.Roles.Add(new Roles { Nombre = "RRHH" });
                var RoleLogis = db.Roles.Add(new Roles { Nombre = "Logistica" });
                var RoleCont = db.Roles.Add(new Roles { Nombre = "Contable" });

                db.Usuarios.Add(new Usuarios
                {
                    Usuario = "admin",
                    Nombre = "Miguel",
                    Apellido = "Araujo",
                    Contrasena = SecurePasswordHasher.Hash("asdf1234"),
                    Roles = { RoleAdmin, RoleRRHH, RoleLogis }
                });

                db.Usuarios.Add(new Usuarios
                {
                    Usuario = "wcruz",
                    Nombre = "Winston",
                    Apellido = "Cruz",
                    Contrasena = SecurePasswordHasher.Hash("asdf1234"),
                    Roles = { RoleRRHH }
                });

                db.Usuarios.Add(new Usuarios
                {
                    Usuario = "ldavid",
                    Nombre = "Luis",
                    Apellido = "Laureano",
                    Contrasena = SecurePasswordHasher.Hash("asdf1234"),
                    Roles = { RoleLogis }
                });

                db.SaveChanges();
            }
        }
    }
}
