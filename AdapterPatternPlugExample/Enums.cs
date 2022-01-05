using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public enum CableType
    {
        USB_A,
        USB3_0,
        Ethernet,
        HDMI,
        cType,
        Lightning

    }
    public enum Port
    {
        //system sopports only
        USB_A
    }
    public enum ConnectVia
    {
        ViaDirectPort,
        ViaAdapter
    }
}
