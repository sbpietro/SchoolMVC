using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolMVC.Entities
{
    public class Standard
    {
        public Standard()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Student> Students { get; set; }

    }
}