using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.Entity;

namespace StudentManage.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("Student") { }

        public DbSet<Student> Students { get; set; }
    }
}