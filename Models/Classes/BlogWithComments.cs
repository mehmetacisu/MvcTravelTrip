using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class BlogWithComments
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Comments> Comments { get; set; }

        public IEnumerable<Blog> Top3Blog { get; set; }
    }
}