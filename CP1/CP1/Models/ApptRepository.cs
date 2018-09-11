using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CP1.Models
{
    public class ApptRepository : IApptRepository
    {
        private readonly Context _context;
        public ApptRepository(Context context)
        {
            _context = context;
        }
        //public List<Customer> Customers { get; } = new List<Customer>();
        //public List<Appointment> Appointments { get;} = new List<Appointment>();
        //public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>();

        //Customer Methods
        public void AddCust(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public void RmvCustById(int guid)
        {
            var customer = GetCustomer(guid);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        public Customer GetCustomer(int id)
        {
            var customer = _context
                            .Customers
                            .Where(c => c.Id == id)
                            .FirstOrDefault();
            return customer;
        }
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        public void UpdateCustomer(Customer customer)
        {
            RmvCustById(customer.Id);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        //Provider Methods
        public void AddProv(ServiceProvider serviceProvider)
        {
            _context.Providers.Add(serviceProvider);
            _context.SaveChanges();
        }
        public void RemoveProvById(int guid)
        {
            var provider = GetProvider(guid);
            _context.Providers.Remove(provider);
            _context.SaveChanges();
        }
        public ServiceProvider GetProvider(int id)
        {
            var provider = _context.Providers.Where(c => c.Id == id).FirstOrDefault();
            return provider;
        }
        public List<ServiceProvider> GetAllProviders()
        {
            return _context.Providers.ToList();
        }
        public void UpdateProvider(ServiceProvider provider)
        {
            RemoveProvById(provider.Id);
            _context.Providers.Add(provider);
            _context.SaveChanges();
        }

        //Appointment Methods
        public void AddAppt(Appointment appt)
        {
            _context.Appts.Add(appt);
            _context.SaveChanges();
        }
        public Appointment GetAppointment(int id)
        {
            var appt = _context.Appts.Where(c => c.Id == id).FirstOrDefault();
            return appt;
        }
        public void RemoveApptById(int guid)
        {
            var appt = GetAppointment(guid);
            _context.Appts.Remove(appt);
            _context.SaveChanges();
        }


        //Create a new appointment
        public void NewAppt(Appointment appointment)
        {
            var invalidAppointment = _context.Appts.Any(appt => ((appt.CustomerId == appointment.CustomerId ||
            appt.ProviderId == appointment.ProviderId) && appt.Work == appointment.Work));

            if (invalidAppointment)
            {
                throw new BadApptException("Not a valid Appointment");
            }

            var ValidCustomer = _context.Customers.Any(cust => cust.Id == appointment.CustomerId);
            if (!ValidCustomer)
            {
                throw new BadCustomerException("Not a valid Customer");
            }

            var validProvider = _context.Providers.Any(c => c.Id == appointment.ProviderId);
            if (!validProvider)
            {
                throw new BadProviderException("Not a valid Provider");
            }

            AddAppt(appointment);
            _context.SaveChanges();
        }
        public List<Appointment> GetAllAppointments()
        {
            return _context.Appts
                    .Include(a => a.Customer)
                    .Include(p => p.Provider)
                    .ToList();
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
