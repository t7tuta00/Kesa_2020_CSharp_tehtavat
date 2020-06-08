using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staattiset_luokat
{
    public static class CarCollection 
    {
        static string car = "Volvo";

        public static string getCar() 
        {
            return car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string car;
            car = CarCollection.getCar();
            Console.WriteLine(car);
            Console.ReadKey();
        }
    }
}
