using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebApp.Models.Classes
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string BlogImageURL { get; set; }
        // Bir blogta birden fazla comment olabilir.
        public ICollection<Comment> Comments { get; set; }
    }
}