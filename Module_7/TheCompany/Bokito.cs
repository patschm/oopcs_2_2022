using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class Bokito : IContract, IContract2
    {
        void IContract2.VoerUit()
        {
            Werkt();
        }
        public void VoerUit()
        {
            Werkt();
        }

        public void Werkt()
        {
            Console.WriteLine("Bokito mept dames in elkaar");
        }
    }
}
