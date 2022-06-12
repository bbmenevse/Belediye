using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Belediye.Models;

namespace Belediye.Controllers
{
    public class LoginController : Controller
    {
        private NarailDBEntities _db = new NarailDBEntities();
        public ActionResult Index()
        {
            var model = _db.Author.ToList();
            return View();
        }
    }
}