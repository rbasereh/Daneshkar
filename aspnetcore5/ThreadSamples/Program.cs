namespace ThreadSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadSample threadSample = new();
            threadSample.RunThread().GetAwaiter().GetResult();
        }
    }
}