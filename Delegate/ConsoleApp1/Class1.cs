using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        int n = 10;

        public delegate void Number(int luku);

        public decimal addOne(Number number)
        {
            number(n);

            n++;

            return n;
        }
    }
}
