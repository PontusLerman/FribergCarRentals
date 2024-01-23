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
        public void Add(Admin admin)
        {
            applicationDbContext.Add<Admin>(admin);
            applicationDbContext.SaveChanges();
        }

        public void Delete(Admin admin)
        {
            applicationDbContext.Remove<Admin>(admin);
            applicationDbContext.SaveChanges();
        }

        public IEnumerable<Admin> GetAll()
        {
            return applicationDbContext.Admins.OrderBy(a => a.LastName);
        }

        public Admin GetById(int id)
        {
            return applicationDbContext.Admins.FirstOrDefault(a => a.Id == id);
        }

        public void Update(Admin admin)
        {
            applicationDbContext.Admins.Update(admin);
            applicationDbContext.SaveChanges();
        }
    }
}
