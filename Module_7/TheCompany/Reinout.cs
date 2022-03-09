namespace TheCompany
{
    class Reinout : Werknemer
    {
        public override void Werkt()
        {
            DoetWat();
        }
        public void DoetWat()
        {
            Console.WriteLine("Reinout doet iets");
        }
    }
}