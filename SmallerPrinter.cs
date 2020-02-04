using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class SmallerPrinter: IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            Console.WriteLine("Imię właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
        }
    }
}
