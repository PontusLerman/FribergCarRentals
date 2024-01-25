using FribergCarRentals.Data;
using Microsoft.AspNetCore.Mvc;

namespace FribergCarRentals.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAdmin adminRepository;
        private readonly ICustomer customerRepository;
        private readonly ApplicationDbContext applicationDbContext;

        public LoginController(IAdmin adminRepository, ICustomer customerRepository, ApplicationDbContext applicationDbContext)
        {
            this.adminRepository = adminRepository;
            this.customerRepository = customerRepository;
            this.applicationDbContext = applicationDbContext;
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(string email)
        //{
        //    try
        //    {
        //        applicationDbContext.Admins.FirstOrDefault(a => a.Email == email);
        //        if (admin == true)
        //        {

        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

    }
}
