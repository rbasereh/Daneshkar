using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    internal class TupleIntro
    {
        public void Run()
        {
            int x = 0, y = 0;

            var result = Calc2(x, y);
            var resulta = result.a;

            (int i, char j, string k) result2 = Calc2(x, y);
            var resultj = result2.j;

            (x, int m, _) = Calc2(x, y);


        }
        public (int a, char b, string c) Calc2(int x, int y)
        {
            return (x, 'y', "String C");
        }
    }
}
