using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    abstract class Action
    {
        protected static void MakeAction(string text)
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
    
}
