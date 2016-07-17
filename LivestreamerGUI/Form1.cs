using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LivestreamerGUI
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           if (!File.Exists(strFavorites))
                {
                    File.Create(strFavorites).Close();
                }

            string[] readText = File.ReadAllLines(strFavorites);
            foreach (string fileText in readText)
            {
                lstbxFavorites.Items.Add(fileText);
            }
        }

        string strCmdText;
        string strConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\livestreamer\livestreamerrc";
        string strFavorites = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\LivestreamerFavorites.txt";
        string strStreamUrl;
        
        private void btnStartStrem_Click(object sender, EventArgs e)
        {
            if (txtQuality.Text == "")
            {
                txtQuality.Text = "best";
            }
            
            if (txtStreamName.Text.Contains("crunchyroll") || txtStreamName.Text.Contains("youtube"))
            {
                strCmdText = String.Format("/K livestreamer {0} {1}", txtStreamName.Text, txtQuality.Text);
            }
            else
            {
                strStreamUrl = txtStreamName.Text.Replace("http://", "");
                strStreamUrl = txtStreamName.Text.Replace("https://", "");
                strStreamUrl = strStreamUrl.Replace("www.", "");
                strStreamUrl = strStreamUrl.Replace("twitch.tv/", "");
                txtStreamName.Text = strStreamUrl;
                
                strCmdText = "/K livestreamer http://twitch.tv/" + strStreamUrl + " " + txtQuality.Text;
            }
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
        
        private void btnConfig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", strConfigFile);
        }

        private void btnSaveStream_Click(object sender, EventArgs e)
        {
            if (!IsChannelInFile(strFavorites, txtStreamName.Text))
            {
                strStreamUrl = txtStreamName.Text.Replace("http://", "");
                strStreamUrl = strStreamUrl.Replace("www.", "");
                strStreamUrl = strStreamUrl.Replace("twitch.tv/", "");
                txtStreamName.Text = strStreamUrl;

                TextWriter tw = new StreamWriter(strFavorites, true);
                tw.WriteLine(txtStreamName.Text);
                tw.Close();

                lstbxFavorites.Items.Add(txtStreamName.Text);
            }
        }

        private void lstbxFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStreamName.Text = lstbxFavorites.SelectedItem.ToString();
        }

        private static bool IsChannelInFile(string fileName, string searchString)
        {
            return File.ReadAllLines(fileName).Contains(searchString);
        }

        private void txtStreamName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStartStrem_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        private void txtQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStartStrem_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        private void lstbxFavorites_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStartStrem_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitch.tv/" + txtStreamName.Text + "/chat?popout=");
        }

        private void btnTwitchChannels_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitch.tv/directory");
        }

    }
}
