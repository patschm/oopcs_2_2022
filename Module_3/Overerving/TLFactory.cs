using LampApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    public class TLFactory : LampFactory
    {
        public int StarterTijd { get; set; } = 1000;
        public override Lamp Create(uint intensiteit, ConsoleColor kleur)
        {
            return new TL { Intensiteit = intensiteit, Kleur = kleur, StarterTijd = StarterTijd };
        }
    }
}
