using DP_Bridge.PC_Components;
using DP_Bridge.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge
{
    class Program
    {
        public class PC
        {
            public CPU cpu { get; set; }
            public GPU gpu { get; set; }
            public Hard_Drive hardDrive { get; set; }
            public PC()
            {
                cpu = new CPU { Model = "Intel", Speed = "3.2 GHz" };
                gpu = new GPU { Model = "Nvidia GeForce 1050", RamMemory = "8 GB" };
                hardDrive = new Hard_Drive { Size = "1TB" };
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
