using System;

namespace AntiAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VirtualBox==" + VirtualBox.Check());
            Console.WriteLine("SandBox=="    + SandBox.Check());
            Console.WriteLine("Debugger=="   + Debugger.Check());
            Console.WriteLine("Emulator=="   + Emulator.Check());
            Console.WriteLine("Hosting=="    + Hosting.Check());
            Console.WriteLine("Process=="    + Processes.Check());

            Console.ReadLine();
        }
    }
}
