using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public interface ICustomer
    {
        Customer GetById(int id); 
        IEnumerable<Customer> GetAll();
    }
}
