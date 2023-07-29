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
        int z = 0;
        internal void Run()
        {
            z++;
            var x = 10;
            ActionONX(x);

            var y = 10;
            ActionONY(ref y);
            //var y = 0;
            //Swap(x, y);

            //Console.WriteLine(x);
            //Console.WriteLine(y);

        }
        public void ActionONX(int a)
        {
            z++;
            //x = 5;
            a++;
        }
        public void ActionONY(ref int b)
        {
            b++;
            ActionOnY2(ref b);
        }
        public void ActionOnY2(ref int c)
        {
            c *= 2;
        }

        public void Swap(int x, int y)
        {
            y++;
            x++;
        }

    }

}
