﻿using System;
using System.Collections.Generic;

namespace kendo_ui_angular_demo.Models
{
    public partial class Customers
    {
        public Customers()
        {
            CustomerDemo = new HashSet<CustomerDemo>();
            Orders = new HashSet<Orders>();
        }

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public ICollection<CustomerDemo> CustomerDemo { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
