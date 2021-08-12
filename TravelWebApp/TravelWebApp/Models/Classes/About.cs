using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebApp.Models.Classes
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string ImageURL { get; set; }
        public string Explanation { get; set; }
    }
}