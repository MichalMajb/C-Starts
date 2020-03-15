using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class AddBillingAccount: CustomerData
    {
        private static AccountMenager _accountMenager;
        AddBillingAccount()
        {
            _accountMenager = new AccountMenager();
        }
        public static void AdderBilingAccount(string text)
        {
            MakeAction(text);
            Console.Clear();
            CustomerData data = ReadCustomerData();
            Account bilingAccount = _accountMenager.CreateBillingAccount(data.FirstName, data.LasttName, data.Pesel);
            Console.WriteLine("Utworzono konto rozliczeniowe");
        }
    }
}
