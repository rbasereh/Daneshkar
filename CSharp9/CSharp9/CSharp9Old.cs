//using System.Collections;
//using System.Globalization;
//using System.Runtime.InteropServices;
//using System.Security.AccessControl;

//namespace CSharp9
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//            ArrayList arrayList = new();

//            //IEnumerable<User> users1 = users;
//            //ICollection<User> users2 = users;
//            //IList<User> users3 = users;

//            //users2.Add(new User());

//            ////var result2 = users2[1];
//            ////var result = users3[1];

//            //Queue queue = new();
//            //Queue<User> UserQueue;

//            //Stack stack = new();
//            //Stack<User> UserStack;

//            //queue.Enqueue(new Program());
//            //queue.Enqueue(new User());
//            List<User> users = new();

//            User UserAli = new User() { Name = "Ali", NCode = "888" };
//            User UserHasan = new User() { Name = "Hasan", NCode = "999" };
//            User UserReza = new User() { Name = "Reza", NCode = "777" };


//            users.Add(UserHasan);
//            users.Add(UserAli);
//            users.Add(UserReza);

//            users.Remove(UserAli);
//            users.RemoveAt(1);
//            //var User0 = users[0];
//            //var User1 = users[1];
//            //var User2 = users[2];



//            Dictionary<string, User> UserDictionary = new();

//            UserDictionary.Add("999", UserHasan);
//            UserDictionary.Add("777", UserAli);
//            UserDictionary.Add("111", UserAli);
//            UserDictionary.Add("110", UserAli);
//            UserDictionary.Add("112", UserAli);
//            UserDictionary.Add("113", UserAli);
//            //UserDictionary.Add("888",UserReza);
//            var resultAdd = UserDictionary.TryAdd("888", UserReza);
//            var resultAdd2 = UserDictionary.TryAdd("888", UserReza);


//            var User0 = UserDictionary["999"];
//            var User1 = UserDictionary["777"];
//            var User2 = UserDictionary["888"];

//            //var User3 = UserDictionary["987"];

//            var result = UserDictionary.TryGetValue("888", out User user);
//            Console.Write(user.LName);

//            var result2 = UserDictionary.TryGetValue("987", out User user2);
//            if (user2 != null)
//                Console.Write(user2.LName);

//            //Console.Write(user2.LName);

//            UserDictionary.Remove("999");


//            User findAli;
//            foreach (var item in UserDictionary)
//            {
//                if (item.Value.Name == "Ali")
//                {
//                    findAli = item.Value;
//                }
//            }
//            //var FindAli2 = UserDictionary.First(e => e.Value.Name == "Ali");

//            Dictionary<bool, User> dict = new();
//            dict.Add(true, UserAli);
//            dict.TryAdd(true, UserHasan);
//            dict.Add(false, UserAli);

//            Dictionary<UserStatus, User> dict2 = new();
//            dict2.Add(UserStatus.Active, UserAli);
//            dict2.TryAdd(UserStatus.Draft, UserHasan);
//            dict2.Add(UserStatus.Inactive, UserAli);

//            int a = 0;
//            int b = 0;

//            Calc(ref a, ref b);

//            MethodResult methodResult = CalcStruct(a, b);
//            a = methodResult.X;
//            b = methodResult.Y;

//            //1
//            var result3 = Calc2(a, b);
//            a = result3.a;
//            b = result3.b;

//            //2
//            (int i, int j, int k) result4 = Calc2(a, b);
//            a = result4.i;
//            b = result4.j;

//            //3
//            (a, _, int k) = Calc2(a, b);

//            Console.Write(k);

//            (int x, int y, int z) testTuple = new(10, 1, 20);

//            Tuple<int, int, int> tuple = new(20, 30, 40);

//            ValueTuple<int, int, int> Vtuple = new(20, 30, 40);

//            CalcWithParams(1000, 1, 2, 34, 5, 6, 238, 34, 5, 7, 8, 8, 30);

//            int[] arra = new int[] { 10, 20, 35, 36 };
//            CalcWithArray(10, arra);
//            CalcWithArray(10, new int[] { 10, 20, 35, 36 });


//        }

//        public static void Calc((int x, User y, char z) tuple)
//        {

//        }
//        public static void Calc(ref int x, ref int y)
//        {
//            x++;
//            y++;
//        }
//        public static (int a, int b, int c) Calc2(int x, int y)
//        {
//            x++;
//            y++;
//            return (x, y, 10);
//        }
//        public static MethodResult CalcStruct(int x, int y)
//        {
//            return new MethodResult();
//        }
//        public static void CalcWithParams(int x, params int[] y)
//        {

//        }
//        public static void CalcWithArray(int x, int[] y)
//        {

//        }
//    }
//}