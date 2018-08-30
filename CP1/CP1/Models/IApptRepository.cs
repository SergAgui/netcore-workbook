using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public interface IApptRepository
    {
        List<Appointment> Appointments { get; set; }
        List<Customer> Customers { get; set; }
        List<ServiceProvider> ServiceProviders { get; set; }
    }
}
