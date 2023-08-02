using System.Data;

namespace CSharp8
{
    internal class Program
    {
        public static IEnumerable<int> GetNumber()
        {
            MyListCollection<int> ints = new MyListCollection<int>();
            ints.Add(1);
            ints.Add(2);
            ints.CustomMethod();
            return ints;
        }
        public static ICollection<int> GetNumber2()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            return ints;
        }
        public static List<int> GetNumber3()
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            return ints;
        }
        static void Main(string[] args)
        {
            var result1 = GetNumber();
            //result1.Add(1);


            var result2 = GetNumber2();
            result2.Add(1);


            var result3 = GetNumber3();
            result3.Add(2);
            result3.Remove(10);

            List<string> strings = new List<string>();
            strings.Add("a");

            Dictionary<string, string> stringDic = new();

            stringDic.Add("a", "Ali");
            stringDic.Add("b", "hasan");
            stringDic.Add("cdfsdfsdf", "hasan");

            var result = stringDic["a"];

            //Stack
            //Queue

            //Stack<>
            //Queue<>
            //ArrayList
            List<int> ints = new List<int>();

            ints.Add(1);






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

            CustomQueue<int> customQueue = new();
            customQueue.Enqueue(44);
            customQueue.Enqueue(66);
            customQueue.Enqueue(77);

            var y1 = customQueue.Dequeue();
            var y2 = customQueue.Peek();
            var y3 = customQueue.Dequeue();

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