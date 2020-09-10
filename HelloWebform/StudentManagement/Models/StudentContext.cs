using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("Student") { }

        public DbSet<Student> Students { get; set; }
    }
}