using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Data.AdatBazisTablak
{
    [Table("Procedure")]
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }
        [Required]
        public string ProcedureName { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public decimal BasePrice { get; set; }
        public string? Description { get; set; }
    }
}
