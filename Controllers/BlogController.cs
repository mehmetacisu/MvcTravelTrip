using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();
        BlogWithComments bwc = new BlogWithComments();
        public ActionResult Index()
        {
            //var blogs = db.Blogs.ToList();
            bwc.Blogs = db.Blogs.ToList();
            return View(bwc);
        }

        public ActionResult Detay(int id)
        {
            //var blog = db.Blogs.Where(x => x.ID == id).ToList();
            bwc.Blogs = db.Blogs.Where(x=>x.ID == id).ToList();
            bwc.Comments = db.Comments.Where(x => x.BlogID == id).ToList();
            return View(bwc);
        }

        public PartialViewResult Top3Blog()
        {
            //OrderByDescending -> z to a 
            bwc.Top3Blog = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(bwc);
        }

        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            TempData["bID"] = id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult Comment(Comments com)
        {
            db.Comments.Add(com);
            db.SaveChanges();
            return PartialView();
        }
    }
}