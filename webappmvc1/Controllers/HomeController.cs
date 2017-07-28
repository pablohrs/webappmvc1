using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webappmvc1.Models;

namespace webappmvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Servicio _miclass = new Servicio();

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
    }
}