using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Bridge
{
    internal class TV : IDevice
    {
        public void IncreaseVolume()
        {
            Console.WriteLine("TV volume up");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("TV volume down");
        }

        public void Mute()
        {
            Console.WriteLine("TV muted");
        }
    }
}
