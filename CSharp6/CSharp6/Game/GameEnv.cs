using CSharp6.Game;
using Daneshkar;
using System;

namespace Daneshkar
{
    public class GameEnv
    {

        string[,] Mat;

        public GameEnv()
        {
            Settings.MapSize = 20;
            Settings.HoleCount = 4;
            Settings.BoxCount = 5;
            Mat = new string[Settings.MapSize + 1, Settings.MapSize + 1];
        }

        private void SetObjectsLocation(List<ILocationObject> objects)
        {
            foreach (var obj in objects)
            {
                Mat[obj.X, obj.Y] = obj.Icon();
            }

            //for(int i=0; i<Mat.Length; i++)
            //{
            //    Mat[objects[i].X, objects[i].Y] = objects[i].Icon();
            //}
        }
        private void Display(List<ILocationObject> objects)
        {
            SetMartix(objects);
            Console.Clear();
            string str = "";
            for (int i = 0; i <= Settings.MapSize; i++)
            {
                for (int j = 0; j <= Settings.MapSize; j++)
                {
                    str += Mat[i, j];
                }
                str += Environment.NewLine;
            }
            Console.WriteLine(str);
        }

        private void SetMartix(List<ILocationObject> objects)
        {
            for (int i = 0; i <= Settings.MapSize; i++)
            {
                for (int j = 0; j <= Settings.MapSize; j++)
                {
                    if (i == 0
                         || j == 0
                         || i == Settings.MapSize
                         || j == Settings.MapSize)
                        Mat[i, j] = " # ";
                    else
                        Mat[i, j] = "   ";

                    SetObjectsLocation(objects);
                }
            }
        }
        //private List<ILocationObject> CreateObjects()
        //{
        //    List<ILocationObject> locationObjects = new List<ILocationObject>();

        //    for (int i = 0; i <= Settings.BoxCount; i++)
        //    {
        //        Box box1 = new(15, 15);
        //    }
        //}

        public void Run()
        {

            List<ILocationObject> locationObjects = new List<ILocationObject>();
            Player player = new("me", 10, 10);
            locationObjects.Add(player);

            Box box1 = new(15, 15);
            Box box2 = new(5, 5);
            Hole hole1 = new(7, 7);
            Hole hole2 = new(7, 15);
            Hole hole3 = new(15, 9);
            locationObjects.Add(box1);
            locationObjects.Add(box2);
            locationObjects.Add(hole1);
            locationObjects.Add(hole2);
            locationObjects.Add(hole3);


            Display(locationObjects);

            while (true)
            {
                var ch = Console.ReadKey();
                int x = 0;
                int y = 0;
                switch (ch.Key)
                {
                    case ConsoleKey.LeftArrow:
                        y--;
                        break;
                    case ConsoleKey.UpArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        y++;
                        break;
                    case ConsoleKey.DownArrow:
                        x++;
                        break;
                    default:
                        return;
                }
                player.Move(x, y);
                Display(locationObjects);
            }
        }

    }
}