using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //public string Index() {
        //    return "<h1>HelloWorld</h1>";
        //}

        //Get HelloWorld/Home
        public string Home() {
            return "Welcome MVC";
        }
        //Get: HelloWorld/Welcome?name=thidk&numTimes=19
        //public string Welcome(string name, int numTimes = 1){
        //    return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes = " + numTimes);
        //}

        public string Hello(string name, int id = 1) {
            return HttpUtility.HtmlEncode("Hello Welcome MVC" + name + ", NumTimes = " + id);
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Name = "Hello :" + name + ";" ;
            ViewBag.Time = numTimes;
            return View();
        }
    }
}