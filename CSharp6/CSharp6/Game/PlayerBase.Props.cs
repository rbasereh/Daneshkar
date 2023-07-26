using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar
{

    //props
    public  abstract partial class PlayerBase : ILocationObject
    {
       
        public PlayerBase(string name, int health = 100, int x = 0, int y = 0)
        {
            Name = name;
            Health = health;
            X = x;
            Y = y;
        }
        public string Name { get; protected set; }
        public int Health { get; set; }

        public int X { get; protected set; }
        public int Y { get; protected set; }

    

    }
}
