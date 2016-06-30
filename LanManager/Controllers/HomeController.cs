using LanManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Equipo() { Name = "Oscar-Pc" });
        }

        [HttpPost]
        public ActionResult Index(Equipo equipo)
        {
            return View(equipo);
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