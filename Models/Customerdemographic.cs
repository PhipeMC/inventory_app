using System;
using System.Collections.Generic;

namespace inventory_app.Models
{
    public partial class Customerdemographic
    {
        public Customerdemographic()
        {
            Customers = new HashSet<Customer>();
        }

        public string CustomerTypeId { get; set; } = null!;
        public string? CustomerDesc { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
