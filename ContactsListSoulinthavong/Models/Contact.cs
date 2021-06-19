using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactsListSoulinthavong.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [Range(1111111111, 9999999999, ErrorMessage = "Please make sure the phone number is in the correct 10 digit format.")]
        public long? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.ToString();
    }
}