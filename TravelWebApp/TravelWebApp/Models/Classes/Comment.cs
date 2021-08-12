using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelWebApp.Models.Classes
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Comments { get; set; }
        public int BlogId { get; set; }
        // Bir comment sadece bir bloga ait olabilir.
        public virtual Blog Blog { get; set; }
    }
}