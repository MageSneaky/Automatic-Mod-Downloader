using System;
using System.IO;

namespace Minecraft_Automatic_ModDownloader
{
    public class functions
    {
        public static string configDir = Directory.GetCurrentDirectory() + @"\config.ini";
        public static IniFile configfile = new IniFile("config.ini");
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

        public static void CheckConfigFile()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\config.ini"))
            {
                functions.configfile.Write("JsonDownloadPath", "");
                functions.configfile.Write("DeleteModsOnDownload", false.ToString());
            }
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
