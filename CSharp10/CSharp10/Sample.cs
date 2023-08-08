using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp10
{
    //modifier  returnType delegateName(parameters);
    public delegate int? SearchDelegate(List<int> list, int item);

    internal class Sample
    {
        public void Run()
        {
            /*
            List<int> ints = new();

            Console.WriteLine("Write N Item : ");
            for (int i = 0; i < 5; i++)
            {
                var item = Console.ReadLine();
                ints.Add(Convert.ToInt32(item));
            }
            Console.WriteLine("Write Item to Serach : ");
            var findItem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List is Sorted (Y/N) : ");
            var IsSorted = Console.ReadLine();

            //s 1 => interface
            var SearchStrategy = GetStrategy(IsSorted);

            var Result = SearchStrategy.Search(ints, findItem);

            //s 2 => interface

            var searchDelegate = GetStrategyByDelegate(IsSorted);
            var result2 = searchDelegate(ints, findItem);
            */

            Person person = new() { Role = PersonRole.Manager };

            int Reward;
            int salary = 100;
            RewardHelper rewardHelper = new();
            var rewardStrategy = rewardHelper.GetRewardStrategy(person.Role);

            Reward = CalcReward(rewardStrategy, salary);
            //Reward = rewardStrategy(salary);

            // برای تغییر بسته
            //برای توسعه باز
            //S O L I D

            //Action<
            //Func<>

        }

        public int CalcReward(Func<int, int> strategy, int salary)
        {
            var reward = strategy(salary);
            reward = reward * 2 - 100;
            return reward;
        }
        public int CalcReward(RewardStrategy strategy, int salary)
        {
            var reward = strategy(salary);
            reward = reward * 2 - 100;
            return reward;
        }

        public ISearchStrategy GetStrategy(string isSorted)
        {
            if (isSorted == "Y")
                return new BinarySearch();
            else
                return new LinnerSearch();
        }
        public SearchDelegate GetStrategyByDelegate(string isSorted)
        {
            if (isSorted == "Y")
                return SearchStrategy.BinarySearch;
            else
                return SearchStrategy.LinnerSearch;
        }
    }

}
