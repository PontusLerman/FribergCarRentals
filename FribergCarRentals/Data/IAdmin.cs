using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public interface IAdmin
    {
        Admin GetById(int id);
        IEnumerable<Admin> GetAll();
    }
}
