using CoffeeShopApp.Abstract;
using CoffeeShopApp.Adapters;
using CoffeeShopApp.Concrete;
using CoffeeShopApp.Entities;
using System;

namespace CoffeeShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2003, 1, 10), FirstName = "Emir Can", LastName = "Ünlütaş", NationalityID = "54796035920" });
            Console.ReadLine();
        }

     
    }
}
