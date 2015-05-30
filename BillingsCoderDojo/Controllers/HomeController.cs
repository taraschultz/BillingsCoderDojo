using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillingsCoderDojo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
			ViewBag.Message = "CoderDojo is about encouraging creativity and having fun in a relaxed, social environment.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Billings CoderDojo Contact";

            return View();
        }
    }
}