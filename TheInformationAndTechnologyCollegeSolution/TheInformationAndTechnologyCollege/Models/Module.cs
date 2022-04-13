using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationAndTechnologyCollege.Models
{
    public class Module
    {
        virtual public int ModuleId { get; set; }
        virtual public string ModuleTitle { get; set; }
        virtual public string Description { get; set; }
        virtual public string Contents { get; set; }
        virtual public Course Course { get; set; }
        virtual public Tutor Tutor { get; set; }
        

    }
}