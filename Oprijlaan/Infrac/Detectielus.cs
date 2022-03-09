using IEEE;

namespace Infrac
{
    public class Detectielus
    {
        public event Activator Detecting;

        private IDevice[] devices = new IDevice[5];

        public void Connect(Activator act)
        {
            Detecting += act;
        }

        public void Connect(IDevice device)
        {
            for(int i = 0; i < devices.Length; i++)
            {
                if (devices[i] == null)
                {
                    devices[i] = device;
                    return;
                }
            }
        }
        public void Detect()
        {
            Console.WriteLine("De detectielus ziet iets");
            Detecting?.Invoke();
            
            foreach(IDevice device in devices)
            {
                device?.Activate();
            }
        }
    }
}