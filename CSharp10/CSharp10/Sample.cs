using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp10
{
    internal class Sample
    {
        public void Run()
        {
            List<int> ints = new();

            Console.WriteLine("Write N Item : ");
            for (int i = 0; i < 5; i++)
            {
                var item = Console.ReadLine();
                ints.Add(Convert.ToInt32(item));
            }
            Console.WriteLine("Write Item to Serach : ");
            var findItem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List is Sorted (Y/N) : ");
            var IsSorted = Console.ReadLine();

            var SearchStrategy = Search(IsSorted);
        }

        public ISearchStrategy Search(string isSorted)
        {
            if (isSorted == "Y")
                return new BinarySearch();
            else
                return new LinnerSearch();
        }

    }
    public interface ISearchStrategy
    {
        int? Search(List<int> list, int item);

    }
    public class LinnerSearch : ISearchStrategy
    {
        public int? Search(List<int> list, int item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    return i;
            }
            return null;
        }
    }
    public class BinarySearch : ISearchStrategy
    {
        // 10 55 6 9 20  
        // 6 9 10 20 55 
        public int? Search(List<int> list, int item)
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
