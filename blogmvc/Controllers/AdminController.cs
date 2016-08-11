using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blogmvc.Models;

namespace blogmvc.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //GET UserProfile
        public ActionResult UserProfile()
        {
            //comprobar datos que se muestran en el formulario

            return View("User", db.Option.ToList());


        }
        public ActionResult UserView()
        {
            return View("User");
        }
        /*
        public ActionResult UserSend ()
        {

        }
        */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditOption()
        {
            //realizaremos el registro de los datos 
            List<Option> Loption = new List<Option>
            {
                new Option { OptionName = "siteurl", OptionValue = UserViewModel.siteurl, Autoload = "yes" },
                new Option { OptionName = "home", OptionValue = UserViewModel.home, Autoload = "yes" },
                new Option { OptionName = "blogname", OptionValue = UserViewModel.blogname, Autoload = "yes" },
                new Option { OptionName = "blogdescription", OptionValue = UserViewModel.bogdescription, Autoload = "yes" },
                //este campo es el que cualquier usuario puede registrarse
                new Option { OptionName = "users_can_register", OptionValue = UserViewModel.user_can_register, Autoload = "yes" },
                new Option { OptionName = "posts_per_page", OptionValue = UserViewModel.post_per_page, Autoload = "yes" },
                new Option { OptionName = "admin_email", OptionValue = UserViewModel.admin_email, Autoload = "yes" },



            };
            Loption.ForEach(s => db.Option.Add(s));
            db.SaveChanges();
            return View("User");
        }

    }
}