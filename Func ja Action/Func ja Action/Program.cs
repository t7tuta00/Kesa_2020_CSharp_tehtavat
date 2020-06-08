using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_ja_Action
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Func<int> giveRandom = () =>
            {
                Random r = new Random();
                return r.Next();
            };

            int number = giveRandom();
            Console.WriteLine(number);


            Func<string, char, int> index = (string text, char text2) =>
            {
                return text.IndexOf(text2);
            };

            int i = index("Hello world!", ' ');
            Console.WriteLine(i);


            Action hi = () =>
            {
                Console.WriteLine("Hello World!");
            };
            
            hi();

            Action<bool, int, char, string> print = (bool b, int i2, char c, string s) =>
            {
                Console.WriteLine("{0} {1} {2} {3}", b, i2, c, s);
            };
            
            print(true, 123, 'a', "text");
            Console.ReadKey();
        }
    }
}
