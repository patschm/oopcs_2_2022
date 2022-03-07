namespace MethodsEtc
{
    public class Program
    {
        static void Main()
        {
            WelkomsBericht(1);
            //int getal1 = VraagGetal();
            // int getal2 = VraagGetal();

            //int getal = TelOp(getal1, getal2);
            //int getal = TelOp(1, 2, 3, 4, 5, 6, 7 );
            //int getal = TelOp(y:1);

           // int a;
            // int bla = a;
            var b = DoeIets(out int a);

            Console.WriteLine(a);
            //ToonGetal(getal);
        }

        private static bool DoeIets(out int bla)
        {
            bla = 100;
            return true;
        }

        //static int TelOp(params int[] getallen)
        //{
        //    return getallen.Sum();
        //}
        static int TelOp(double x = 20, double y = 10)
        {
            return (int)(x + y);
        }
        static int TelOp(int x, int y)
        {
            return x + y;
        }
        static void ToonGetal(int getal)
        {
            Console.WriteLine($"Het door u gegeven getal is {getal}");
        }

        // Procedure
        static void WelkomsBericht(int aantal)
        {
            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine("Welkom bij dit geweldige appje");
                Console.WriteLine("Ik tel twee getallen op en de uitkomst is 42");
            }
        }

        static int VraagGetal()
        {          
            do
            {
                Console.WriteLine("Geef een getal");
                string inp = Console.ReadLine();
                if (int.TryParse(inp, out int nr)) return nr;
                Console.WriteLine("Ongeldig getal");
            }
            while (true);
        }
    }
}
