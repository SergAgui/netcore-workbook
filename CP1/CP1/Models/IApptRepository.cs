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
        void NewAppointment(Appointment appointment);
        void RmvCustById(Guid guid);
        Customer GetCustomer(Guid id);
        void UpdateCustomer(Customer customer);
        void AddServProv(ServiceProvider serviceProvider);
        void RemoveAppointment(Appointment appointment);
        void RemoveServProv(ServiceProvider serviceProvider);

    }
}
