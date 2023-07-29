using Daneshkar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar.Game
{
    public class Box : ILocationObject
    {
        public Box(int x,int y)
        {
            X = x;
            Y = y;
        }
        public int X {get;set;}

        public int Y { get; set; }

        public string Icon()
        {
            return "| |";
        }
    }
    public class Hole : ILocationObject
    {
        public Hole(int x, int y)
        {
            X = x; 
            Y = y;
        }
        public int X { get; set; }

        public int Y { get; set; }

        public string Icon()
        {
            return "( )";
        }
    }

}
