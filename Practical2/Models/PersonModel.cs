using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical2.Models
{
    public class PersonModel
    {
        //Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"
        [Display(Name = "Student number")] //Add as decorator
        public string StuNumber { get; set; }

        [Display(Name = "First Name")] //Add as decorator
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] //Add as decorator
        public string LastName { get; set; }

        [Display(Name = "Email address")] //Add as decorator
        public string Email { get; set; }

       
    }
}