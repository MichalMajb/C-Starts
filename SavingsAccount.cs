using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int id, string firstName, string lastName, long pesel) 
            : base(id, firstName, lastName, pesel)
        {
        }
        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";
        }
    }
}
