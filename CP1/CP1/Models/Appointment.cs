using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Appointment
    {
        public Appointment()
        {
            Guid Id;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }
        public string WorkHours { get; set; }
    }
}
