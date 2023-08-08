namespace CSharp10
{
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
