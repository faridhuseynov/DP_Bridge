using DP_Bridge.PC_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.Properties
{
    public class CPU : PC_Component
    {
        public string Name { get;set; }
        public string Speed { get; set; }
        public override string ToString()
        {
            return $"CPU Parameters:\n" +
                $"Name: {Name}" +
                $"\nSpeed: {Speed}";
        }
    }
}
