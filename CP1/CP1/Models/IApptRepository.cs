using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public interface IApptRepository
    {
        List<Appointment> Appointments { get; }
        List<Customer> Customers { get;}
        List<ServiceProvider> ServiceProviders { get; }
        void AddCust(Customer customer);
        void RemoveCust(Customer customer);
    }
}
