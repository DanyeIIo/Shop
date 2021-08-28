using System;
using System.Collections.Generic;

#nullable disable

namespace AwesomeShop.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CountOfProducts { get; set; }
        public int MemberId { get; set; }
        public int ProductId { get; set; }
        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public User Member { get; set; }
        public Product Product { get; set; }
    }
}
