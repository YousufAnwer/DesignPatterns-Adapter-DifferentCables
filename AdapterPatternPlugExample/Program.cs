using AdapterPatternPlugExample.Factories;
using System;

namespace AdapterPatternPlugExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cable cType = CableFactory.Create(CableType.cType);
            Cable Ethernet = CableFactory.Create(CableType.Ethernet);
            Cable HDMI = CableFactory.Create(CableType.HDMI);
            Cable USB_A = CableFactory.Create(CableType.USB_A);


            Device iPhone = DeviceFactory.Create("iPhone", cType);
            Device Modem = DeviceFactory.Create("Modem", Ethernet);
            Device Moniter = DeviceFactory.Create("Moniter", HDMI);
            Device Keyboard = DeviceFactory.Create("Keyoard", USB_A);
            Device Mouse = DeviceFactory.Create("Mouse", USB_A);

            IConnecterService CoreI5 = new Computer();
            IConnecterService adapter = new DeviceAdapter();



            Console.WriteLine("Device Status");
            Console.WriteLine("==========================");
            adapter.ConnectDevice(iPhone);
            adapter.ConnectDevice(Modem);
            adapter.ConnectDevice(Moniter);
            CoreI5.ConnectDevice(Keyboard);
            CoreI5.ConnectDevice(Mouse);
            Console.WriteLine("==========================");

            CoreI5.MyProperties();
            adapter.MyProperties();


        }
    }
}
