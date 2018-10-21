using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.PC_Components
{
    public class Hard_Drive : PC_Component
    {
        public string Size { get; set; }
        public string Name { get;set; }

        public override string ToString()
        {
            return $"Hard drive parameters:\n" +
                $"Name: {Name}" +
                $"\nSize: {Size}";
        }
    }
}
