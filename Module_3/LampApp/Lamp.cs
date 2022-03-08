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
        //private ConsoleColor kleur = ConsoleColor.Yellow;
        private uint intensiteit = 200;

        public float Verbruik
        {
            get
            {
                return 150 * intensiteit;
            }
        }
        // Auto-generating property
        public ConsoleColor Kleur { get; set; }
        public string Naam { get; set; }

        public uint Intensiteit
        {
            set
            {
                if (value >= 0 && value < 1000)
                {
                    intensiteit = value;
                }
            }
            get
            {
                return intensiteit;
            }
        }

        // Gedrag leg je vast in methods. (Function or Procedures)
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp is aan ({intensiteit} lumen)");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        // Constructors zijn bedoeld om fields van een initiele waarde te voorzien.
        public Lamp(uint lm, ConsoleColor kl)
        {
            this.Intensiteit = lm;
            Kleur = kl;
        }
        public Lamp() : this(100, ConsoleColor.Yellow)
        {

        }
    }
}
