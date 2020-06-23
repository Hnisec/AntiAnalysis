using System.Management;

namespace AntiAnalysis
{
    internal sealed class VirtualBox
    {
        /// <summary>
        /// Returns true if the file is running in VirtualBox or VmWare; otherwise returns false
        /// </summary>
        public static bool Check()
        {
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                try
                {
                    using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
                        foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                            if ((managementBaseObject["Manufacturer"].ToString().ToLower() == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || managementBaseObject["Manufacturer"].ToString().ToLower().Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
                                return true;

                }
                catch { return true; }
            }
            foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
                if (managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VMware") && managementBaseObject2.GetPropertyValue("Name").ToString().Contains("VBox"))
                    return true;
            return false;
        }

    }
}
