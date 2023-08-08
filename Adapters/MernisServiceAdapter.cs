using KahveDukkani2.Abstract;
using KahveDukkani2.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani2.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationaltyId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;

            //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(customer.NationaltyId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
        }
    }
}
