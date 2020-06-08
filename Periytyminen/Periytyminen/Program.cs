using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    public class CarCollection 
    {
        public string car = "Volvo";
    }
    class Program : CarCollection
    {
        static void Main(string[] args)
        {
            string car;
            CarCollection c = new CarCollection();
            Program p = new Program();

            car = c.car;
            Console.WriteLine(car);
            car = p.car;
            Console.WriteLine(car);
            Console.ReadKey();
        }
    }
}
