using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebApp.Models.Classes;

namespace TravelWebApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        _DbContext context = new _DbContext();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = context.Blogs.ToList();
            bc.Value1 = context.Blogs.ToList();
            bc.Value3 = context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetails(int id)
        {
            //var findBlog = context.Blogs.Where(x => x.ID == id).ToList();
            bc.Value1 = context.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = context.Comments.Where(x => x.BlogId == id).ToList();
            bc.Value3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult AddComment(Comment c)
        {
            context.Comments.Add(c);
            context.SaveChanges();
            return PartialView();
        }
    }
}