using System;
using System.Collections.Generic;

#nullable disable

namespace Kenh14_client1.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Care { get; set; }
    }
}
