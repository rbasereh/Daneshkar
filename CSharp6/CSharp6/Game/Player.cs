using Daneshkar;

namespace Daneshkar
{

    public class Player : PlayerBase
    {
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