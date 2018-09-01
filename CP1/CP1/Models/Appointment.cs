using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public string Provider { get; set; }
        public enum WorkDays { Monday, Tuesday, Wednesday, Thursday, Friday };

        public WorkDays Work { get; set; }
    }
}
