using System;
using System.IO;

namespace Minecraft_Automatic_ModDownloader
{
    public class functions
    {
        private static string logDir = Directory.GetCurrentDirectory() + @"\log.txt";

        public static bool CheckLink(string link)
        {
            if (link != "")
            {
                if (link.EndsWith("json"))
                {
                    return true;
                }
            }
            return false;
        }

        public static void LogMsg(string message)
        {
            DateTime msgTime = DateTime.Now;
            StreamWriter sw = new StreamWriter(logDir, true);
            sw.WriteLine($"[{msgTime}] {message}");
            sw.Close();
        }
    }
}
