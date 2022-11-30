using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDEMO.Controllers;
using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult SList()
        {
            List<student> stud = new List<student>()
            {
               new student{Roll_no=1,name="Pradnya",per=75},
               new student{Roll_no=2,name="Prachi",per=85},
               new student{Roll_no=3,name="Pratik",per=88},
               new student{Roll_no=4,name="Prashant",per=82},
               new student{Roll_no=5,name="Priya",per=80},
            };
            ViewData["studlist"] = stud;

            ViewBag.Studlist = stud;
            return View();
        }
    }
}
