
using Microsoft.EntityFrameworkCore;
using DemoMVC396.Models;

namespace DemoMVC396.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Persons { get; set;}  
     }
}