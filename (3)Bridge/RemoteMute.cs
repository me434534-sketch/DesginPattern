using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Bridge
{
    internal class RemoteMute : Remote
    {
        public RemoteMute(IDevice device) : base(device) { }

        public void Mute()
        {
            device.Mute();  
        }
    }
}
