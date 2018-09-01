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
        public List<Appointment> Appointments { get;} = new List<Appointment>()
        {
            new Appointment()
            {
                Customer = "Dude McDuderson",
                Provider = "Man McMann",
                Work = Appointment.WorkDays.Monday,
                Id = Guid.NewGuid()
            }
        };
        public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>()
        {
            new ServiceProvider()
            {
                FirstName = "Jane",
                LastName = "Dunn",
                Id = Guid.NewGuid()
            }
        };

        //Customer Methods
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

        //Provider Methods
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

        //Appointment Methods
        public void AddAppt(Appointment appt)
        {
            appt.Id = Guid.NewGuid();
            Appointments.Add(appt);
        }
        public void RemoveApptById(Guid guid)
        {
            var appt = GetAppointment(guid);
            Appointments.Remove(appt);
        }
        public Appointment GetAppointment(Guid id)
        {
            var appt = Appointments.Find(c => c.Id == id);
            return appt;
        }
    }
}
