using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationTechnologyCollege.Models
{
    public class StudentRegistration
    {
        public virtual int StudentRegistrationID { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string PostCode { get; set; }

        public virtual Course course { get; set; }
    }
}