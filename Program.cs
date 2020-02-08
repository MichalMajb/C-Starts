﻿using System;
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

            AccountMenager manager = new AccountMenager();
            manager.CreateBillingAccount("Marek", "Zajac", 1234567890);
            manager.CreateSavingsAccount("Marek", "Zajac", 1234567890);
            manager.CreateSavingsAccount("Aaaaa", "Bbbbb", 0987654321);

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();

            foreach (Account account in accounts)
            {
                printer.Print(account);
            }

            IEnumerable<string> users = manager.ListOfCustomers();

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            Console.ReadKey();
        }
    }
}
