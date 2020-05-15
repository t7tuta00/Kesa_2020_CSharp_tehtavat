using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamba_expression
{
    class Program
    {
        public delegate void p(int value);

        static int a = 2;
        static void Main(string[] args)
        {
            p p2 = a => Console.WriteLine(a);

            p2(a);
            Console.ReadLine();
        }
    }
}
