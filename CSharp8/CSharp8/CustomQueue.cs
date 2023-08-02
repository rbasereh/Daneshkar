namespace CSharp8
{
    public class CustomQueue<T>
    {
        T[] items = new T[10];
        int Head = 0;
        int Back = 0;

        internal void Enqueue(T item)
        {
            if (Back > items.Length)
                Array.Resize(ref items, items.Length + 10);
            items[Back] = item;
            Back++;
        }
        internal T Dequeue()
        {
            T item = items[Head];
            items[Head] = default(T);
            Head++;
            return item;
        }

        internal T Peek()
        {
            T item = items[Head];
            return item;
        }
    }



}