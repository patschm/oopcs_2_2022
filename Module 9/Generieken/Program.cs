using System.Text;

namespace Generieken
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder bld = Create<StringBuilder>();
            bld.Append("Hoi");

            Console.WriteLine(bld.ToString());

            Point<uint> pp1 = new Point<uint> { X = 1, Y = 2 };
            Point<float> pp2 = new Point<float> { X = 1.2F, Y = 2.3F };
            Console.WriteLine(pp1);
            Console.WriteLine(pp2);

            uint a = 10;
            uint b = 20;
            Console.WriteLine($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

        }
        //static void Swap(ref int aa, ref int bb)
        //{
        //    int c = aa;
        //    aa = bb;
        //    bb = c;
        //}
        //static void Swap(ref short aa, ref short bb)
        //{
        //    short c = aa;
        //    aa = bb;
        //    bb = c;
        //}
        //static void Swap(ref float aa, ref float bb)
        //{
        //    float c = aa;
        //    aa = bb;
        //    bb = c;
        //}
        static void Swap<Tito>(ref Tito aa, ref Tito bb)
        {
            Tito c = aa;
            aa = bb;
            bb = c;
        }

        static T Create<T>() where T: new()
        {
            return new T();
        }
    }
}
