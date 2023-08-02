using System.Data;

namespace CSharp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var stack = new CustomStack<int>();
            var stack2 = new CustomStack<string>();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            var x4 = queue.Peek();

            var x1 = queue.Dequeue();
            var x2 = queue.Dequeue();
            var x3 = queue.Dequeue();
            
            

            Validator validator = new();
            /*

            //  ( [ ] } { )
            */
            validator.IsValid(new char[] { '(', '{', '[', ']', '}', ')' });
            //validator.IsValid(new char[] { '(', '[', ']', '}', '{', ')' });

            validator.IsValid(new char[] { '{', '[', '}', ']' });
        }
    }




}