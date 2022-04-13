using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationAndTechnologyCollege.Models
{
    public class Tutor
    {
        virtual public int TutorId { get; set; }
        virtual public string Name { get; set; }
        virtual public string Surname { get; set; }
        
    }
}