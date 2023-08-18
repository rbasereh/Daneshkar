using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    //Func
    //Action
    public delegate int SalaryStrategy(int year);
    public delegate int RewardStrategyType(int year);
    public delegate int TaxStrategy(int year, int x);

    public class RewardHelper
    {
        public void Run()
        {
            Person person = new();
            //SalaryStrategy strategy = GetCalcStrategy(person);
            Func<int, int> strategy = GetCalcStrategy2(person);
            int result = Calc(person, strategy);
        }
        public SalaryStrategy GetCalcStrategy(Person person)
        {
            if (person.Type == 1)
                return RewardStrategy.CalcReward;
            //if (person.Type == 3)
            //{
            //    //....
            //}
            else
                return RewardStrategy.CalcReward2;
        }

        public Func<int, int> GetCalcStrategy2(Person person)
        {
            if (person.Type == 1)
                return RewardStrategy.CalcReward;
            //if (person.Type == 3)
            //{
            //    //....
            //}
            else
                return RewardStrategy.CalcReward2;
        }



        //public int Calc(Person person, SalaryStrategy strategy)
        public int Calc(Person person, Func<int, int> strategy)
        {
            var reward = 0;
            reward += 100;

            //if (person.Type == 1)
            //{
            //    reward = RewardStrategy.CalcReward(person.Year);
            //}
            //else if (person.Type == 2)
            //{
            //    reward = RewardStrategy.CalcReward2(person.Year);
            //}

            reward = strategy(person.Year);

            reward *= 2;
            return reward;
        }

    }
    public static class RewardStrategy
    {
        public static int CalcReward(int year)
        {
            return year * 10;
        }
        public static int CalcReward2(int year)
        {
            return year * 20;
        }
    }
    public class Person
    {
        public int Type { get; set; }
        public int Year { get; set; }
    }
}
