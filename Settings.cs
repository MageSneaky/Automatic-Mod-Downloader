using Minecraft_Automatic_ModDownloader.Tabs;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader
{
    public partial class Settings : Form
    {
        #region Variables
        private string modsLink = "";

        private string message = "";
        private string userName = Environment.UserName;

        private string minecraftDir = "C:/Users/" + Environment.UserName + "/AppData/Roaming/.minecraft";
        #endregion

        #region Constructor
        public Settings()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void AddTab(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        #endregion

        #region Control Events
        private void Settings_Load(object sender, EventArgs e)
        {
            Tab_General generalTab = new Tab_General();
            AddTab(generalTab);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("fonts/Inter-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, FontStyle.Regular);
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void closeSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseForm()
        {
            functions.CheckConfigFile();
            modsLink = functions.configfile.Read("JsonDownloadPath");
            if (modsLink == "")
            {
                DialogResult result;
                result = MessageBox.Show(
                    "No json path found in config at\n" + functions.configDir,
                    "No json path found in config",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                message = "No json path found in config at" + functions.configDir;
                functions.LogMsg(message);
            }
            else
            {
                if (!modsLink.EndsWith(".json"))
                {
                    DialogResult result;
                    result = MessageBox.Show(
                        "Invalid json path found in config at\n" + functions.configDir + "\nDoes not end with .json",
                        "Invalid json path found at config",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    message = "Invalid json path found in config at " + functions.configDir + "\nDoes not end with .json";
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

            var main = Application.OpenForms.OfType<Main>().First();
            main.Settings = null;
            main.GetMods(modsLink);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            closeSettingsButton.BackColor = Color.Red;
        }

        private void closeSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            closeSettingsButton.BackColor = Color.Transparent;
        }
        private void generalButton_Click(object sender, EventArgs e)
        {
            Tab_General generalTab = new Tab_General();
            AddTab(generalTab);
        }
        #endregion
    }
}
