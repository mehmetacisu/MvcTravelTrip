using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public string LocationAdress { get; set; }

        public string Phone { get; set; }

        public string Location { get; set; }

    }
}