using System;
using System.Collections.Generic;

namespace kendo_ui_angular_demo.Models
{
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            CustomerDemo = new HashSet<CustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public ICollection<CustomerDemo> CustomerDemo { get; set; }
    }
}
