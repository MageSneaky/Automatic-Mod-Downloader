using System;
using System.IO;

namespace Minecraft_Automatic_ModDownloader
{
    public class functions
    {
        #region Variables
        public static string configDir = Directory.GetCurrentDirectory() + @"\config.ini";
        public static IniFile configfile = new IniFile("config.ini");
        private static string logDir = Directory.GetCurrentDirectory() + @"\log.txt";
        #endregion

        #region Methods
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
                functions.configfile.Write("LogToFile", true.ToString());
            }
            if (!functions.configfile.KeyExists("JsonDownloadPath"))
            {
                functions.configfile.Write("JsonDownloadPath", "");
            }
            if (!functions.configfile.KeyExists("DeleteModsOnDownload"))
            {
                functions.configfile.Write("DeleteModsOnDownload", false.ToString());
            }
            if (!functions.configfile.KeyExists("LogToFile"))
            {
                functions.configfile.Write("LogToFile", true.ToString());
            }
        }

        public static void LogMsg(string message)
        {
            CheckConfigFile();
            bool logtofile = bool.TryParse(functions.configfile.Read("LogToFile"), out bool outlogbool);
            if (!outlogbool)
            {
                logtofile = true;
            }
            if (logtofile)
            {
                DateTime msgTime = DateTime.Now;
                StreamWriter sw = new StreamWriter(logDir, true);
                sw.WriteLine($"[{msgTime}] {message}");
                sw.Close();
            }
        }
        #endregion
    }
}
