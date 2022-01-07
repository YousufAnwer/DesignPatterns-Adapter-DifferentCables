using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public class Computer : IConnecterService
    {
        private Port _port { get; set; }
        protected static List<Device> ConnectedDevices { get; set; }


        public Computer()
        {
            //only have support of USB_A type
            _port = Port.USB_A;
            ConnectedDevices = new List<Device>();
        }



        public virtual void ConnectDevice(Device device)
        {
            if (device.Cable.Type.ToString() == Port.USB_A.ToString())
            {
                device.ConnectVia = ConnectVia.ViaDirectPort;
                ConnectedDevices.Add(device);
                Console.WriteLine("Devices Connected\n");
            }
            else
            {
                Console.WriteLine("Not Supported");
            }
        }
        public virtual void MyProperties()
        {
            Console.WriteLine("System Details");
            Console.WriteLine("\tPort Support: " + _port.ToString());
            Console.WriteLine("Connected Devices");
            foreach (var item in ConnectedDevices)
            {
                item.MyProperties();
                Console.WriteLine("\n");
            }
            Console.WriteLine("==========================");
        }
    }
}
