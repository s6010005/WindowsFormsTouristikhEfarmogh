using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhsh3
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer engine = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new VillagesPelion().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Εξερευνήστε το Πήλιο
            string ttsGR = label1.Text.Split('/')[0];

            //Discover Pelion
            string tts = label1.Text.Split('/')[1];

            //Βρίσκει ποιες γλώσσες tss είναι εγκατεστημένες και αν βρει την ελληνική τοτε λέει το ελληνικό κείμενο
            foreach (var voice in engine.GetInstalledVoices())
            {
                if (voice.VoiceInfo.Name.Equals("Microsoft Stefanos"))
                {
                    engine.SelectVoice("Microsoft Stefanos");
                    tts = ttsGR;
                    break;
                }
            }
            engine.Speak(tts);

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SkiCenter().Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sights().Show();
           
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Hotels().Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Train().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Food().Show();
        }


    }
}
