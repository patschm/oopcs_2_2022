using IEEE;

namespace Philips
{
    public class Lamp: IDevice
    {
        public void Aan()
        {
            Console.WriteLine("De lamp brandt");
        }

        public void Activate()
        {
            Aan();
        }
    }
}