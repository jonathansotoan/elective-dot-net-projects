namespace ListViewAndListBoxExample
{
    partial class ImagePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePicker));
            this.pbImageField = new System.Windows.Forms.PictureBox();
            this.ilstImages = new System.Windows.Forms.ImageList(this.components);
            this.ltbImageNames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageField)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageField
            // 
            this.pbImageField.Location = new System.Drawing.Point(21, 12);
            this.pbImageField.Name = "pbImageField";
            this.pbImageField.Size = new System.Drawing.Size(100, 100);
            this.pbImageField.TabIndex = 0;
            this.pbImageField.TabStop = false;
            // 
            // ilstImages
            // 
            this.ilstImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstImages.ImageStream")));
            this.ilstImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstImages.Images.SetKeyName(0, "Atlético Nacional.png");
            this.ilstImages.Images.SetKeyName(1, "fire.jpg");
            this.ilstImages.Images.SetKeyName(2, "sea.jpg");
            // 
            // ltbImageNames
            // 
            this.ltbImageNames.FormattingEnabled = true;
            this.ltbImageNames.Location = new System.Drawing.Point(12, 154);
            this.ltbImageNames.Name = "ltbImageNames";
            this.ltbImageNames.Size = new System.Drawing.Size(120, 95);
            this.ltbImageNames.TabIndex = 1;
            this.ltbImageNames.SelectedValueChanged += new System.EventHandler(this.ltbImageNames_SelectedValueChanged);
            // 
            // ImagePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 261);
            this.Controls.Add(this.ltbImageNames);
            this.Controls.Add(this.pbImageField);
            this.Name = "ImagePicker";
            this.Text = "ImagePicker";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageField;
        private System.Windows.Forms.ImageList ilstImages;
        private System.Windows.Forms.ListBox ltbImageNames;
    }
}