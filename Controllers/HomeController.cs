using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SvavengerHuntList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Round1()
        {
            return View();
        }

        public ActionResult Final()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Round2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}