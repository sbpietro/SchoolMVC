using SchoolMVC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolMVC.Context
{
    public class Context : DbContext
    {
        public Context() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Stardards { get; set; }
    }
}