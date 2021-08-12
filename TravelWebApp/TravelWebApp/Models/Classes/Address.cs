using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebApp.Models.Classes
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Explanation { get; set; }
        public string OpenAddress { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string Location { get; set; }
    }
}