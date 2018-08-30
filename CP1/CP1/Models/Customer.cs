using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP1.Models
{
    public class Customer
    {
        public Customer()
        {
            Guid Id;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        { get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
