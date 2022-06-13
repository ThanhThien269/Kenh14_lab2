using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Kenh14_client1.Models
{
    public partial class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "pls enter name")]
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        [Required(ErrorMessage = "pls enter phone number")]
        [RegularExpression(@"[0-9]{10}",ErrorMessage ="It's not a phone number")]
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}
