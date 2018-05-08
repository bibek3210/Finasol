using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{FirstName="Bibek",LastName="Thapa",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Manish",LastName="Thapa",EnrollmentDate=DateTime.Parse("2008-07-13")},
                new Student{FirstName="Sugam",LastName="Bhandari",EnrollmentDate=DateTime.Parse("2008-07-15")},
                new Student{FirstName="Sushant",LastName="Kc",EnrollmentDate=DateTime.Parse("2007-09-23")},
                new Student{FirstName="Binod",LastName="Karki",EnrollmentDate=DateTime.Parse("2005-05-14")},
                new Student{FirstName="Rupesh",LastName="Niraula",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1001,Title="Chemistry",Credits=3},
                new Course{CourseID=1002,Title="Physics",Credits=3},
                new Course{CourseID=1003,Title="Health",Credits=3},
                new Course{CourseID=1004,Title="Social",Credits=3},
                new Course{CourseID=1005,Title="English",Credits=3}
            };
            foreach ( Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1001,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=1005,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=1004,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=1001,Grade=Grade.D},
                new Enrollment{StudentID=3,CourseID=1005},
                new Enrollment{StudentID=4,CourseID=1005},
                new Enrollment{StudentID=5,CourseID=1002,Grade=Grade.B},
                new Enrollment{StudentID=5,CourseID=1003,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1002,Grade=Grade.F},
                new Enrollment{StudentID=6,CourseID=1004,Grade=Grade.B}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
