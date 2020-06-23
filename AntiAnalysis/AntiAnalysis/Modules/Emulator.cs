using System;

namespace AntiAnalysis
{
    internal sealed class Emulator
    {
        /// <summary>
        /// Returns true if the file is running in emulator; otherwise returns false
        /// </summary>
        public static bool Check()
        {
            try
            {
                long ticks = DateTime.Now.Ticks;
                System.Threading.Thread.Sleep(10);
                if (DateTime.Now.Ticks - ticks < 10L)
                    return true;
            }
            catch { }
            return false;
        }
    }
}
