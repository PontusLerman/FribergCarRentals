using FribergCarRentals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FribergCarRentals.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }
        
    }
}
