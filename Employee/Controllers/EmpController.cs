using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;


namespace Employee.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult Login(Employee.Models.Employee login)
        {
            if (login.Name == "Anu" && login.Password == 1987)
            {
                return RedirectToAction("Detail");
            }
            else
            {
                ViewBag.add = "Incorrect ";
                ViewData["all"] = "password or";
                TempData["new"] = " username";
            }
            return View();
        }
        public ActionResult Detail()
        {
            List<Employee.Models.Employee> emp = new List<Employee.Models.Employee>();
            emp.Add(new Employee.Models.Employee
            {
                EmpId = 101,
                EmpName = "jamuna",
                EmpLocation = "Erode"
            });
            emp.Add(new Employee.Models.Employee
            {
                EmpId = 102,
                EmpName = "Anu",
                EmpLocation = "Chennai"
            });
            emp.Add(new Employee.Models.Employee
            {
                EmpId = 103,
                EmpName = "Rani",
                EmpLocation = "Salem"
            });
            ViewData["name"] = emp;
            return View();
        }

    }

}