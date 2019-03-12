using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tiajsmith.Models
{
    public class RegistrationViewModel
    {
        /// <summary>
        /// Email address to use in registration.
        /// </summary>
        //[Display(Name = "Your Email")]
        [Required(ErrorMessage = "A valid email is required.")] /* Have to fill in this field */
        [EmailAddress] /* Has to be a valid email address */
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("Email")] /* Only valid if it matches the field in () */
        public string ConfirmEmail { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        [Required(ErrorMessage = "Name must be between 2 and 20 characters long")]
        [MaxLength(20)]
        [MinLength(2)] /* You have to have 2 characters in your name. */
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        [Required(ErrorMessage = "Name must be between 2 and 20 characters long")]
        [MaxLength(20)]
        [MinLength(2)] /* You have to have 2 characters in your name. */
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// The user's password.
        /// </summary>
        [Display(Name = "Password")]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        /// <summary>
        /// The user's confirmed password.
        /// </summary>
        [Display(Name = "Confirm")]
        [Compare("Password")] /* Only valid if it matches the field in () */
        public string ConfirmPassword { get; set; }

    }
}
