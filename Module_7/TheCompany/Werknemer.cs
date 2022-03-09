using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    public class Werknemer : Person, IContract
    {
        public void VoerUit()
        {
            Werkt();
        }

        public virtual void Werkt()
        {
            Console.WriteLine("De werknemer werkt");
        }
    }
}
