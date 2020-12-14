using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadPoolProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // adds Task1 to the threadPool
                Stopwatch sw = new Stopwatch();
                Console.WriteLine("Thread pool Execution");
                sw.Start();
                ProcessWithThreadPoolMethod();
                sw.Stop();
                Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + sw.ElapsedTicks.ToString());
                sw.Reset();
                Console.WriteLine("Thread Execution");
                sw.Start(); 
                ProcessWithThreadMethod(); 
                sw.Stop(); 
                Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + sw.ElapsedTicks.ToString());


            Console.Read();

        }


        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        static void ProcessWithThreadPoolMethod() 
        {
            for (int i = 0; i <= 10; i++)
            {
                // process has to take parameter (object callback) otherwise we can't add it to a threadPool
                ThreadPool.QueueUserWorkItem(Process);

            }
        }


        static void Process(object callback)
        {
            //executing time thread vs threadPool. Thread is about 10 times slower
            for (int i = 0; i < 100000; i++)
            {
                //executing time thread vs threadPool. Thread is about 10 times slower
                for (int j = 0; j < 100000; j++)
                {
                    
                }
            }
        }
    }
}
