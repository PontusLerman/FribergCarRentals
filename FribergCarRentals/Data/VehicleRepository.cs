using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public class VehicleRepository:IVehicle
    {
        private readonly ApplicationDbContext applicationDbContext;

        public VehicleRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Add(Vehicle vehicle)
        {
            applicationDbContext.Add<Vehicle>(vehicle);
            applicationDbContext.SaveChanges();
        }

        public void Delete(Vehicle vehicle)
        {
            applicationDbContext.Remove<Vehicle>(vehicle);
            applicationDbContext.SaveChanges();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return applicationDbContext.Vehicles.OrderBy(v=>v.Make);
        }

        public Vehicle GetById(int id)
        {
            return applicationDbContext.Vehicles.FirstOrDefault(v => v.Id == id);
        }

        public void Update(Vehicle vehicle)
        {
            applicationDbContext.Update<Vehicle>(vehicle);
            applicationDbContext.SaveChanges();
        }
    }
}
