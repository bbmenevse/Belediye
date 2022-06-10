using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Belediye.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Anasayfa"; // Sekme ismi
            return View();
        }

        public ActionResult Slider()
        {
            ViewBag.Title = "Resim";
            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Title = "Bilgiler";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Hakkimizda";
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Title = "Projeler";
            return View();
        }
        public ActionResult Counter()
        {
            ViewBag.Title = "Sayac?";
            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";
            return View();
        }
    }
}