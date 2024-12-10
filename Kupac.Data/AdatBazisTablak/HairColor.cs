using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Kupac.Data.AdatBazisTablak
{
    [Table("HairColor")]
    public class HairColor
    {
        [Key]
        public int HairColorId { get; set; }
        [Required]
        public string HairColorName { get; set; } = string.Empty;
        public string? HexCode { get; set; }
    }
}
