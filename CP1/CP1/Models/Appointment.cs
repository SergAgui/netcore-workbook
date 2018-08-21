using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Appointment
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }
        public string WorkHours { get; set; }
    }

    public class AppInfo : Appointment
    {
        public string[] appInfo = { Name, Provider, WorkHours };
    }
}
