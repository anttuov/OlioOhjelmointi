using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5T4
{
    class D5T4
    {
        static void Main(string[] args)
        {
            PC pc = new PC();
            GPU gpu = new GPU();
            gpu.Name = "Titan X";
            gpu.Memory = "12";
            List<GPU> gpus = new List<GPU>();
            gpus.Add(gpu);
            gpus.Add(gpu);
            RAM ram = new RAM();
            RAM ram2 = new RAM();
            List<RAM> rams = new List<RAM>();
            ram.Memory = 8;
            ram2.Memory = 4;
            rams.Add(ram);
            rams.Add(ram);
            rams.Add(ram2);
            rams.Add(ram2);
            CPU cpu = new CPU();
            cpu.Cores = 4;
            cpu.Speed = 3.5;
            pc.CPU = cpu;
            pc.GPU = gpus;
            pc.RAM = rams;
            pc.PrintData();

        }
    }
}
