using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var blog = db.Blogs.Take(5).ToList();
            return View(blog);
        }

        public PartialViewResult Top2Blogs()
        {
            var top2Blog = db.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(top2Blog);
        }

        public PartialViewResult BlogsForRightSide()
        {
            var rightSideBlog = db.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(rightSideBlog);
        }

        public PartialViewResult ThisWeekTop10Blogs()
        {
            var top10 = db.Blogs.Take(10).ToList();
            return PartialView(top10);
        }

        public PartialViewResult OurBestPlaces()
        {
            var bestPlaces = db.Blogs.Take(3).ToList();
            return PartialView(bestPlaces);
        }

        public PartialViewResult OurBestPlacesRight()
        {
            var bestPlaces = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(bestPlaces);
        }
    }
}