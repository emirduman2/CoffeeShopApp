using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApp.Entities;

namespace CoffeeShopApp.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to DB : " + customer.FirstName + " " + customer.LastName);
        }
    }
}
