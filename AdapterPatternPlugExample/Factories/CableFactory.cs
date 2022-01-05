using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample.Factories
{
    public static class CableFactory 
    {
        public static Cable Create(CableType cableType)
        {
            switch (cableType)
            {
                case CableType.USB_A:
                    return new Cable(CableType.USB_A);

                case CableType.USB3_0:
                    return new Cable(CableType.USB3_0);

                case CableType.Ethernet:
                    return new Cable(CableType.Ethernet);

                case CableType.HDMI:
                    return new Cable(CableType.HDMI);

                case CableType.cType:
                    return new Cable(CableType.cType);

                case CableType.Lightning:
                    return new Cable(CableType.Lightning);

                default:
                    return null;
            }
        }
    }
}
