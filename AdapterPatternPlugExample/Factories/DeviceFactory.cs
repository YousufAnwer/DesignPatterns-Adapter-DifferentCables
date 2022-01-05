using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample.Factories
{
    public static class DeviceFactory
    {
        public static Device Create(string name, Cable cable)
        {
            return new Device(name, cable);
        }
    }
}
