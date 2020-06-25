using MyFirstAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAsp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetDetails()
        {
            Employee emp = new Employee() { EmployeeId = 1, Name = "Kssv Siddhartha", Gender = "Male" };
            return View(emp);
        }
    }
}