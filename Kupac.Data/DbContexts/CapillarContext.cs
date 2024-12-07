﻿using Kupac.AdatbazisTablak;
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
    }
}
