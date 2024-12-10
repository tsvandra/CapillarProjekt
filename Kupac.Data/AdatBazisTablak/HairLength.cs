using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupac.Data.AdatBazisTablak
{
    [Table("HairLength")]
    public class HairLength
    {
        [Key]
        public int HairLengthId { get; set; }
        [Required]
        public string HairLengthName { get; set; } = string.Empty;
        public int ApproximateLengthCm { get; set; }
    }
}
