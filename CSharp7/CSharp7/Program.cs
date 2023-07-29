using Daneshkar.New;

namespace Daneshkar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pcout = Environment.ProcessorCount;
            //var LogicalDrives = Environment.GetLogicalDrives();

            //GameEnv gameEnv = new GameEnv();
            //gameEnv.Run();

            Helper helper = new Helper();
            helper.Run();
        }
    }
}