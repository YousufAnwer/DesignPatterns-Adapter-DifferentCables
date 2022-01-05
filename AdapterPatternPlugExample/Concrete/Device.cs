using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public class Device
    {
        public string Name { get; set; }
        public ConnectVia ConnectVia { get; set; }
        public Cable Cable { get; set; }

        public Device(string name, Cable cable)
        {
            Name = name;
            Cable = cable;
        }
        public void MyProperties()
        {
            Console.WriteLine("\tName: " + Name);
            Console.WriteLine("\tConnect Via: " + ConnectVia.ToString());
            Console.WriteLine("\tCable Type: " + Cable.Type.ToString());

        }
    }
}
