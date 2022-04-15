using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TheInformationTechnologyCollege.Data;
namespace TheInformationTechnologyCollege.Models
{
    public class TutorDataInitializer : DropCreateDatabaseAlways<TutorContext>
    {
        protected override void Seed(TutorContext context)
        {
            //add the first value in to the class (database)
            Tutor tutor1 = new Tutor();
            tutor1.TutorId = 1;
            tutor1.Name = "Mark";
            tutor1.Surname = "Smith";
            context.Tutors.Add(tutor1);

            //add the second value in to the class (database)
            Tutor tutor2 = new Tutor();
            tutor2.TutorId = 2;
            tutor2.Name = "Mike";
            tutor2.Surname = "Jones";
            context.Tutors.Add(tutor2);

            //add the third value in to the class (database)
            Tutor tutor3 = new Tutor();
            tutor3.TutorId = 3;
            tutor3.Name = "Jasmine";
            tutor3.Surname = "Adams";
            context.Tutors.Add(tutor2);
            base.Seed(context);
        }

    }
}