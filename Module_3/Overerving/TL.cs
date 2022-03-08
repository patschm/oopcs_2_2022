using LampApp;
namespace Overerving
{
    public class TL : Lamp
    {
        public int StarterTijd { get; set; } = 600;

        public override void Aan()
        {
            for(int i = 0; i < StarterTijd/200; i++)
            {
                Console.BackgroundColor = Kleur; 
                Console.WriteLine("Knipper");
                Task.Delay(StarterTijd / 3).Wait();           
                Console.ResetColor();
            }
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp is aan ({Intensiteit} lumen)");
        }
        public TL() : base(100, ConsoleColor.Yellow)
        {

        }
    }
}
