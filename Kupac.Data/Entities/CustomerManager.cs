using Kupac.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.Entities
{
    public class CustomerManager
    {
        private readonly CapillarContextFactory factory;

        public CustomerManager()
        {
            this.factory = new CapillarContextFactory();
        }

        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(int customerID)
        {
            Customer? customerToRemove = customers.FirstOrDefault(c => c.Id == customerID);
            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
            }
            else
            {
                Console.WriteLine("Nincs ilyen ugyfel");
            }
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            using (var context = factory.CreateDbContext(null))
            {
                return await context.Customers.OrderBy(c => c.LastName).ToArrayAsync();
            }
        }
    }
}
