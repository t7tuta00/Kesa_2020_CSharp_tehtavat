using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indekserit_
{
    public class Collection<T> 
    {
        private T[] arr = new T[100];

        public T this[int i] 
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new Collection<string>();
            stringCollection[0] = "Hello World";
            Console.WriteLine(stringCollection[0]);
            Console.ReadKey();
        }
    }
}
