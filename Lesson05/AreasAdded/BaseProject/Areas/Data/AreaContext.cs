using BaseProject.Area.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Data
{
    public class AreaContext : DbContext
    {
        public AreaContext(DbContextOptions<AreaContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
