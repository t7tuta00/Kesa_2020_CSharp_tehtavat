using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Class1 olio = new Class1();
        

        private static void addAlert(int luku2)
        {
            Console.WriteLine($"Alkuperäinen {luku2}");
        }

        private static void addAlert2(int luku2)
        {
            Console.WriteLine($"Alkuperäinen {luku2+5}");
        }

        static void Main()
        {
            //yhdenrivin ratkaisu
            Console.WriteLine($"Class1 luku on {olio.addOne(addAlert)}");
            //kaksi riviä
            decimal luku = olio.addOne(addAlert2);
            Console.WriteLine(luku);
            
            Console.ReadKey();
        }

       
    }
}
