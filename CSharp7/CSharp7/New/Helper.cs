using Daneshkar.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar.New
{
    internal class Helper
    {
        internal void Run()
        {
            Stack<int> stack = new Stack<int>();
            CusomtStack<int> cstack = new CusomtStack<int>();
            cstack.Push(20);
            cstack.Push(30);
            cstack.Push(50);

            stack.Push(20);
            stack.Push(30);
            stack.Push(50);


            CusomtStack<Player> playerStack = new CusomtStack<Player>();
            CusomtStack<PlayerBase> playerStack2 = new CusomtStack<PlayerBase>();



            var firstOut = stack.Pop();
            var firstOut2 = cstack.Pop();


            //int[] ints = new int[] { 6, 2, 8, 4, 10 };
            int[] ints = new int[] { 10, 8, 6, 4, 2 };
            var result = BSort<int>.Sort(ints);

            int x = 10;
            int y = 0;
            BSort<int>.Swap(ref x, ref y);

            char xs = 'a';
            char ys = 'b';
            BSort<char>.Swap(ref xs, ref ys);
        }

        //public void Swap(ref int x, ref int y)
        //{
        //    int z = x;
        //    x = y;
        //    y = z;
        //}
        //public void Swap(ref char x, ref char y)
        //{
        //    char z = x;
        //    x = y;
        //    y = z;
        //}

    }

    public static class BSort<TInput>
    {
        //public static void Swap<TInput>(ref TInput x, ref TInput y)
        //{
        //    TInput z = x;
        //    x = y;
        //    y = z;
        //}
        public static int XMethod()
        {

            return 10;
        }
        public static void Swap(ref TInput x, ref TInput y)
        {
            TInput z = x;
            x = y;
            y = z;
        }
        public static TInput[] Sort(TInput[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (string.Compare(arr[j].ToString(), arr[j + 1].ToString()) == 1)
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
            return arr;
        }
        //public static double[] Sort(double[] arr)
        //{
        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = 0; j < arr.Length - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //                Swap(ref arr[j], ref arr[j + 1]);
        //        }
        //    }
        //    return arr;
        //}
    }

}
