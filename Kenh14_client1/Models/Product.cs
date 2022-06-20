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
        public int CategoryId { get; set; }
        public string PhotoUrl { get; set; }
        public string Drc { get; set; }
        public string Engine { get; set; }
        public string Momen { get; set; }
        public string Consumption { get; set; }
        public int? Seat { get; set; }

        public virtual Category Category { get; set; }
    }
}
