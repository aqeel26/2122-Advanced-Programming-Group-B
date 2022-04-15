namespace TheInformationTechnologyCollege.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using TheInformationTechnologyCollege.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TheInformationTechnologyCollege.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TheInformationTechnologyCollege.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            /*
            var courses = new List<Course>
            {
                new Course{CourseID=1, CourseName="Computer Science"},
                new Course{CourseID=2, CourseName="Software Enginering"},
                new Course{CourseID=3, CourseName="Cyber Security"}
            };
            
            courses.ForEach(course => context.Course.AddOrUpdate(p => p.courseId, course));
            context.SaveChanges();*/
        }
    }
}
