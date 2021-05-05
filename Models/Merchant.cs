using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Merchant
    {
        [Key]
        public Guid MerchantId { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Campus { get; set; }
        public string Dob { get; set; }
        public string Password { get; set; }
    }
}