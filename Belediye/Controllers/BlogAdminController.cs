using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Belediye.Controllers
{
    public class BlogAdminController : Controller
    {
        // GET: BlogAdmin
        public ActionResult Index()
        {
            ViewBag.Title = "Adminhome";
            return View();
        }
    }
}