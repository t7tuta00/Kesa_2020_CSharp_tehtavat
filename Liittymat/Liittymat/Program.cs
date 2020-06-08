using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liittymat
{
    interface ISampleInterface 
    {
        void SampleMethod();
    }
    class Program : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("Fill interface");
        }

        static void Main(string[] args)
        {
            ISampleInterface p = new Program();
            p.SampleMethod();
            Console.ReadKey();
        }

        
    }
}
