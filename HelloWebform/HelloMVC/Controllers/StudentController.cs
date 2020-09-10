using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}