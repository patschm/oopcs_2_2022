using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statisch
{
    class Etage
    {
        public int Nummer { get; set; }
        public static Lift Elevator { get; set; } = new Lift();

        public void RoepElevator()
        {
            Etage.Elevator.Call(Nummer);
        }
        public static void ShowStatus()
        {
            Console.WriteLine($"De lift staat op de {Etage.Elevator.CurrentFloor}e verdieping");
        }
    }
}
