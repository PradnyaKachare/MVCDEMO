using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace MVCDEMO.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> list = new List<string>();

            list.Add("Yes");
            list.Add("No");

            ViewData["option"] = new SelectList(list);
            return View();
        }

        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Option = form["option"];
            return View("Details");
        }
    }
}
