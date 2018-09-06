using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CP1.Models
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appts { get; set; }
        public DbSet<ServiceProvider> Providers { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
