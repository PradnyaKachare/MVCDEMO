using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employees = new List<Employee>()
            {
               new Employee{Id=1,name="Pradnya",Designation="Manager",Salary=56000},
               new Employee{Id=2,name="Prachi",Designation="Development",Salary=54000},
               new Employee{Id=3,name="Pratik",Designation="Development",Salary=56000},
               new Employee{Id=4,name="Prashant",Designation="Tester",Salary=45000},
               new Employee{Id=5,name="Priya",Designation="Tester",Salary=35000},
            };
            ViewData["emplist"] = employees;

            return View();
        }
    }
}
