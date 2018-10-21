using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge.PC_Components
{
    public class Hard_Drive
    {
        public string Size { get; set; }
        public override string ToString()
        {
            return $"Hard drive size: {Size}";
        }
    }
}
