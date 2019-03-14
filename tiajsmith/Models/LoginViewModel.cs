using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tiajsmith.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Enter Email")]
        [EmailAddress]
        public string Email { get; set;}

        [Required]
        [Display(Name = "Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
