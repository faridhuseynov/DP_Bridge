using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.Properties
{
    public class CPU
    {
        public string Model { get; set; }
        public string Speed { get; set; }
        public override string ToString()
        {
            return $"CPU Parameters:\n" +
                $"Model: {Model}" +
                $"\nSpeed: {Speed}";
        }
    }
}
