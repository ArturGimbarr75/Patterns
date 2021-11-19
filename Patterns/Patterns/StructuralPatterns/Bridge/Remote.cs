using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Bridge
{
    class Remote
    {
        protected Device _device;

        public Remote(Device device)
        {
            _device = device;
        }

        public void SetVolume(int volume) => _device.SetVolume(volume);
        public void SetChannel(int channel) => _device.SetChannel(channel);
    }

    class SuperRemote : Remote
    {
        public SuperRemote(Device device) : base(device)
        {
            _device = device;
        }

        public void Mute() => _device.SetVolume(0);
    }
}
