using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebApp.Models.Classes;

namespace TravelWebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        _DbContext context = new _DbContext();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(8).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = context.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = context.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial5()
        {
            var values = context.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(values);
        }
    }
}