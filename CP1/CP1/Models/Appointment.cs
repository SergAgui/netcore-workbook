using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    [Table("Appointment")]
    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer {get; set;}
        public int ProviderId { get; set; }
        public ServiceProvider Provider { get; set; }
        public enum WorkDays { Monday, Tuesday, Wednesday, Thursday, Friday };

        public WorkDays Work { get; set; }
    }
}
