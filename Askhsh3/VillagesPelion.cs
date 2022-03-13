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

namespace Askhsh3
{
    public partial class VillagesPelion : Form
    {
        public VillagesPelion()
        {
            InitializeComponent();
            
        }

        private void VillagesPelion_Load(object sender, EventArgs e)
        {

            var resourcsPath = Path.Combine(Application.StartupPath, "Resources");


            this.pelionVillagesTableAdapter.Fill(this.pelionVillagesDBDataSet.PelionVillages);
            openFileDialog1.InitialDirectory = resourcsPath;
            //openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
