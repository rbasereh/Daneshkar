using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar.New
{
    internal class Helper
    {
        internal void Run()
        {
            int x = 10;
            int y = 0;
            Swap(ref x,ref y);

            char xs = 'a';
            char ys = 'b';
            Swap(ref xs, ref ys);
        }

        //public void Swap(ref int x,ref int y)
        //{
        //    int z = x;
        //    x = y;
        //    y = z;
        //}
        //public void Swap(ref char x, ref char y)
        //{
        //    char z = x;
        //    x = y;
        //    y = z;
        //}
        public void Swap<Type>(ref Type x, ref Type y)
        {
            Type z = x;
            x = y; 
            y = z;
        }
    }

}
