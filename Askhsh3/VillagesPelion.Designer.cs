
namespace Askhsh3
{
    partial class VillagesPelion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillagesPelion));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perioxhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ypsometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apostashApoVoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelionVillagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelionVillagesDBDataSet = new Askhsh3.PelionVillagesDBDataSet();
            this.pelionVillagesTableAdapter = new Askhsh3.PelionVillagesDBDataSetTableAdapters.PelionVillagesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelionVillagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelionVillagesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.onomaDataGridViewTextBoxColumn,
            this.perioxhDataGridViewTextBoxColumn,
            this.ypsometroDataGridViewTextBoxColumn,
            this.apostashApoVoloDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pelionVillagesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(712, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // onomaDataGridViewTextBoxColumn
            // 
            this.onomaDataGridViewTextBoxColumn.DataPropertyName = "Onoma";
            this.onomaDataGridViewTextBoxColumn.HeaderText = "Όνομα";
            this.onomaDataGridViewTextBoxColumn.Name = "onomaDataGridViewTextBoxColumn";
            this.onomaDataGridViewTextBoxColumn.ReadOnly = true;
            this.onomaDataGridViewTextBoxColumn.Width = 200;
            // 
            // perioxhDataGridViewTextBoxColumn
            // 
            this.perioxhDataGridViewTextBoxColumn.DataPropertyName = "Perioxh";
            this.perioxhDataGridViewTextBoxColumn.HeaderText = "Περιοχή";
            this.perioxhDataGridViewTextBoxColumn.Name = "perioxhDataGridViewTextBoxColumn";
            this.perioxhDataGridViewTextBoxColumn.ReadOnly = true;
            this.perioxhDataGridViewTextBoxColumn.Width = 200;
            // 
            // ypsometroDataGridViewTextBoxColumn
            // 
            this.ypsometroDataGridViewTextBoxColumn.DataPropertyName = "Ypsometro";
            this.ypsometroDataGridViewTextBoxColumn.HeaderText = "Υψόμετρο";
            this.ypsometroDataGridViewTextBoxColumn.Name = "ypsometroDataGridViewTextBoxColumn";
            this.ypsometroDataGridViewTextBoxColumn.ReadOnly = true;
            this.ypsometroDataGridViewTextBoxColumn.Width = 125;
            // 
            // apostashApoVoloDataGridViewTextBoxColumn
            // 
            this.apostashApoVoloDataGridViewTextBoxColumn.DataPropertyName = "ApostashApoVolo";
            this.apostashApoVoloDataGridViewTextBoxColumn.HeaderText = "Απόσταση από τον Βόλο";
            this.apostashApoVoloDataGridViewTextBoxColumn.Name = "apostashApoVoloDataGridViewTextBoxColumn";
            this.apostashApoVoloDataGridViewTextBoxColumn.ReadOnly = true;
            this.apostashApoVoloDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo path";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.ReadOnly = true;
            this.photoDataGridViewTextBoxColumn.Visible = false;
            // 
            // pelionVillagesBindingSource
            // 
            this.pelionVillagesBindingSource.DataMember = "PelionVillages";
            this.pelionVillagesBindingSource.DataSource = this.pelionVillagesDBDataSet;
            // 
            // pelionVillagesDBDataSet
            // 
            this.pelionVillagesDBDataSet.DataSetName = "PelionVillagesDBDataSet";
            this.pelionVillagesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelionVillagesTableAdapter
            // 
            this.pelionVillagesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pelionVillagesBindingSource, "Photo", true));
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pelionVillagesBindingSource, "Photo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pictureBox1.Location = new System.Drawing.Point(31, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Χωριά Πηλίου";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pelionVillagesBindingSource, "Onoma", true));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Χωριό:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VillagesPelion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VillagesPelion";
            this.Text = "VillagesPelion";
            this.Load += new System.EventHandler(this.VillagesPelion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelionVillagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelionVillagesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PelionVillagesDBDataSet pelionVillagesDBDataSet;
        private System.Windows.Forms.BindingSource pelionVillagesBindingSource;
        private PelionVillagesDBDataSetTableAdapters.PelionVillagesTableAdapter pelionVillagesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perioxhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ypsometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apostashApoVoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
    }
}