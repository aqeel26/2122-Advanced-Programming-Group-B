using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationTechnologyCollege.Models
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual string CourseName { get; set; }
    }
}