using System.Collections;
using System.Globalization;

namespace CSharp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int q = 0;
            int w = 0;
            int e = 0;
            Calc1(q);
            Calc2(ref w);
            Calc3(out e);
        }
        public static void Calc1(int x)
        {
            x++;
        }
        public static void Calc2(ref int x)
        {
            x++;
        }
        public static void Calc3(out int x)
        {
            x = 0;
            x++;
        }
    }

}