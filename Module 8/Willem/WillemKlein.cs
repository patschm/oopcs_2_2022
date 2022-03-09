using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willem
{
    public delegate int MathDel(int x, int y);

    public class WillemKlein
    {
        public void Bereken(MathDel fn, int a, int b)
        {
            Console.WriteLine("Willem Klein gaat rekenen:");
            int result = fn(a, b);


            Console.WriteLine($"Het antwoord is {result}");
        }
    }
}
