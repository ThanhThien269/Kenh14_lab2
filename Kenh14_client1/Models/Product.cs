using System;
using System.Collections.Generic;

#nullable disable

namespace Kenh14_client1.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string PhotoUrl { get; set; }
        public string Detail { get; set; }
    }
}
