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
        void RmvCustById(Guid guid);
        Customer GetCustomer(Guid id);
        void UpdateCustomer(Customer customer);


        void AddProv(ServiceProvider serviceProvider);
        void RemoveProvById(Guid guid);
        ServiceProvider GetProvider(Guid id);
        void UpdateProvider(ServiceProvider provider);


        void AddAppt(Appointment appt);
        void RemoveApptById(Guid guid);
        Appointment GetAppointment(Guid id);
        void NewAppt(Appointment appointment);
    }
}
