using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osittaminen
{
    public partial class Program
    {
        public int n;
        public int getsetn
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public int getInt{get; set;}
    }

    public partial class Program
    {
        public int asd() 
        {
            return getInt;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.getsetn = 5;
            p.getInt = 2;
            Console.WriteLine(p.asd());
            Console.WriteLine(p.n);
            Console.ReadKey();
        }
    }
}
