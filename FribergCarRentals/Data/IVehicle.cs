using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public interface IVehicle
    {
        Vehicle GetById(int id);
        IEnumerable<Vehicle> GetAll();
        void Add(Vehicle vehicle);
        void Update(Vehicle vehicle);
        void Delete(Vehicle vehicle);
    }
}
