using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Data.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
        public string? Supplier { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal VatRate { get; set; }
    }
}
