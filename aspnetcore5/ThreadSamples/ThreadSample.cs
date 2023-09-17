using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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


            //RegisterUser();

            var t1 = SendEmail(); //1000
            var t2 = SendSms(); // 1500 

            //.....
            //..... 4000
            //...  

            var result = await Task.WhenAll(t1, t2);

            if (result.All(e => e == true))
            {
                Console.WriteLine("User registered");
            }
            else
            {
                //Error
            }

            //Task<int> t1 = Run("a", 20);
            //Task<int> t2 = Run("b", 10);

            //....
            //....

            int result = await t1;


            //var result3 = await Task.WhenAll(
            //    Run("a", 20),
            //    Run("b", 10)
            //    );


            Console.WriteLine("Done");
            watch.Stop();
        }

        public int Sum(int x1, int x2)
            => x1 + x2;

        async Task<int> Run(string taskname, int delay)
        {
            var data = await GetData(delay);
            return data;
        }


        int? Cache = null;

        async ValueTask<int> Run2(string taskname, int delay)
        {
            if (Cache is null)
                Cache = await GetData(delay);
            return Cache.Value;
        }


        public async Task<int> GetData(int delay)
        {
            await Task.Delay(delay);
            return delay;
        }

        async Task<bool> SendEmail()
        {
            //
            return true;
        }
        async Task<bool> SendSms()
        {
            // 
            return true;
        }
        Task SendSmsSync()
        {
            // 
            return Task.CompletedTask;
        }
        void SendSmsSync2()
        { 
            // 
        }
    }
}
