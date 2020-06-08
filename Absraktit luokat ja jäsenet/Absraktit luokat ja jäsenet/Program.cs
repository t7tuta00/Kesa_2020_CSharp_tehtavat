using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absraktit_luokat_ja_jäsenet
{
    public abstract class Program 
    {
        public abstract void ExampleMethod();
    }
    class Program2 : Program
    {
        public override void ExampleMethod()
        {
            Console.WriteLine("Doing stuff");
        }

        static void Main(string[] args)
        {
            Program2 p = new Program2();
            p.ExampleMethod();
            Console.ReadKey();
        }

        
    }
}
