using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampApp
{
    public class LampFactory
    {
        public virtual Lamp Create(uint intensiteit, ConsoleColor kleur)
        {
            return new Lamp(intensiteit, kleur);
        }
    }
}
