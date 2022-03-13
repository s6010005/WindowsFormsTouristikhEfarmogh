
namespace Askhsh3
{
    partial class SkiCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkiCenter));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectedImage = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Χιονοδρομικό Κέντρο Αγριόλευκες";
            // 
            // imageList
            // 
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(32, 325);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(131, 380);
            this.imageList.TabIndex = 3;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.imageList_ItemSelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(686, 236);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // selectedImage
            // 
            this.selectedImage.Location = new System.Drawing.Point(169, 325);
            this.selectedImage.Name = "selectedImage";
            this.selectedImage.Size = new System.Drawing.Size(549, 380);
            this.selectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectedImage.TabIndex = 1;
            this.selectedImage.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Askhsh3.Properties.Resources.stopMusic;
            this.pictureBox3.Location = new System.Drawing.Point(698, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // SkiCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 733);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.selectedImage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkiCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Χιονοδρομικό";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkiCenter_FormClosed);
            this.Load += new System.EventHandler(this.SkiCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox selectedImage;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}