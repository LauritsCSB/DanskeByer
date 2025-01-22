using Microsoft.EntityFrameworkCore;
using DanskeByer.Models;

namespace DanskeByer.Data
{
    public class DanskeByerContext : DbContext
    {
        public DanskeByerContext(DbContextOptions<DanskeByerContext> options) : base(options) 
        { 
        }

        public DbSet<City> City { get; set; }
    }
}
