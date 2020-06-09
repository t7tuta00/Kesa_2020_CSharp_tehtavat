using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapahtumat
{
   public class Process 
    {
        public event EventHandler ProcessCompleted;

        public void StartProcess() 
        {
            Console.WriteLine("Process started!");
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e) 
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            p.ProcessCompleted += p_ProcessCompleted;
            p.StartProcess();
            Console.ReadKey();
        }

        public static void p_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed");
        }
    }
}
