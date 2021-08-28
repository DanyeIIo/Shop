using System;
using System.Collections.Generic;

#nullable disable

namespace AwesomeShop.Api.Models
{
    public class DeliveryCountry
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? ManufacturerId { get; set; }
        public string CountryName { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Product Product { get; set; }
    }
}
