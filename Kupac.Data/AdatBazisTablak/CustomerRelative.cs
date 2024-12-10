using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Data.AdatBazisTablak
{
    public class CustomerRelative
    {
        public int RelativeId { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string? Notes { get; set; }
    }
}
