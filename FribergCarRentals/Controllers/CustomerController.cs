﻿using FribergCarRentals.Data;
using FribergCarRentals.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FribergCarRentals.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer customerRepository;

        public CustomerController(ICustomer customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View(customerRepository.GetAll());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View(customerRepository.GetById(id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    customerRepository.Add(customer);                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(customerRepository.GetById(id));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                if(ModelState.IsValid) 
                { 
                    customerRepository.Update(customer);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(customerRepository.GetById(id));
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                customerRepository.Delete(customer); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
