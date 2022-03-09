using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    public static class OntvangstMethodes
    {
        public static void ViaKabel(string m)
        {
            Console.WriteLine($"Via kabel ontvangen: {m}");
        }
        public static void ViaEther(string m)
        {
            Console.WriteLine($"Via ether ontvangen: {m}");
        }
        public static void ViaSMS(string m)
        {
            Console.WriteLine($"Via sms ontvangen: {m}");
        }
        public static void ViaRooksignalen(string m)
        {
            Console.WriteLine($"Via rooksignalen ontvangen: {m}");
        }
        public static void ViaPostduif(string m)
        {
            Console.WriteLine($"Via postduif ontvangen: {m}");
        }
    }
}
