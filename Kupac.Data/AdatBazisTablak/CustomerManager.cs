using Kupac.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.AdatbazisTablak
{
    public class CustomerManager
    {
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

        public List<Customer> GetCustomers()
        {
            return customers.OrderByDescending(c => c.LastName).ToList();
        }



        public void LoadCustomersFromDatabase(CapillarContext context)
        {
            customers = context.Customers.OrderBy(c => c.LastName).ToList();
        }


    }
}
