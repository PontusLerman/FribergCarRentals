﻿using FribergCarRentals.Models;
using NuGet.Protocol;

namespace FribergCarRentals.Data
{
    public interface ICustomer
    {
        Customer GetById(int id); 
        IEnumerable<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
