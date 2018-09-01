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
        public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>();

        public void AddCust(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            // add above to other methods later
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
        public void NewAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }
        public void AddServProv(ServiceProvider serviceProvider)
        {
            ServiceProviders.Add(serviceProvider);
        }
        public void RemoveAppointment(Appointment appointment)
        {
            Appointments.Remove(appointment);
        }
        public void RemoveServProv(ServiceProvider serviceProvider)
        {
            ServiceProviders.Add(serviceProvider);
        }

    }
}
