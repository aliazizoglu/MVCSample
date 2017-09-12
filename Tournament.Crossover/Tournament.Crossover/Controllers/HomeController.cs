using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tournament.Crossover.Controllers
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

        public ActionResult GetAllCustomers()
        {
            return View();
        }

        [Authorize]
        public string GetAllDnn9019Method()
        {
            return "Hello from GetAllDnn9019Method method";

        }

    }
}