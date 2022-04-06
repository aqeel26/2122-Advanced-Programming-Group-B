using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheInformationAndTechnologyCollege.Models
{
    public class Users
    {

        public virtual int UsersID { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string PostCode { get; set; }
    }
}