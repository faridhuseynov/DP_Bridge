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
            public List<PC_Component> components { get; set; }
            public IReporter reporter { get; set; }
            public PC()
            {
                components = new List<PC_Component> {
                    new CPU { Name = "Intel", Speed = "3.2 GHz" },
                    new GPU { Name = "Nvidia ", Model = "GeForce 1050", RamMemory = "8GB" },
                    new Hard_Drive { Name = "Segate", Size = "1TB" } };
            }
            public void Report()
            {
                reporter.Print(components);
            }
        }

        public interface IReporter
        {
            void Print(List<PC_Component> pC_Component);
        }

        class CpuReporter : IReporter
        {
            public void Print(List<PC_Component> pC_Component)
            {
                Console.WriteLine(pC_Component[0].ToString());
            }
        }
        class GpuReporter : IReporter
        {
            public void Print(List<PC_Component> pC_Component)
            {
                Console.WriteLine(pC_Component[1].ToString());
            }
        }
        class HardDriveReporter : IReporter
        {
            public void Print(List<PC_Component> pC_Component)
            {
                Console.WriteLine(pC_Component[2].ToString());
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select component to get info:\n" +
                    "1.CPU\n" +
                    "2.GPU\n" +
                    "3.Hard drive\n" +
                    "4.Exit\n" +
                    "Your choice:");
                ConsoleKeyInfo choice = Console.ReadKey(true);


                var newPC = new PC();
                if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.NumPad1)
                {
                    newPC.reporter = new CpuReporter();
                    newPC.Report();
                }
                else if (choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.NumPad2)
                {
                    newPC.reporter = new GpuReporter();
                    newPC.Report();
                }
                else if (choice.Key == ConsoleKey.D3 || choice.Key == ConsoleKey.NumPad3)
                {
                    newPC.reporter = new HardDriveReporter();
                    newPC.Report();
                }
                else
                    Environment.Exit(0);
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
