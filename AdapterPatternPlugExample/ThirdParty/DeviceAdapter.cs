using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public class DeviceAdapter : Computer, IConnecterService
    {
        public override void ConnectDevice(Device device)
        {
            var newDevice = Convert2USB_A(device);
            ConnectedDevices.Add(newDevice);
            Console.WriteLine("Devices Connected\n");
        }

        private Device Convert2USB_A(Device device)
        {
            //Applying Some Machenism here...
            device.ConnectVia = ConnectVia.ViaAdapter;
            return device;
        }
        public override void MyProperties()
        {
            Console.WriteLine("Name: Adapter1002");
            Console.WriteLine("Company: Kingston");
        }

    }
}
