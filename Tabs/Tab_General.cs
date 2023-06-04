using System;
using System.Windows.Forms;

namespace Minecraft_Automatic_ModDownloader.Tabs
{
    public partial class Tab_General : UserControl
    {
        private string modsLink = "";
        private bool deletemods = false;
        private bool logtofile = true;

        public Tab_General()
        {
            InitializeComponent();

            functions.CheckConfigFile();
            modsLink = functions.configfile.Read("JsonDownloadPath");
            try { deletemods = bool.Parse(functions.configfile.Read("DeleteModsOnDownload")); } catch (Exception) { deletemods = false; }
            try { logtofile = bool.Parse(functions.configfile.Read("LogToFile")); } catch (Exception) { logtofile = true;  }
            jsonDownloadPathTextBox.Text = modsLink;
            deleteModsCheckBox.Checked = deletemods;
            logToFileCheckBox.Checked = logtofile;
            functions.configfile.Write("JsonDownloadPath", jsonDownloadPathTextBox.Text);
            functions.configfile.Write("DeleteModsOnDownload", deleteModsCheckBox.Checked.ToString());
            functions.configfile.Write("LogToFile", logToFileCheckBox.Checked.ToString());
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

        private void logToFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            functions.configfile.Write("LogToFile", logToFileCheckBox.Checked.ToString());
        }
    }
}
