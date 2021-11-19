using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.StructuralPatterns.Bridge
{
    class Device
    {
        public void SetChannel(int channel) => Console.WriteLine($"{GetType().Name} channel: {channel}");
        public void SetVolume(int volume) => Console.WriteLine($"{GetType().Name} volume: {volume}");
    }

    class TV : Device { }
    class Radio : Device { }
}
