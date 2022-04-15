using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TheInformationTechnologyCollege.Data;

namespace TheInformationTechnologyCollege.Models
{
    public class CourseDataInitializer : DropCreateDatabaseAlways<CourseContext>
    {

        protected override void Seed(CourseContext context)
        {
            //add the first value in to the class (database)
            Course course1 = new Course();
            course1.CourseID = 1;
            course1.CourseName = "Computer Science";
            context.Courses.Add(course1);
            //add the second value in to the class (database)
            Course course2 = new Course();
            course2.CourseID = 2;
            course2.CourseName = "Software Engineering";
            context.Courses.Add(course2);
            //add the third value in to the class (database)
            Course course3 = new Course();
            course3.CourseID = 3;
            course3.CourseName = "Cyber Security";
            context.Courses.Add(course3);
            base.Seed(context);
        }
    }
}