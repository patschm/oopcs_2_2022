namespace Statisch
{
    class Program
    {
       static void Main()
        {
            //Etage.Elevator.Call(10);

            Etage[] flat = new Etage[40];
            for(int i = 0; i < flat.Length; i++)
            {
                flat[i] = new Etage { Nummer = i };
            }


            flat[21].RoepElevator();

            foreach(Etage et in flat)
            {
                //Etage.ShowStatus();
            }


            Punt p1 = new Punt { X = 10, Y = 20 };
            p1.Show();
            Punt p2 = Punt.Create(100, 200);
            p2.Show();

            Punt pres = p1 + p2;
            pres.Show();

            Console.WriteLine(p1 == p2);


            string s = "Hallo";
            s.SponsoredBy("ACME");

            //Console.WriteLine(s);

            42.SponsoredBy("acme");
        }
    }
        
}