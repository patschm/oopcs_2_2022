
namespace Weken
{
    using Iets;

    namespace Iets
    {
        enum WeekDays : ulong
        {
            Zondag = 1,
            Maandag = 2,
            Dinsdag = 4,
            Woensdag = 8,
            Donderdag = 16,
            Vrijdag = 32,
            Zaterdag = 64
        }
    }

   
    public class Program
    {

        static void Main()
        {
            int dagVanWeek = 3;
            Weken.Iets.WeekDays dayw = WeekDays.Dinsdag;
            Console.WriteLine((WeekDays)dagVanWeek);
        }
    }
}
