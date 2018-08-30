using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class ApptRepository : IApptRepository
    {
        public List<Customer> Customers = new List<Customer>();
        public List<Appointment> Appointments = new List<Appointment>();
        public List<ServiceProvider> ServiceProviders = new List<ServiceProvider>();

        public void AnotherCustomer (Customer customer)
        {
            Customer.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            Customer.Remove(customer);
        }
    }
}
