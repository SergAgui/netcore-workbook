using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public interface IAppointment
    {
        int? Id { get; set; }
        string Name { get; set; }
        string Provider { get; set; }
        string WorkHours { get; set; }
    }
}
