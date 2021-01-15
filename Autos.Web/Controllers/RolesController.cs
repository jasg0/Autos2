using Autos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autos.Web.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles
        readonly ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            return View(users);
        }
    }
}