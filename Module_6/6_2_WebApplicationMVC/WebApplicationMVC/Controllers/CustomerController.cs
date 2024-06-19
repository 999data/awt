using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ViewResult CustomerInput()
        {
            return View();
        }

        [HttpPost]

        public ViewResult CustomerInput(Customer c1) 
        { 
            if (ModelState.IsValid)
            {
                return View("CustomerDisplay", c1);
            }
            else {
                return View();
            }
        }
    }
}