using Daneshkar.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar.New
{
    public interface IMovable
    { }
    internal class CusomtStack<T>
        //where T : PlayerBase, ILocationObject, IMovable, new()
    {
        T[] items = new T[2];
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
            ///*******************
            ///
            var value = items[--current];
            items[current] = default(T);
            return value;
        }
    }
}
