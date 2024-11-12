using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    public class Student
    {
        [Key]
        [Display(Name="Student Id")]
        public int Id { get; set; }
        [Display(Name = "Student Name")]
        [Required(ErrorMessage ="name is required")]
        public string Name { get; set; }
        [Range(18,60,ErrorMessage ="age must be in rage of 18 to 60")]
        public int Age { get; set; }
        [Display(Name = "Student Email Id")]
        [Required(ErrorMessage ="email is required")]
        public string Email { get; set; }
        [Display(Name="Mobile No")]
        [Required(ErrorMessage ="Phone no is required")]
        [RegularExpression(@"^([0-9]{10})", ErrorMessage = "Invalid Mobile No")]
        public string Phone { get; set; }


    }
}