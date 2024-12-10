using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupac.Data.Entities
{
    [Table("CustomerDetail")]
    public class CustomerDetail
    {
        [Key]
        public int DetailId { get; set; }
        public string CustomerType { get; set; } = "Customer";
        public int PersonId { get; set; }
        public int HairLengthId { get; set; }
        public int HairTypeId { get; set; }
        public int HairColorId { get; set; }
    }
}
