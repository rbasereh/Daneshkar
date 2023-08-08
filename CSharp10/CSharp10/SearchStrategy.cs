namespace CSharp10
{
    public static class SearchStrategy
    {
        public static int? LinnerSearch(List<int> list, int item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    return i;
            }
            return null;
        }
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
