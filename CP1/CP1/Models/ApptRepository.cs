using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class ApptRepository : IApptRepository
    {
        public List<Customer> Customers { get; } = new List<Customer>() {
            new Customer()
            {
                FirstName = "John",
                LastName = "Doe",
                Id = Guid.NewGuid()
            }
        };
        public List<Appointment> Appointments { get;} = new List<Appointment>();
        public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>()
        {
            new ServiceProvider()
            {
                FirstName = "Jane",
                LastName = "Dunn",
                Id = Guid.NewGuid()
            }
        };

        public void AddCust(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            Customers.Add(customer);
        }
        public void RmvCustById(Guid guid)
        {
            var customer = GetCustomer(guid);
            Customers.Remove(customer);
        }
        public Customer GetCustomer(Guid id)
        {
            var customer = Customers.Find(c => c.Id == id);
            return customer;

        }
        public void UpdateCustomer(Customer customer)
        {
            RmvCustById(customer.Id);
            Customers.Add(customer);
        }


        public void AddProv(ServiceProvider serviceProvider)
        {
            serviceProvider.Id = Guid.NewGuid();
            ServiceProviders.Add(serviceProvider);
        }
        public void RemoveProvById(Guid guid)
        {
            var provider = GetProvider(guid);
            ServiceProviders.Remove(provider);
        }
        public ServiceProvider GetProvider(Guid id)
        {
            var provider = ServiceProviders.Find(c => c.Id == id);
            return provider;
        }
        public void UpdateProvider(ServiceProvider provider)
        {
            RemoveProvById(provider.Id);
            ServiceProviders.Add(provider);
        }

    }
}
