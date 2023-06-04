using System;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader.Tabs
{
    public partial class Tab_General : UserControl
    {
        private string modsLink = "";
        private bool deletemods = false;

        public Tab_General()
        {
            InitializeComponent();

            functions.CheckConfigFile();
            modsLink = functions.configfile.Read("JsonDownloadPath");
            deletemods = bool.TryParse(functions.configfile.Read("DeleteModsOnDownload"), out bool outbool);
            if (!outbool)
            {
                deletemods = false;
            }
            jsonDownloadPathTextBox.Text = modsLink;
        }

        private void jsonDownloadPathTextBox_TextChanged(object sender, EventArgs e)
        {
            functions.configfile.Write("JsonDownloadPath", jsonDownloadPathTextBox.Text);
        }

        private void jsonDownloadPathTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            functions.configfile.Write("JsonDownloadPath", jsonDownloadPathTextBox.Text);
        }

        private void deleteModsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            functions.configfile.Write("DeleteModsOnDownload", deleteModsCheckBox.Checked.ToString());
        }
    }
}
