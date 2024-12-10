using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(15)]
        public string MobilPhone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

        public string? Comment { get; set; }

        public Customer() { }
        public Customer(string firstName, string lastName, string email, string mobilPhone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.MobilPhone = mobilPhone;
        }

    }

    
}
