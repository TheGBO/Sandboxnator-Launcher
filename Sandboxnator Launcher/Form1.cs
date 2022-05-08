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
        bool downloaded;
        string gamePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Sandboxnator";
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
            if(Directory.Exists(gamePath + "/Client"))
            {
                downloaded = true;
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (downloaded)
            {
                Process.Start(gamePath + "Client/Sandboxnator.exe");
            }
        }
    }
}
