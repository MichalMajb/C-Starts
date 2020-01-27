using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Name: Bank"; 
            string author = "author: I'm";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            Printer printer = new Printer();

            Account account;
            account = new SavingsAccount("940000000001", 0.0M, "AA", "BB", 92010133333);
            Console.WriteLine(account.TypeName());

            account = new SavingsAccount("940000000002", 0.0M, "CC", "DD", 92010132157);
            Console.WriteLine(account.TypeName());

            account = new BillingAccount("940000000003", 0.0M, account.FirstName, account.LastName, account.Pesel);
            Console.WriteLine(account.TypeName());

            string fullName = account.GetFullName();
            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", fullName);
            Console.WriteLine();

            string Balance = account.GetBalance();
            Console.WriteLine("{0}", Balance);
            Console.WriteLine();

            printer.Print(account);
            printer.Print(account);
            printer.Print(account);


            Console.ReadKey();
        }
    }
}
