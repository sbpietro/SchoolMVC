using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolMVC.Entities
{
    public class Student
    {
        public Student()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Standard Standard { get; set; }

    }
}