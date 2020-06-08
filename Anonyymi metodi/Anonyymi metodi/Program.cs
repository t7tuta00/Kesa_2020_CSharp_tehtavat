using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonyymi_metodi
{
    public class Program 
    {
        public delegate void printDelegate(string message);
        public printDelegate print;
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print += delegate (string message)
            {
                Console.WriteLine(message);
            };

            p.print("Hello World");
            Console.ReadKey();
        }
        
    }
}
