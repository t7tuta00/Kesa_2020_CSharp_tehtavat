using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geneerinen_ohjelmointi
{
    public static class Changer 
    { 
        public static void ChangeValues<T>(ref T first, ref T second) 
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }

    public static class Changer2
    {
        public static TResult changeType<TStart, TResult>(TStart value)
        {
            return (TResult)Convert.ChangeType(value, typeof(TResult));
        }
    }

    public class Stuff<T>
    {
        List<T> stuff;

        public Stuff()
        {
            stuff = new List<T>();
        }
        public void Add(T @object)
        {
            stuff.Add(@object);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            string c = "boo";
            string d = "boo2";

            Changer.ChangeValues<int>(ref a, ref b);
            Changer.ChangeValues(ref c, ref d);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            int number = Changer2.changeType<string, int>("12345");

            bool @true = Changer2.changeType<string, bool>("true");

            Stuff<int> s = new Stuff<int>();
            s.Add(123);

            Console.ReadKey();
        }
    }
}

