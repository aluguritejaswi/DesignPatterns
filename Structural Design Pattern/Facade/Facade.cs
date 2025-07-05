using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CPU
    {
        public void Freeze() => Console.WriteLine("CPU freezing...");
        public void Execute() => Console.WriteLine("CPU executing...");
    }

    public class Memory
    {
        public void Load() => Console.WriteLine("Memory loading...");
    }

    public class HardDrive
    {
        public void Read() => Console.WriteLine("Hard Drive reading...");
    }

    // Facade class
    public class ComputerFacade
    {
        private CPU _cpu;
        private Memory _memory;
        private HardDrive _hardDrive;

        public ComputerFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDrive = new HardDrive();
        }

        public void Start()
        {
            _cpu.Freeze();
            _memory.Load();
            _hardDrive.Read();
            _cpu.Execute();
        }
    }

}
