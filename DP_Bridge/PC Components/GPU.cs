using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.PC_Components
{
    public class GPU:PC_Component
    {
        public string Model { get; set; }
        public string RamMemory { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"GPU Parameters:\n" +
                $"Name: {Name}" +
                $"\nModel: {Model}" +
                $"\nRam Memory: {RamMemory}"; 
        }
    }
}
