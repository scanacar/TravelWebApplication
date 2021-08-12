﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelWebApp.Models.Classes
{
    public class _DbContext: DbContext
    {
        public _DbContext() : base("Context") { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}