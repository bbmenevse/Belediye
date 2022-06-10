using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Belediye.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "Bloging";
            return View();
        }

        public ActionResult Category()
        {
            ViewBag.Title = "Blog";
            return View();
        }

        public ActionResult Populer()
        {
            ViewBag.Title = "Blog";
            return View();
        }

        public ActionResult Tag()
        {
            ViewBag.Title = "Blog";
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Title = "Blog";
            return View();
        }


    }
}