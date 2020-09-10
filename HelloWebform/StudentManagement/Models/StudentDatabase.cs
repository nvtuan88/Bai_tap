using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class StudentDatabase : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            GetStudents().ForEach(c => context.Students.Add(c));
        }

        private static List<Student> GetStudents()
        {
            var student = new List<Student>()
            {
                new Student{
                    ID = 1,
                    Name = "TUan",
                    Description = "hasjklfhajkshdakjsdkjasd",
                    Match = 10,
                    ImagePath = "carconvert.png"
                },
                 new Student{
                    ID = 2,
                    Name = "Haia",
                    Description = "lakjsdlasjdlkasjdlkajsd",
                    Match = 12,
                    ImagePath = "carearly.png"
                 },

                 new Student{
                    ID = 3,
                    Name = "huhu",
                    Description = "kahskjdhaskjdhaksjd",
                    Match = 13,
                    ImagePath = "carfast.png"
                 },
            };
            return student;
        }
    }
}