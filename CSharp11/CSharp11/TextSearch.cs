using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class TextSearch
    {
        List<string> list = new();
        // HelloWorld ,  TestDaneshkar , CSharp

        //world
        public string Search(string input)
        {
            foreach (var item in list)
            {
                if (item.Contains(input))
                    return item;
            }
            return null;
        }
    }
}
