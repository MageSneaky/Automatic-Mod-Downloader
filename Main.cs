using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader
{
    public partial class Main : Form
    {
        private string modsLink = "";
        private List<Mod> modList = new List<Mod>();

        private string message = "";
        private DateTime msgTime;

        private string userName = Environment.UserName;

        private string logDir = Directory.GetCurrentDirectory() + @"\log.txt";
        private string minecraftDir = "C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft";

        public Main()
        {
            InitializeComponent();
            var configfile = new IniFile("config.ini");
            string configDir = Directory.GetCurrentDirectory() + @"\config.ini";

            if (!File.Exists("config.ini"))
            {
                configfile.Write("ModsJson", modsLink);
            }
            else
            {
                modsLink = configfile.Read("ModsJson");
            }

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\mods"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\mods");
            }

            if (modsLink == "")
            {
                DialogResult result;
                result = MessageBox.Show(
                    "No mods link found in config in\n" + configDir,
                    "No mods link found in config",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                message = "No mods link found in config in" + configDir;
                LogMsg();
            }
            else
            {
                if (!modsLink.EndsWith(".json"))
                {
                    DialogResult result;
                    result = MessageBox.Show(
                        "Invalid mods link found in config in\n" + configDir + "\nDoes not end with .json",
                        "Invalid mods link found in config",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    message = "Invalid mods link found in config in " + configDir + "\nDoes not end with .json";
                    LogMsg();
                }
            }

            if(!IsAdministrator())
            {
                DialogResult result;
                result = MessageBox.Show(
                    "Not running application as administrator can not download into minecraft folder installing into mods folder instead",
                    "Not running application as administrator",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                message = "Invalid mods link found in config in " + configDir + "\nDoes not end with .json";
                LogMsg();
            }

            if (!Directory.Exists(minecraftDir + @"\mods"))
            {
                DialogResult result;
                result = MessageBox.Show(
                    "No mods folder found at " + minecraftDir + "\tDownload forge here: https://files.minecraftforge.net/net/minecraftforge/forge/",
                    "No mods folder found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                message = "No mods folder found at C:/Users/" + userName + "/AppData/Roaming/.minecraft\tDownload forge here: https://files.minecraftforge.net/net/minecraftforge/forge/";
                LogMsg();
                Application.Exit();
                this.Close();
            }
            else
            {
                if (CheckLink(modsLink))
                {
                    GetMods(modsLink);
                }
            }
        }

        private void LogMsg()
        {
            msgTime = DateTime.Now;
            StreamWriter sw = new StreamWriter(logDir, true);
            sw.WriteLine($"[{msgTime}] {message}");
            sw.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Users\alleh\OneDrive\Dokument\!C#_Projects\Minecraft_Automatic_ModDownloader\Assets\Inter-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string downloadFolder = minecraftDir + @"\mods";
            if(!IsAdministrator())
            {
                downloadFolder = Directory.GetCurrentDirectory() + @"\mods";
            }
            if (CheckLink(modsLink))
            {
                using (WebClient wc = new WebClient())
                {
                    foreach (var mod in modList)
                    {
                        wc.DownloadFile(mod.Download.ToString(), downloadFolder);
                    }
                }
            }
        }

        private void GetMods(string modLink)
        {
            using (WebClient wc = new WebClient())
            {
                var webjson = wc.DownloadString(modLink.ToString());
                dynamic json = JsonConvert.DeserializeObject(webjson);
                modList.Clear();
                List<string> list = new List<string>();
                foreach (var mod in json)
                {
                    message = "Name: " + mod.name + " | Download: " + mod.download;
                    LogMsg();
                    Mod newMod = new Mod();
                    newMod.Name = mod.name;
                    newMod.Download = mod.download;
                    modList.Add(newMod);
                    list.Add(mod.name.ToString());
                }
                listBox1.DataSource = list;
            }
        }

        private bool CheckLink(string link)
        {
            if (link != "")
            {
                if (link.EndsWith(".json"))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

    class Mod
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string download;
        public string Download
        {
            get { return download; }
            set { download = value; }
        }
    }
}
