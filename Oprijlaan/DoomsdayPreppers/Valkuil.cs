﻿using IEEE;

namespace DoomsdayPreppers
{
    public class Valkuil : IDevice
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("De valkuil met spiezen opent");
        }
    }
}