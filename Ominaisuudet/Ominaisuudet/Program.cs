using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ominaisuudet
{
    public class CarCollection 
    {
        private string car;
        public string Car 
        {
            get { return car; }
            set { car = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection c = new CarCollection();
            c.Car = "Volvo";
            Console.WriteLine(c.Car);
            Console.ReadKey();
        }
    }
}
