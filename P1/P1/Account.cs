using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance;
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = GenerateAccountNumber(id);
            Balance = 0.0M;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }
        public abstract string TypeName();

        private string GenerateAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);


        }
        public string GetBalance()
        {
            return string.Format("Balans: {0}zł", Balance);
        }
        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }
    }
}
