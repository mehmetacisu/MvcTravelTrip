using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var blogs = db.Blogs.ToList();
            return View(blogs);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            blog.Date = DateTime.Now;
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        public ActionResult Delete(int id)
        {
            var blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        public ActionResult Update(int id)
        {
            var blog = db.Blogs.Find(id);
            return View("Update",blog);
        }

        public ActionResult UpdateBlog(Blog blog)
        {
            var blg = db.Blogs.Find(blog.ID);
            blg.Description = blog.Description;
            blg.Header = blog.Header;
            blg.Date = DateTime.Now ;
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        public ActionResult CommentList()
        {
            var comments = db.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult UpdateComment(int id)
        {
            var comment = db.Comments.Find(id);
            return View("UpdateComment",comment);
        }
        public ActionResult FindComment(Comments com)
        {
            var comment = db.Comments.Find(com.ID);
            comment.Username = com.Username;
            comment.Mail = com.Mail;
            comment.Comment = com.Comment;
            db.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}