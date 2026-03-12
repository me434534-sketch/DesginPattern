using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Bridge
{
    internal interface IDevice
    {
        void IncreaseVolume();
        void DecreaseVolume();
        void Mute();
    }
}
