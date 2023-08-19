using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    internal class Class1
    {
        // n = 10
        // 1 2 3 4 5 6 7 8 9 10
        
        // 1
        // n/2  => O(n)
        // n 

        public static int? LinnerSearch(List<int> list, int item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    return i;
            }
            return null;
        }


        // 1
        // log(n)

        public static int? BinarySearch(List<int> list, int item)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (list[mid] == item)
                    return mid;

                if (list[mid] < item)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
    }
}
