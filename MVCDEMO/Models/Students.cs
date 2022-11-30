using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDEMO.Models
{
    public class Students
    {
        [Required(ErrorMessage="Rollno is required")]
        [Display (Name="Roll Number")]
        public int Rollno { get;  set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(40,ErrorMessage ="Name must have less than 40 characters")]
        [Display(Name = "Student Name")]
        public string? Name { get;  set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not proper format")]
        public string? Email { get;  set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18,60, ErrorMessage = "Age must be in between 18 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
