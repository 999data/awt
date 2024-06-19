using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.ItemList = "Student Details";
            List<Student> studlist = new List<Student>()
            {
                new Student() { sid=1, sname="Ramesh", course="MCA"},
                new Student() { sid=2,sname="Varun", course="BCA"},
                new Student() { sid=3,sname="Aniket", course="BSCCS"}
            };
            return View(studlist);
        }
    }
}