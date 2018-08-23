using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Appointment : IAppointment
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Provider { get; set; }
        [Required]
        public string WorkHours { get; set; }
    }
}
