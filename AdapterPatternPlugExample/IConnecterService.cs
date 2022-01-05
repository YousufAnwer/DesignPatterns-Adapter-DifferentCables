using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public interface IConnecterService
    {
        void ConnectDevice(Device device);
    }
}
