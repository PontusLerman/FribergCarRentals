using FribergCarRentals.Data;
using FribergCarRentals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergCarRentals.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin adminRepository;

        public AdminController(IAdmin adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        // GET: AdminController
        public ActionResult Index()
        {
            return View(adminRepository.GetAll());
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View(adminRepository.GetById(id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin admin)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    adminRepository.Add(admin);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(adminRepository.GetById(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Admin admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminRepository.Update(admin);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(adminRepository.GetById(id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Admin admin)
        {
            try
            {
                adminRepository.Delete(admin);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
