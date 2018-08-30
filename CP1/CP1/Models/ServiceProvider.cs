using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class ServiceProvider
    {
        public ServiceProvider()
        {
            Guid Id;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
