using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UserRegistration()
        {
            string[] UserDetails = { "First Name", "Last Name", "Email", "Phone Number", "Password"};
            ViewBag.UserDetails = User;
            return View();
        }

        public ActionResult Add(string firstname, string lastname, string email, string phonenumber, string password)
        {
            ViewBag.Message = firstname;
            return View ("User");
        }
        
        

    }
}