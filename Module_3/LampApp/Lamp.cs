using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampApp
{
    // Dit is de blauwdruk van een lamp
    class Lamp
    {
        // Eigenschappen leg je vast in fields.
        public ConsoleColor kleur = ConsoleColor.Yellow;
        public int intensiteit = 200;
        public float verbruik;
        public string naam;

        // Gedrag leg je vast in methods. (Function or Procedures)
        public void Aan()
        {
            Console.BackgroundColor = kleur;
            Console.WriteLine("De lamp is aan");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        // Constructors zijn bedoeld om fields van een initiele waarde te voorzien.
        public Lamp(int lm, ConsoleColor kl)
        {
            this.intensiteit = lm;
            kleur = kl;
        }
        public Lamp() : this(100, ConsoleColor.Yellow)
        {

        }
    }
}
