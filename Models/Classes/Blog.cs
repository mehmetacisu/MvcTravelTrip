using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogPhoto { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}