using Kupac.Data;
using Kupac.Data.Entities;
//using Kupac.DbContexts;
using Kupac.Data.Entities;
using Kupac.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kupac.Data.DbContexts;

namespace Kupac.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly CapillarContextFactory _factory;

        public CustomerService(CapillarContextFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            using (var context = _factory.CreateDbContext(null))
            {
                return await context.Customers
                    .OrderBy(c => c.LastName)
                    .ToListAsync();
            }
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            using (var context = _factory.CreateDbContext(null))
            {
                context.Customers.Add(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveCustomerAsync(int customerId)
        {
            using (var context = _factory.CreateDbContext(null))
            {
                var customer = await context.Customers.FindAsync(customerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
