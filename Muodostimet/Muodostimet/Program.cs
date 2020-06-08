using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muodostimet
{
    public class CarCollection 
    {
        string car;
        string color;

        public CarCollection(string a, string b) 
        {
            car = a;
            color = b;
        }

        public void getCarAndColor() 
        {
            Console.WriteLine(car+color);
        }
}

    
    class Program
    {
        static void Main(string[] args)
        {
            string car = "Volvo";
            string color = "Red";
            CarCollection c = new CarCollection(car,color);

            c.getCarAndColor();
            Console.ReadKey();
        }
    }
}
