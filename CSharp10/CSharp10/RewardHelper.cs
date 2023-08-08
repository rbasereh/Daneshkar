using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    public delegate int RewardStrategy(int salary);
    public class RewardHelper
    {
        public RewardStrategy GetRewardStrategy(PersonRole role)
        {
            switch (role)
            {
                case PersonRole.Manager:
                    return CalcRewardManager;
                case PersonRole.Employee:
                    return CalcRewardEmpolyee;
                case PersonRole.Salesman:
                    return CalcRewardSalesman;
                case PersonRole.InventoryUser:
                    return CalcRewardInventoryUser;
                default:
                    return CalcRewardEmpolyee;
            }
        }
     
        public int CalcRewardEmpolyee(int salary)
        {
            return salary * 30;
        }
        public int CalcRewardManager(int salary)
        {
            return salary * 100;
        }
        public int CalcRewardSalesman(int salary)
        {
            return salary * 10;
        }
        public int CalcRewardInventoryUser(int salary)
        {
            return salary * 10;
        }
    }
}
