using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Bridge
{
    internal class Remote
    {
        protected IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void Increase()
        {
            device.IncreaseVolume();
        }

        public void Decrease()
        {
            device.DecreaseVolume();
        }
    }
}
