using FribergCarRentals.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FribergCarRentals.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }
        
    }
}
