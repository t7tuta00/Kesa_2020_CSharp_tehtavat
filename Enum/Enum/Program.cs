using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Myenums 
    {
        Unknown,
        Value1,
        Value2
    }
    class Program
    {
        static void Main()
        {
            Myenums e = Myenums.Value1;
            Console.WriteLine(e);

            var a = Myenums.Value2;
            Console.WriteLine(a);

            Console.WriteLine();

            changething(Myenums.Unknown);
            changething(Myenums.Unknown);
            changething(Myenums.Unknown);

            Console.WriteLine();

            var aAsint = (int)a;
            Console.WriteLine(aAsint);
            var aBackAsItself = (Myenums)aAsint;
            Console.WriteLine(aBackAsItself);
            Console.ReadKey();
        }

        public static void changething(Myenums enums) 
        {
            switch (enums) 
            {
                case Myenums.Unknown:
                    Console.WriteLine("0");
                    break;

                case Myenums.Value1:
                    Console.WriteLine("1");
                    break;

                case Myenums.Value2:
                    Console.WriteLine("2");
                    break;
            }
        }
    }
}
