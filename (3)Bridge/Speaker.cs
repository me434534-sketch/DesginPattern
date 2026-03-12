using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Bridge
{
    internal class Speaker : IDevice
    {
        public void IncreaseVolume()
        {
            Console.WriteLine("Speaker volume up");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Speaker volume down");
        }

        public void Mute()
        {
            Console.WriteLine("Speaker muted");
        }
    }
}
