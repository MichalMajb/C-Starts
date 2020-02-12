using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class ChengerMoney : IChangerMoney
    {
        private AccountMenager _accountMenager;
        private IPrinter _printer;

        public ChengerMoney()
            {
            _accountMenager = new AccountMenager();
            _printer = new Printer();
            }
        public void ChangeMoney()
        {
            string accountNo;
            decimal value;
            Console.WriteLine("1-Wpłata");
            Console.WriteLine("2-Wypłata");
            string a = Console.ReadLine();
            Console.Write("Numer konta:");
            accountNo = Console.ReadLine();
            Account account = _accountMenager.GetAccount(accountNo);
            if (a == "1")
            {
                Console.WriteLine("Wpłata pieniędzy");
                Console.Write("Kwota:");
                value = decimal.Parse(Console.ReadLine());
                _accountMenager.AddMoney(accountNo, value);
            }
            else if (a == "2")
            {
                Console.WriteLine("Wypłata pieniędy");
                Console.Write("Kwota:");
                value = decimal.Parse(Console.ReadLine());
                if (decimal.Parse(account.GetBalance()) < value)
                {
                    Console.WriteLine("Brak środków na koncie");
                }
                else
                {
                    _accountMenager.TakeMoney(accountNo, value);
                }
            }
            account = _accountMenager.GetAccount(accountNo);
            _printer.Print(account);
            Console.ReadKey();
        }

    }
}
