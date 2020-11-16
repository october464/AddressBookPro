using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookPro.Models
{
    public class UserAddress
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Avatar")]
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset Created { get; set; }
        public string Email { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }
    }
}
