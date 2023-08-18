using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp11
{
    //public delegate void PrintDel(string text);
    internal class PrintHandler
    {
        //public void Print(int type, PrintDel printDel)
        public void Print(int type, Action<string> printDel)
        {
            string text = "";
            //if (type == 0)
            //    PrintTypes.Print1(text);
            //else
            //    PrintTypes.Print2(text);
            printDel(text);
        }

    }

    internal static class PrintTypes
    {
        public static void Print1(string text)
        {
            Console.WriteLine(text);
        }
        public static void Print2(string text)
        {
            Console.Write("Begin");
            Console.Write(text);
            Console.Write("End");
        }
    }

}
