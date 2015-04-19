using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewAndListBoxExample
{
    public partial class ImagePicker : Form
    {
        public ImagePicker()
        {
            InitializeComponent();

            for (int index = 0; index < ilstImages.Images.Count; ++index)
            {
                ltbImageNames.Items.Add(ilstImages.Images.Keys[index]);
            }
        }

        private void ltbImageNames_SelectedValueChanged(object sender, EventArgs e)
        {
            pbImageField.Image = ilstImages.Images[ltbImageNames.SelectedIndex];
        }
    }
}
