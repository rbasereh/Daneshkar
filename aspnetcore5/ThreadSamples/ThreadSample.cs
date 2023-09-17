using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
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
        public async Task RunThread()
        {
            var watch = Stopwatch.StartNew();

            //Run();
            /*
            Thread t1 = new(Run);
            t1.Start();
            Thread t2 = new(Run);
            t2.Start();
            t1.Join();
            t2.Join();
            */



            //int result = await Run("a", 20);
            //int result2 = await Run("b", 10);


            var result3 = await Task.WhenAll(
                Run("a", 20),
                Run("b", 10)
                );


            Console.WriteLine("Done");
            watch.Stop();
        }
        async Task<int> Run(string taskname, int delay)
        {
            //Console.WriteLine("Start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"TaskName : {taskname} , Count : {Count}, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
                //File.WriteAllText("D:\\test.txt", Count + "*");
                Count++;
                await Task.Delay(delay);
            }
            return delay + 5;
            //Console.WriteLine("End");
        }

    }
}
