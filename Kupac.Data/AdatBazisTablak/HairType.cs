using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Data.AdatBazisTablak
{
    [Table("HairType")]
    public class HairType
    {
        [Key]
        public int HairTypeId { get; set; }
        [Required]
        public string HairTypeName { get; set; } = string.Empty;
    }
}
