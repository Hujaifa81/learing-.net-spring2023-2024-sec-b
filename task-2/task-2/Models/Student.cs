using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace task_2.Models
{
    public class Student
    {
        [Required(ErrorMessage ="please provide name")]
        [RegularExpression("^[a-zA-Z\\- .]*$",ErrorMessage ="Only alphabets,space,. and - allowed")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please provide username")]
        [RegularExpression("^[^\\s]{1,10}$",ErrorMessage ="Max 10 characters.Not space allowed.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "please provide id")]
        [RegularExpression("^[0-9]{2}-[0-9]{5}-[1-3]$",ErrorMessage = "First 2 digit 0 to 9, second 5 digit 0 to 9 and last 1 digit 1 to 3")]
        public string Id { get; set; }
        [Required(ErrorMessage = "please provide email")]
        [RegularExpression("^[0-9]{2}-[0-9]{5}-[1-3]@student.aiub.edu$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

    }
}