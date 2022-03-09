using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    class ACME
    {
        private List<IContract> Werknemers { get; set; } = new List<IContract>();

        public void Hire(IContract wn)
        {
            Werknemers.Add(wn);
        }
        public void Stoomfluit()
        {
            Console.WriteLine("ACME gaat produceren");
            foreach (IContract w in Werknemers)
            {
                w?.VoerUit();
            }
        }
    }
}
