using System;
using System.Runtime.InteropServices;

namespace AntiAnalysis
{
    internal sealed class Debugger
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

        /// <summary>
        /// Returns true if the file is running in debugger; otherwise returns false
        /// </summary>
        public static bool Check()
        {
            bool isDebuggerPresent = false;
            try
            {
                CheckRemoteDebuggerPresent(System.Diagnostics.Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
                return isDebuggerPresent;
            }
            catch
            {
                return isDebuggerPresent;
            }
        }

    }
}
