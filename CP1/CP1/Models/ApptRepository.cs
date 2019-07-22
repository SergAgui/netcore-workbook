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

        //Customer Methods
        //Add a customer to database
        public void AddCust(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        //Remove customer from database
        public void RmvCustById(int guid)
        {
            var customer = GetCustomer(guid);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        //Retrieve customer information by ID
        public Customer GetCustomer(int id)
        {
            var customer = _context
                            .Customers
                            .Where(c => c.Id == id)
                            .FirstOrDefault();
            return customer;
        }
        //Retrieve all customers and organize them in a list
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        //Removes the customer and adds them back with updated information
        public void UpdateCustomer(Customer customer)
        {
            RmvCustById(customer.Id);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        //Provider Methods
        //Add provider to database
        public void AddProv(ServiceProvider serviceProvider)
        {
            _context.Providers.Add(serviceProvider);
            _context.SaveChanges();
        }
        //Remove provider by ID
        public void RemoveProvById(int guid)
        {
            var provider = GetProvider(guid);
            _context.Providers.Remove(provider);
            _context.SaveChanges();
        }
        //Retrieve provider information by ID
        public ServiceProvider GetProvider(int id)
        {
            var provider = _context.Providers.Where(c => c.Id == id).FirstOrDefault();
            return provider;
        }
        //Retrieve all providers and organize them in a list
        public List<ServiceProvider> GetAllProviders()
        {
            return _context.Providers.ToList();
        }
        //Update provider information by removing the old version and adding the new one
        public void UpdateProvider(ServiceProvider provider)
        {
            RemoveProvById(provider.Id);
            _context.Providers.Add(provider);
            _context.SaveChanges();
        }

        //Appointment Methods
        //Add appointment and save
        public void AddAppt(Appointment appt)
        {
            _context.Appts.Add(appt);
            _context.SaveChanges();
        }
        //Retrieve appointment information by ID
        public Appointment GetAppointment(int id)
        {
            var appt = _context.Appts.Where(c => c.Id == id).FirstOrDefault();
            return appt;
        }
        //Remove an appointment from database
        public void RemoveApptById(int guid)
        {
            var appt = GetAppointment(guid);
            _context.Appts.Remove(appt);
            _context.SaveChanges();
        }
        //Create a new appointment by first verifying Customer and Provider exist and if a similar appointment exists, then saves
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
        //Retrieves all appointments and organizes them in a list
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
