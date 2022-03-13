using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askhsh3
{
    public partial class SkiCenter : Form
    {
        SoundPlayer soundPlayer;

        private List<Image> LoadedImages { get; set; }
        private static bool playMusic = true;

        public SkiCenter()
        {
            InitializeComponent();
        }


        private void SkiCenter_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.loopingMusic);
            soundPlayer.PlayLooping();
            toolTip1.SetToolTip(pictureBox3, "Σταματήστε τη μουσική.");
            selectedImage.Image = Properties.Resources.xk_piliou_1024x768;
            ImageList images = new ImageList();
            images.ImageSize = new System.Drawing.Size(60, 40);
            
            images.Images.Add(Properties.Resources.xk_piliou_1024x768);
            images.Images.Add(Properties.Resources.xk_piliou1_1024x768);
            images.Images.Add(Properties.Resources.xk_piliou2_1024x768);
            images.Images.Add(Properties.Resources.xk_piliou3_1024x820);
            images.Images.Add(Properties.Resources.xk_piliou4_1024x616);
            images.Images.Add(Properties.Resources.PelionSki1);
            images.Images.Add(Properties.Resources.PelionSki2);
            Image img1 = Properties.Resources.xk_piliou_1024x768;
            Image img2 = Properties.Resources.xk_piliou1_1024x768;
            Image img3 = Properties.Resources.xk_piliou2_1024x768;
            Image img4 = Properties.Resources.xk_piliou3_1024x820;
            Image img5 = Properties.Resources.xk_piliou4_1024x616;
            Image img6 = Properties.Resources.PelionSki1;
            Image img7 = Properties.Resources.PelionSki2;
            LoadedImages = new List<Image>();
            LoadedImages.Add(img1);
            LoadedImages.Add(img2);
            LoadedImages.Add(img3);
            LoadedImages.Add(img4);
            LoadedImages.Add(img5);
            LoadedImages.Add(img6);
            LoadedImages.Add(img7);

            imageList.LargeImageList = images;
            imageList.Items.Add(new ListViewItem("Image 1", 0));
            imageList.Items.Add(new ListViewItem("Image 2", 1));
            imageList.Items.Add(new ListViewItem("Image 3", 2));
            imageList.Items.Add(new ListViewItem("Image 4", 3));
            imageList.Items.Add(new ListViewItem("Image 5", 4));
            imageList.Items.Add(new ListViewItem("Image 6", 5));
            imageList.Items.Add(new ListViewItem("Image 7", 6));

        }


        private void imageList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (imageList.SelectedIndices.Count > 0)
            {
                var selectedIndex = imageList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                selectedImage.Image = selectedImg;
                
            }
        }

        private void SkiCenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            soundPlayer.Stop();
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            //toolTip1.ShowAlways = true;
            
            if (playMusic)
            {
                toolTip1.SetToolTip(pictureBox3, "Ξεκινήστε τη μουσική.");
                pictureBox3.Image = Properties.Resources.startMusic;
                soundPlayer.Stop();
                playMusic = false;

            }
            else
            {
                toolTip1.SetToolTip(pictureBox3, "Σταματήστε τη μουσική.");
                pictureBox3.Image = Properties.Resources.stopMusic;
                soundPlayer.PlayLooping();
                playMusic = true;
            }

        }
    }
}
