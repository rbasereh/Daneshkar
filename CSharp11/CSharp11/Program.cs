using System.ComponentModel.Design.Serialization;

namespace CSharp11
{
    internal class Program
    {

        public static int CountUnique(int[] ints)
        {
            int cnt = 1;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] != ints[i + 1])
                    cnt++;
            }
            return cnt;
        }
        public static int CountUnique2(int[] ints)
        {
            int cnt = 1;
            List<int> list = new();
            for (int i = 0; i < ints.Length; i++)
            {
                // O(n)
                if (!list.Contains(ints[i]))
                    list.Add(ints[i]);
            }
            return list.Count;
        }
        public static int CountUnique3(int[] ints)
        {
            int cnt = 1;
            Dictionary<int, bool> dic = new();
            for (int i = 0; i < ints.Length; i++)
            {
                //O(1)
                if (!dic.ContainsKey(ints[i]))
                    dic.Add(ints[i], true);
            }
            return dic.Keys.Count;
        }


        public static bool IsValid(char[] chars)
        {
            //( , [, < , { 
            //)   ]  >   }
            Stack<char> stack = new Stack<char>();
            char topOfStack = ' ';
            for (int i = 0; i < chars.Length; i++)
            {
                if (stack.Count != 0)
                    topOfStack = stack.Peek();
                bool result = checkForRemove(chars[i], topOfStack);
                if (result)
                    stack.Pop();
                else
                    stack.Push(chars[i]);
            }
            if (stack.Count != 0)
                return false;
            return true;
        }

        private static bool checkForRemove(char input, char topOfStack)
        {
            if ((topOfStack == '(' && input == ')')
                || (topOfStack == '[' && input == ']')
                || (topOfStack == '<' && input == '>')
                || (topOfStack == '{' && input == '}')
                )
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Tree tree = new("Root");
            Tree childl1 = new("child Left 1");
            Tree childr1 = new("child Right 1");
            tree.LeftChild = childl1;
            tree.RightChild = childr1;



            //............................
            char[] chars = new char[] { '(', ')' };
            char[] chars2 = new char[] { '(', '[', ']', ')', '[', ']' };
            char[] chars3 = new char[] { '(', '(', ')', ')', '[', ']' };
            bool res = IsValid(chars3);

            int[] ints = new int[] { 2, 2, 2, 3, 4, 4, 4, 5, 6 };
            // 2 3 4 5 6
            // 5

            int cnt = CountUnique(ints);
            int cnt2 = CountUnique2(ints);





            List<string> list = new List<string>();
            string str = "   helloWorldTest    ";
            int i2 = ints[2];

            char ch6 = str[6];

            string strTrimStart = str.TrimStart();
            string strTrimEnd = str.TrimEnd();
            string strTrim = str.Trim();

            string strSubStr = str.Substring(3, 10);


            var str2 = String.Join(' ', str.Reverse());
            str.PadLeft(2);
            str.Remove(2);
            //str.Split




            RewardHelper rewardHelper = new();
            rewardHelper.Run();
        }
    }

    public class Tree
    {
        public Tree(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public Tree LeftChild { get; set; }
        public Tree RightChild { get; set; }
    }
}