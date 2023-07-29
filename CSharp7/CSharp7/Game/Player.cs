using Daneshkar;
using System.Xml.Linq;

namespace Daneshkar
{

    public class Player : PlayerBase
    {
        public Player() : base("")
        {
            
        }
        public Player(string name, int xplayer, int yplayer)
            : base(name, x: xplayer, y: yplayer)
        {
        }

        public override string Icon()
        {
            return " @ ";
        }
    }
}