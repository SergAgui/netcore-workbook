using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class ApptRepository : IApptRepository
    {
        public List<Customer> Customers { get; } = new List<Customer>();
        public List<Appointment> Appointments { get;} = new List<Appointment>();
        public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>();

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
        public Appointment GetAppointment(Guid id)
        {
            var appt = Appointments.Find(c => c.Id == id);
            return appt;
        }
        public void RemoveApptById(Guid guid)
        {
            var appt = GetAppointment(guid);
            Appointments.Remove(appt);
        }


        //Create a new appointment
        public void NewAppt(Appointment appointment)
        {
            List<Appointment> appointments = Appointments;

            var InvalidAppointment = appointments.Any(appt => ((appt.Customer == appointment.Customer ||
            appt.Provider == appointment.Provider) && appt.Work == appointment.Work));

            if (InvalidAppointment)
            {
                throw new BadApptException("Not a valid Appointment");
            }

            var ValidCustomer = Customers.Any(cust => cust.FullName == appointment.Customer);
            if (!ValidCustomer)
            {
                throw new BadCustomerException("Not a valid Customer");
            }

            var ValidProvider = ServiceProviders.Any(c => c.FullName == appointment.Provider);
            if (!ValidProvider)
            {
                throw new BadProviderException("Not a valid Provider");
            }

            AddAppt(appointment);

        }

        //Exceptions
        public class BadApptException : Exception
        {
            public BadApptException(string message) : base(message)
            {
            }
        }

        public class BadCustomerException : Exception
        {
            public BadCustomerException(string message) : base(message)
            {
            }
        }

        public class BadProviderException : Exception
        {
            public BadProviderException(string message) : base(message)
            {
            }
        }
    }
}
