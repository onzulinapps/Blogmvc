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
            Option Option = new Option();
            List<Option> Options = db.Option.ToList();
            //return View(Options);
            /*
            int count = Options.Count();
            for (int i = 0; i < count; i++ )
            {
                Options.ElementAt(i);
            }*/
            * /*
            if (ModelState.IsValid)
            {
                foreach (string OptionName in Options)
                {

                } 
                
            }
            */
            return View("User", Options);
        }

    }
}