using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader
{
    public partial class Main : Form
    {
        private string modsLink = "";
        private bool deletemods = false;

        private List<Mod> modList = new List<Mod>();

        private string message = "";

        private Settings settings;
        public Settings Settings { get { return settings; } set { settings = value; } }
        private AboutWindow aboutWindow;
        public AboutWindow AboutWindow { get { return aboutWindow; } set { aboutWindow = value; } }

        private CheckBox topbarCheckbox;

        private string userName = Environment.UserName;

        private string minecraftDir = "C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft";
        string configDir = Directory.GetCurrentDirectory() + @"\config.ini";

        public Main()
        {
            InitializeComponent();

            functions.CheckConfigFile();
            modsLink = functions.configfile.Read("JsonDownloadPath");
            deletemods = bool.TryParse(functions.configfile.Read("DeleteModsOnDownload"), out bool outbool);
            if (!outbool)
            {
                deletemods = false;
            }
            if (modsLink == "")
            {
                DialogResult result;
                result = MessageBox.Show(
                    "No json path found in config at\n" + configDir,
                    "No json path found in config",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                message = "No json path found in config at" + configDir;
                functions.LogMsg(message);
            }
            else
            {
                if (!modsLink.EndsWith(".json"))
                {
                    DialogResult result;
                    result = MessageBox.Show(
                        "Invalid json path found in config at\n" + configDir + "\nDoes not end with .json",
                        "Invalid json path found at config",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    message = "Invalid json path found in config at " + configDir + "\nDoes not end with .json";
                    functions.LogMsg(message);
                }
            }

            if (!Directory.Exists(minecraftDir + @"\mods"))
            {
                DialogResult result;
                result = MessageBox.Show(
                    "No mods folder found at " + minecraftDir + "\nDownload forge here: https://files.minecraftforge.net/net/minecraftforge/forge/",
                    "No mods folder found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                message = "No mods folder found at C:/Users/" + userName + "/AppData/Roaming/.minecraft\tDownload forge here: https://files.minecraftforge.net/net/minecraftforge/forge/";
                functions.LogMsg(message);
                Application.Exit();
                this.Close();
            }
            else
            {
                if (functions.CheckLink(modsLink))
                {
                    GetMods(modsLink);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("fonts/Inter-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, FontStyle.Regular);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string downloadFolder = minecraftDir + @"\mods";
            modsLink = functions.configfile.Read("JsonDownloadPath");
            deletemods = bool.TryParse(functions.configfile.Read("DeleteModsOnDownload"), out bool outbool);
            if (functions.CheckLink(modsLink))
            {
                if (deletemods)
                {
                    DeleteMods();
                }
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
                                functions.LogMsg(message);
                            }
                        }
                        else
                        {
                            Uri uri = new Uri(mod.Download);
                            string filename = Path.GetFileName(uri.LocalPath);
                            wc.DownloadFileAsync(uri, downloadFolder + @"\" + filename);
                            message = "Downloaded: " + downloadFolder + @"\" + filename;
                            functions.LogMsg(message);
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

        public void GetMods(string modLink)
        {
            modsContainer.Controls.Clear();
            modList.Clear();
            Uri uriResult;
            dynamic json = new JObject();
            bool b = false;
            bool isURL = Uri.TryCreate(modLink, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (isURL && functions.CheckLink(modLink))
            {
                if (functions.CheckLink(modLink))
                {
                    using (WebClient wc = new WebClient())
                    {
                        var webjson = wc.DownloadString(modLink.ToString());
                        json = JsonConvert.DeserializeObject(webjson);
                    }
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show(
                        "Couldn't retrive json from " + modLink,
                        "Couldn't retrive json from " + modLink,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    message = "Couldn't retrive json from " + modLink;
                    functions.LogMsg(message);
                }
            }
            else if (File.Exists(modLink) && functions.CheckLink(modLink))
            {
                json = JsonConvert.DeserializeObject(File.ReadAllText(modLink));
                b = true;
            }
            if (b)
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile("fonts/Inter-Regular.ttf");

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
                newText1.Width = modsContainer.Width - newText1.Width - 200;
                newText1.AutoSize = false;
                newText1.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                newText1.ForeColor = Color.White;
                Label newText2 = new Label();
                newText2.Name = "topbar progress";
                newText2.Text = "Progress";
                newText2.AutoSize = true;
                newText2.Width = 200;
                newText2.AutoSize = false;
                newText2.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                newText2.ForeColor = Color.White;
                FlowLayoutPanel newGroupTop = new FlowLayoutPanel();
                newGroupTop.Name = "topbar";
                newGroupTop.AutoSize = true;
                newGroupTop.BackColor = Color.Transparent;
                newGroupTop.WrapContents = false;
                newGroupTop.Controls.Add(topbarCheckbox);
                newGroupTop.Controls.Add(newText1);
                newGroupTop.Controls.Add(newText2);
                modsContainer.Controls.Add(newGroupTop);
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
                    newText.Width = modsContainer.Width - newText.Width - 200;
                    newText.AutoSize = false;
                    newText.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
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
                    modsContainer.Controls.Add(newGroup);
                    Mod newMod = new Mod();
                    newMod.Name = mod.name;
                    newMod.Download = mod.download;
                    newMod.CheckBox = newCheckBox;
                    newMod.Progress = newProgressBar;
                    modList.Add(newMod);
                }
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (Settings == null)
            {
                Settings = new Settings();
            }
            Settings.Show();
            Settings.Focus();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (AboutWindow == null)
            {
                AboutWindow = new AboutWindow();
            }
            AboutWindow.Show();
            AboutWindow.Focus();
        }

        private void DeleteMods()
        {
            DirectoryInfo modFolder = new DirectoryInfo(minecraftDir + @"\mods");
            foreach (FileInfo file in modFolder.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in modFolder.GetDirectories())
            {
                dir.Delete(true);
            }
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
