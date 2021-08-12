using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelWebApp.Models.Classes;

namespace TravelWebApp.Controllers
{
    public class AdminController : Controller
    {
        _DbContext context = new _DbContext();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {
            context.Blogs.Add(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlog", blog);
        }

        public ActionResult EditBlog(Blog blog)
        {
            var blg = context.Blogs.Find(blog.ID);
            blg.Explanation = blog.Explanation;
            blg.Header = blog.Header;
            blg.Date = blog.Date;
            blg.BlogImageURL = blog.BlogImageURL;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult GetComment(int id)
        {
            var comment = context.Comments.Find(id);
            return View("GetComment", comment);
        }

        public ActionResult EditComment(Comment comment)
        {
            var cm = context.Comments.Find(comment.ID);
            cm.Username = comment.Username;
            cm.Mail = comment.Mail;
            cm.Comments = comment.Comments;
            cm.Blog = comment.Blog;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}