namespace CSharp8
{
    public class CustomStack<T>
    {
        T[] items = new T[10];
        int current = 0;
        public void Push(T item)
        {
            if (current >= items.Length)
                Array.Resize(ref items, items.Length + 10);
            items[current] = item;
            current++;
        }
        public T Pop()
        {
            current = current - 1;
            var value = items[current];
            items[current] = default(T);
            return value;
        }
        public T Peek()
        {
            var value = items[current - 1];
            return value;
        }
        public bool HasItem()
        {
            return current != 0;
        }

    }



}