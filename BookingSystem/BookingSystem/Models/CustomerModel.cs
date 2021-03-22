using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem.Models
{
    public class CustomerModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name.")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter phone number.")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter email address.")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-in Date")]
        [Required(ErrorMessage = "Please enter check-in date.")]
        public string CheckInDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Check-out Date")]
        [Required(ErrorMessage = "Please enter check-out date.")]
        public string CheckOutDate { get; set; }
    }
}
