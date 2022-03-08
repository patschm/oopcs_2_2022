using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statisch
{
    public class Punt
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Punt operator+ (Punt px, Punt py)
        {
            return new Punt { X = px.X + py.X, Y = px.Y + py.Y };
        }

        public static bool operator==(Punt px, Punt py)
        {
            return px.X == py.X && px.Y == py.Y;
        }
        public static bool operator !=(Punt px, Punt py)
        {
            return !(px == py);
        }
        public void Show()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public static Punt Create(int x, int y)
        {
            return new Punt { X=x, Y=y };   
        }
        //private Punt()
        //{

        //}
    }
}
