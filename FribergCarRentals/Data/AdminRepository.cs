using FribergCarRentals.Models;

namespace FribergCarRentals.Data
{
    public class AdminRepository : IAdmin
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AdminRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
