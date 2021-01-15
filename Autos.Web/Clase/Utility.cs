using Autos.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autos.Web.Clase
{
    public class Utility
    {
        readonly static ApplicationDbContext db = new ApplicationDbContext();

        public static void CheckRoles(string rol)
        {
            var role = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!role.RoleExists(rol))
            {
                role.Create(new IdentityRole(rol));
            }
        }

        internal static void CheckSuperUser()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = userManager.FindByName("admin@autos.com");
            if (user == null)
            {
                CreateSuperUser("admin@autos.com", "123456", null, "Administrador"); // Generar metodo click derecho
            }
        }

        private static void CreateSuperUser(string email, string pass, string phone, string rol)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser()
            {
                UserName = email,
                Email = pass,
                PhoneNumber = phone
            };

            userManager.Create(user, pass);
            userManager.AddToRole(user.Id, rol);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}