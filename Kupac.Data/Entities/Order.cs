using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupac.Data.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public int ProcedureId { get; set; }
        public decimal? Discount { get; set; }
        public decimal EstimatedPrice { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
