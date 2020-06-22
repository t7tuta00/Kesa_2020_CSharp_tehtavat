using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolaatio
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Taneli";
            var date = DateTime.Now;

      
            Console.WriteLine("Hello, {0},{1},{2:HH:mm}", name, date.DayOfWeek, date);
            
            Console.WriteLine($"Hello, {name},{date.DayOfWeek},{date:HH:mm}");
            
            Console.ReadKey();
        }
    }
}
