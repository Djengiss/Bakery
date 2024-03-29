﻿using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public List<Order>? Orders { get; set; }
        public List<DispatchRoute> DispatchRoutes { get; set; }
    }
}