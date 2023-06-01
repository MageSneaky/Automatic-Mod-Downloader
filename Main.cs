using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader
{
    public partial class Main : Form
    {
        private string modsLink = "";
        private List<Mod> modList = new List<Mod>();

        private string message = "";
        private DateTime msgTime;

        private CheckBox topbarCheckbox;

        private string userName = Environment.UserName;

        private string logDir = Directory.GetCurrentDirectory() + @"\log.txt";
        private string minecraftDir = "C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft";

        public Main()
        {
            InitializeComponent();
            var configfile = new IniFile("config.ini");
            string configDir = Directory.GetCurrentDirectory() + @"\config.ini";

            if (!File.Exists(Directory.GetCurrentDirectory() + @"\config.ini"))
            {
                configfile.Write("ModsJson", modsLink);
            }
            else
            {
                modsLink = configfile.Read("ModsJson");
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
            if (CheckLink(modsLink))
            {
                foreach (Mod mod in modList)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += (s, ed) =>
                        {
                            mod.Progress.Value = ed.ProgressPercentage;
                        };
                        if (downloadSelected.Checked)
                        {
                            if (mod.CheckBox.Checked)
                            {

                                Uri uri = new Uri(mod.Download);
                                string filename = Path.GetFileName(uri.LocalPath);
                                wc.DownloadFileAsync(uri, downloadFolder + @"\" + filename);
                                message = "Downloaded: " + downloadFolder + @"\" + filename;
                                LogMsg();
                            }
                        }
                        else
                        {
                            Uri uri = new Uri(mod.Download);
                            string filename = Path.GetFileName(uri.LocalPath);
                            wc.DownloadFileAsync(uri, downloadFolder + @"\" + filename);
                            message = "Downloaded: " + downloadFolder + @"\" + filename;
                            LogMsg();
                        }
                    }
                }
            }
        }

        private void SelectAll(object sender, System.EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            CheckState state = checkbox.CheckState;
            bool isChecked = checkbox.Checked;
            if (isChecked)
            {
                foreach (Mod mod in modList)
                {
                    mod.CheckBox.Checked = true;
                }
            }
            else
            {
                foreach (Mod mod in modList)
                {
                    mod.CheckBox.Checked = false;
                }
            }
        }

        private void GetMods(string modLink)
        {
            using (WebClient wc = new WebClient())
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"C:\Users\alleh\OneDrive\Dokument\!C#_Projects\Minecraft_Automatic_ModDownloader\Assets\Inter-Regular.ttf");
                var webjson = wc.DownloadString(modLink.ToString());
                dynamic json = JsonConvert.DeserializeObject(webjson);
                modList.Clear();
                topbarCheckbox = new CheckBox();
                topbarCheckbox.Name = "topbar checkBox";
                topbarCheckbox.Checked = true;
                topbarCheckbox.Width = 15;
                topbarCheckbox.CheckedChanged += SelectAll;
                Label newText1 = new Label();
                newText1.Name = "topbar name";
                newText1.Text = "Name";
                newText1.AutoSize = true;
                newText1.Width = flowLayoutPanel1.Width - newText1.Width - 200;
                newText1.AutoSize = false;
                newText1.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                newText1.ForeColor = Color.White;
                Label newText2 = new Label();
                newText2.Name = "topbar progress";
                newText2.Text = "Progress";
                newText2.AutoSize = true;
                newText2.Width = 200;
                newText2.AutoSize = false;
                newText2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                newText2.ForeColor = Color.White;
                FlowLayoutPanel newGroupTop = new FlowLayoutPanel();
                newGroupTop.Name = "topbar";
                newGroupTop.AutoSize = true;
                newGroupTop.BackColor = Color.Transparent;
                newGroupTop.WrapContents = false;
                newGroupTop.Controls.Add(topbarCheckbox);
                newGroupTop.Controls.Add(newText1);
                newGroupTop.Controls.Add(newText2);
                flowLayoutPanel1.Controls.Add(newGroupTop);
                foreach (var mod in json)
                {
                    CheckBox newCheckBox = new CheckBox();
                    newCheckBox.Name = "checkBox " + mod.name;
                    newCheckBox.Checked = true;
                    newCheckBox.Width = 15;
                    Label newText = new Label();
                    newText.Name = "label " + mod.name;
                    newText.Text = mod.name;
                    newText.AutoSize = true;
                    newText.Width = flowLayoutPanel1.Width - newText.Width - 200;
                    newText.AutoSize = false;
                    newText.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    newText.ForeColor = Color.White;
                    ProgressBar newProgressBar = new ProgressBar();
                    newProgressBar.Name = "progressBar " + mod.name;
                    newProgressBar.Width = 200;
                    newProgressBar.Height = 20;
                    newProgressBar.Maximum = 100;
                    newProgressBar.Step = 1;
                    newProgressBar.Style = ProgressBarStyle.Continuous;
                    FlowLayoutPanel newGroup = new FlowLayoutPanel();
                    newGroup.Name = "group " + mod.name;
                    newGroup.AutoSize = true;
                    newGroup.BackColor = Color.Transparent;
                    newGroup.WrapContents = false;
                    newGroup.Controls.Add(newCheckBox);
                    newGroup.Controls.Add(newText);
                    newGroup.Controls.Add(newProgressBar);
                    flowLayoutPanel1.Controls.Add(newGroup);
                    Mod newMod = new Mod();
                    newMod.Name = mod.name;
                    newMod.Download = mod.download;
                    newMod.CheckBox = newCheckBox;
                    newMod.Progress = newProgressBar;
                    modList.Add(newMod);
                }
            }
        }

        private bool CheckLink(string link)
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
        private CheckBox checkBox;
        public CheckBox CheckBox
        {
            get { return checkBox; }
            set { checkBox = value; }
        }
        private ProgressBar progress;
        public ProgressBar Progress
        {
            get { return progress; }
            set { progress = value; }
        }

    }
}
