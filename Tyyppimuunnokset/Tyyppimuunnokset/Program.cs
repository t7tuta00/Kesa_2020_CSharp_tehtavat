using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyyppimuunnokset
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatNumber = 10.5f;
            int intNumber = (int)floatNumber;
            Console.WriteLine(intNumber);

            string stringText = "100a";
            int number;
            if (int.TryParse(stringText, out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("fail");
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
