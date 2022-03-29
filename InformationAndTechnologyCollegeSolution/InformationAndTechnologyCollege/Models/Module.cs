using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationAndTechnologyCollege.Models
{
    public class Module
    {
        //is genrate the database code based on these propeties automatically
        public virtual int ModuleID { get; set; }
        public virtual string ModuleCode { get; set; }
        public virtual string ModulTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContents { get; set; }
    }
}