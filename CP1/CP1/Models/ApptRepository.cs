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

        public void AddCust(Customer customer)
        {
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
        public void RemoveCust(Customer customer)
        {
            Customers.Remove(customer);
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
