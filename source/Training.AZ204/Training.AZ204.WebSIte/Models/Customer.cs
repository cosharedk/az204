using System;
using System.Collections.Generic;

#nullable disable

namespace Training.AZ204.WebSIte.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
