using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            double? pi = null;
            char? kirjain = 'a';
            int m2 = 10;
            int? m = m2;
            bool? flag = null;
            int?[] array = new int?[10];

            if (pi is double valueOfA) 
            {
                Console.WriteLine(pi);
            }
            else
            {
                Console.WriteLine("sisältö null");
            }

            Console.ReadKey();
        }
    }
}
