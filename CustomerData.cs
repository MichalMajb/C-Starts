using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class CustomerData: Action
    {
        public string FirstName { get; }
        public string LasttName { get; }
        public long Pesel { get; }

        public CustomerData()
        {

        }

        public CustomerData(string firstName, string lastName, string pesel)
        {
            FirstName = firstName;
            LasttName = lastName;
            Pesel = long.Parse(pesel);
        }
        protected static CustomerData ReadCustomerData()                     //Read basic information about customer
        {
            string firstName;
            string lastName;
            string pesel;
            Console.WriteLine("Podaj dane klienta:");
            Console.Write("Imię:");
            firstName = Console.ReadLine();
            Console.Write("Nazwisko:");
            lastName = Console.ReadLine();
            Console.Write("PESEL:");
            pesel = Console.ReadLine();

            return new CustomerData(firstName, lastName, pesel);
        }
    }
}
