using Kupac.Entities;
using Kupac.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kupac.DbContexts
{
    public class CapillarContext : DbContext
    {
        public CapillarContext(DbContextOptions<CapillarContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<HairType> HairTypes { get; set; }
        public DbSet<HairLength> HairLengths { get; set; }
        public DbSet<HairColor> HairColors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<CustomerRelative> CustomerRelatives { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerDetail>()
                .HasKey(cd => cd.DetailId);

            modelBuilder.Entity<CustomerRelative>()
                .HasKey(cd => cd.RelativeId);
        }
    }

    
    }
