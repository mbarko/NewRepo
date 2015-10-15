using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chillzone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        //Adham change 3
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Edited string. Again. GOOOOOOO 2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}