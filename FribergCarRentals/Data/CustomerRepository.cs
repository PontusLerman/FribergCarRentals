using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CustomerRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Add(Customer customer)
        {
            applicationDbContext.Customers.Add(customer);
            applicationDbContext.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            applicationDbContext.Customers.Remove(customer);
            applicationDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            return applicationDbContext.Customers.OrderBy(x => x.LastName);
        }

        public Customer GetById(int id)
        {
            return applicationDbContext.Customers.FirstOrDefault(x=>x.Id==id);
        }

        public void Update(Customer customer)
        {
            applicationDbContext.Customers.Update(customer);
            applicationDbContext.SaveChanges();
        }
    }
}
