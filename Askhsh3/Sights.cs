using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhsh3
{
    public partial class Sights : Form
    {
        public Sights()
        {
            InitializeComponent();
        }


        private void Sights_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = @"media\wdwsd1.mp4";

            //Place video file in the directory of the application
            //string mp4Path1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "mp4File.mp4");
            string mp4Path = Path.Combine(Application.StartupPath, "mp4File1.mp4");

            //check if it hasn't been written to disk yet
            if (!File.Exists(mp4Path))
            {
                //write it to disk
                File.WriteAllBytes(mp4Path, Properties.Resources.Pelion2);
            }

    //play using mp4Path
            axWindowsMediaPlayer1.URL =mp4Path;
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
