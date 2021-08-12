using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebApp.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Explanation { get; set; }
    }
}