using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternPlugExample
{
    public class Cable
    {
        public CableType Type { get; set; }
        public Cable(CableType type)
        {
            Type = type;
        }
        public void Info()
        {
            Console.WriteLine("Type: " + Type);
        }
        
    }
}
