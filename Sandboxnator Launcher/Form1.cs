using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Sandboxnator_Launcher
{
    public partial class SandboxnatorLauncher : Form
    {
        string gameUrl = "https://github.com/TheGBO/Sandboxnator-Launcher/raw/main/Client.zip";
        string gamePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sandboxnator");
        public SandboxnatorLauncher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!Directory.Exists(gamePath))
            {
                Directory.CreateDirectory(gamePath);
            }
            else
            {
                try
                {
                    Directory.Delete(gamePath + "\\Client", true);
                }
                catch (Exception) { }
            }
            CheckForIllegalCrossThreadCalls = false;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            new Thread(DownloadGame).Start();    
        }

        private void RunGame()
        {
            statusLabel.Text = "Initializing Game...";
            Process.Start(gamePath + "\\Client\\Sandboxnator.exe");
            Application.Exit();
        }

        private void DownloadGame()
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                wc.DownloadFileAsync(new Uri(gameUrl), gamePath + "\\Client.zip");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            UnzipGame();
            RunGame();
        }

        private void UnzipGame()
        {
            ZipFile.ExtractToDirectory(gamePath + "\\Client.zip", gamePath);
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            statusLabel.Text = $"Checking for updates... {e.ProgressPercentage.ToString()}%";
        }

        private void newsMenu_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
