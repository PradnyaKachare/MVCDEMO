using Microsoft.AspNetCore.Mvc;
using MVCDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDEMO.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Addstudents()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addstudents(Students stud)
        {
            return View();
        }
    }
}
