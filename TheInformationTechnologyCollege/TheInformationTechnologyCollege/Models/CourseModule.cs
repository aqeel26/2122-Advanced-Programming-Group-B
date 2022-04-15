using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationTechnologyCollege.Models
{
    public class CourseModule
    {
        virtual public int CourseModuleID { get; set; }
        virtual public Course Course { get; set; }
        virtual public Module Module { get; set; }
    }
}