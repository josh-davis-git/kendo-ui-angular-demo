using System;
using System.Collections.Generic;

namespace kendo_ui_angular_demo.Models
{
    public partial class CustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public Customers Customer { get; set; }
        public CustomerDemographics CustomerType { get; set; }
    }
}
