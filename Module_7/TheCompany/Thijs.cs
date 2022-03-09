using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    public class Thijs : Werknemer
    {
        public override void Werkt()
        {
            Programmeert();
        }
        public void Programmeert()
        {
            Console.WriteLine("Thijs programmeert");
        }
    }
}
