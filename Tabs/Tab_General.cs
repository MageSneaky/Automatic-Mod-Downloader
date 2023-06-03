using System;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader.Tabs
{
    public partial class Tab_General : UserControl
    {
        private string modsLink = "";
        IniFile configfile = new IniFile("config.ini");

        public Tab_General()
        {
            InitializeComponent();

            if (!File.Exists(Directory.GetCurrentDirectory() + @"\config.ini"))
            {
                configfile.Write("JsonDownloadPath", modsLink);
            }
            else
            {
                modsLink = configfile.Read("JsonDownloadPath");
            }
            jsonDownloadPathTextBox.Text = modsLink;
        }

        private void jsonDownloadPathTextBox_TextChanged(object sender, EventArgs e)
        {
            configfile.Write("JsonDownloadPath", jsonDownloadPathTextBox.Text);
        }

        private void jsonDownloadPathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            configfile.Write("JsonDownloadPath", jsonDownloadPathTextBox.Text);
        }
    }
}
