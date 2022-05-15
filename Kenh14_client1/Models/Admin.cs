using System;
using System.Collections.Generic;

#nullable disable

namespace Kenh14_client1.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomer { get; set; }
    }
}
