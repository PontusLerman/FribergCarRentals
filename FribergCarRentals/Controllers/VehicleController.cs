using FribergCarRentals.Data;
using FribergCarRentals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergCarRentals.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicle vehicleRepository;

        public VehicleController(IVehicle vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }
        // GET: VehicleController
        public ActionResult Index()
        {
            return View(vehicleRepository.GetAll());
        }

        // GET: VehicleController/Details/5
        public ActionResult Details(int id)
        {
            return View(vehicleRepository.GetById(id));
        }

        // GET: VehicleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vehicle vehicle)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    vehicleRepository.Add(vehicle);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(vehicleRepository.GetById(id));
        }

        // POST: VehicleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vehicle vehicle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vehicleRepository.Update(vehicle);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(vehicleRepository.GetById(id));
        }

        // POST: VehicleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Vehicle vehicle)
        {
            try
            {
                vehicleRepository.Delete(vehicle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
