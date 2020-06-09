using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorien_kuormitus
{
    public class Coffee 
    { 
        public static MilkCoffee operator +(Coffee coffee, Milk milk) 
        {
            return new MilkCoffee(coffee, milk);
        }
    }

    public class Milk 
    {
    }

    public class MilkCoffee 
    {
        private Coffee coffee;
        private Milk milk;

        public MilkCoffee(Coffee coffee, Milk milk) 
        {
            this.coffee = coffee;
            this.milk = milk;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Milk milk = new Milk();
            MilkCoffee milkcoffee = coffee + milk;

        }
    }
}
