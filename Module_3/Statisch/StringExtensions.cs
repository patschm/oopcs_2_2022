using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statisch
{
    static class StringExtensions
    {
        public static void SponsoredBy(this object x, string brand)
        {
            Console.WriteLine($"{x} is sponsored by {brand}");
        }
    }
}
