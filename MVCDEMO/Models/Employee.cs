using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDEMO.Controllers;

namespace MVCDEMO.Models
{
    public class Employee
    {
        public int Id { get; internal set; }

        public string name { get; internal set; }

        public string Designation { get; internal set; }

        public double Salary { get; internal set; }
    }      
}
