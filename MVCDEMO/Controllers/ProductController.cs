using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{/*
    Contact us form submit
Create ProductController → add product list & display the list
Id, name, company name ,price*/

    public class ProductController : Controller
    {
        public IActionResult Plist()
        {
            List<Product> p = new List<Product>()
           {
              new Product{Id=1,name="HCL",price=75000},
              new Product{Id=2,name="DELL",price=85000},
              new Product{Id=3,name="LENOVO",price=88000},
              new Product{Id=4,name="HP",price=82000},
           };
            ViewData["ProductList"] = p;

            ViewBag.Product = p;
            return View();
        }

       

        /*public IActionResult Product()
        {
            List<string> list = new List<string>();
            list.Add("Yes");
            list.Add("No");
            ViewData["option"] = new SelectList(list);
            return View();
        }
*/
        [HttpPost]
        public IActionResult Product(IFormCollection form, ICollection<string> hobbies)
        {
            ViewBag.Id = form["id"];
            ViewBag.Name = form["name"];
            ViewBag.Company_Name = form["company_Name"];
            ViewBag.Price = form["Price"];
            ViewBag.Option = form["option"];

            return View("Details");
        }

      
    }

}
