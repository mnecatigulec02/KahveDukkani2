using KahveDukkani2.Abstract;
using KahveDukkani2.Adapters;
using KahveDukkani2.ConCreate;
using KahveDukkani2.Entities;

namespace KahveDukkani2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1980,1,1),FirstName="asd",LastName="asd",NationaltyId="12345678910"});
            Console.ReadLine();
        }
    }
}