using System;
using System.Collections.Generic;

#nullable disable

namespace Training.AZ204.WebSIte.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string RelativeUrl { get; set; }
        public decimal Amount { get; set; }
        public int Customer { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
    }
}
