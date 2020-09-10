using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Student> GetStudents()
        {
            var _db = new StudentManagement.Models.StudentContext();
            IQueryable<Student> query = _db.Students;

            return query;
        }
    }
}