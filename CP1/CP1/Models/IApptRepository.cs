using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public interface IApptRepository
    {
        //List<Appointment> Appointments { get; }
        //List<Customer> Customers { get;}
        //List<ServiceProvider> ServiceProviders { get; }


        void AddCust(Customer customer);
        void RmvCustById(int guid);
        Customer GetCustomer(int id);
        List<Customer> GetAllCustomers();
        void UpdateCustomer(Customer customer);


        void AddProv(ServiceProvider serviceProvider);
        void RemoveProvById(int guid);
        ServiceProvider GetProvider(int id);
        List<ServiceProvider> GetAllProviders();
        void UpdateProvider(ServiceProvider provider);


        void AddAppt(Appointment appt);
        void RemoveApptById(int guid);
        Appointment GetAppointment(int id);
        List<Appointment> GetAllAppointments();
        void NewAppt(Appointment appointment);
    }
}
