using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebApp.Models.Classes;

namespace TravelWebApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        _DbContext context = new _DbContext();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}