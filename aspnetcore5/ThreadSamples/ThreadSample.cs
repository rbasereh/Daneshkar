using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSamples
{
    internal class ThreadSample
    {
        public ThreadSample()
        {
            Count = 0;
        }
        public int Count { get; set; }
        public void RunThread()
        {
            var watch = Stopwatch.StartNew();
            
            Run();
            
            Thread t1 = new(Run);
            
            watch.Stop();
        }
        void Run()
        {
            Console.WriteLine("Start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Count + "*");
                //File.WriteAllText("D:\\test.txt", Count + "*");
                Count++;
                Thread.Sleep(100);
            }
            Console.WriteLine("End");
        }
       
    }
}
