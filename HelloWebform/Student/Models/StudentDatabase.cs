using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.Owin.Security.Provider;

namespace StudentManage.Models
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
                    Title = "TUan",
                    Description = "hasjklfhajkshdakjsdkjasd",
                    Match = 10,
                    ImagePath = "carconvert.png"
                },
                 new Student{ 
                    ID = 2,
                    Title = "Haia",
                    Description = "lakjsdlasjdlkasjdlkajsd",
                    Match = 12,
                    ImagePath = "carearly.png"
                 },

                 new Student{ 
                    ID = 3,
                    Title = "huhu",
                    Description = "kahskjdhaskjdhaksjd",
                    Match = 13,
                    ImagePath = "carfast.png"
                 },
            };
            return student;
        }
    }
}