using CoffeeShopApp.Abstract;
using CoffeeShopApp.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;
using static ServiceReference1.KPSPublicSoapClient;
using ServiceReference1;

namespace CoffeeShopApp.Adapters
{
   public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(customer.NationalityID), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
    
}
