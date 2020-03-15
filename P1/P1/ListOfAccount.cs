using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class ListOfAccount: CustomerData
    {
        public static void PrintListOfAccount(string text)                //Using object to get a List of Account
        {
            MakeAction(text);
            Console.Clear();
            ReadCustomerData();

        }
    }
}
