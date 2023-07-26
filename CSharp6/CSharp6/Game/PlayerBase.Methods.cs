using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daneshkar
{
    //Methods 
    public abstract partial class PlayerBase 
    {
        public abstract string Icon();

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
