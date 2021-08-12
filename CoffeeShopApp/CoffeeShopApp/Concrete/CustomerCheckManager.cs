using CoffeeShopApp.Abstract;
using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopApp.Concrete
{
   public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
