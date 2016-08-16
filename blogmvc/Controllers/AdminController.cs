﻿using System;
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
            //el List para rellenar el dropdownlist 
            List<SelectListItem> UserCanRegister = new List<SelectListItem>()
            {
                new SelectListItem {Text = "No", Value = "0", Selected = true },
                new SelectListItem {Text = "Yes", Value = "1" }
            };
            ViewBag.UserCanRegister = UserCanRegister;
            //ViewData["DropDownListUsers"] = UserCanRegister;
            return View("User");


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
        public ActionResult EditOption(UserViewModels UserViewModel)
        {

            string userCanRegister = Request.Form["UserCanRegister"].ToString();
            if (userCanRegister == "0")
            {
                UserViewModel.user_can_register = "No";
            }
            else if (userCanRegister == "1")
            {
                UserViewModel.user_can_register = "Yes";
            }
            //UserViewModel.user_can_register = Request.Form["UserCanRegister"].ToString();
            //como lo que queremos hacer es darle el valor No o Si pues lo cambiamos a mano
            //realizaremos el registro de los datos 
            List<Option> Loption = new List<Option>
            {
                new Option { OptionName = "siteurl", OptionValue = UserViewModel.siteurl, Autoload = "yes" },
                new Option { OptionName = "home", OptionValue = UserViewModel.home, Autoload = "yes" },
                new Option { OptionName = "blogname", OptionValue = UserViewModel.blogname, Autoload = "yes" },
                new Option { OptionName = "blogdescription", OptionValue = UserViewModel.blogdescription, Autoload = "yes" },
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