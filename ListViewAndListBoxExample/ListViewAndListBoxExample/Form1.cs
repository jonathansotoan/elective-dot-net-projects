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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvColors.SelectedItems.Count > 0)
            {
                switch(lstvColors.SelectedItems[0].Text)
                {
                    case "Azul":
                        txtTargetForChangingColor.BackColor = Color.Blue;
                        break;

                    case "Verde":
                        txtTargetForChangingColor.BackColor = Color.Green;
                        break;

                    case "Rojo":
                        txtTargetForChangingColor.BackColor = Color.Red;
                        break;
                }
            }
        }

        private void ltbColors_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ltbColors.SelectedItems.Count > 0)
            {
                if (ltbColors.SelectedItems[0].ToString() == "Azul")
                {
                    txtTargetForChangingColor.ForeColor = Color.Blue;
                }
                else if (ltbColors.SelectedItems[0].ToString() == "Verde")
                {
                    txtTargetForChangingColor.ForeColor = Color.Green;
                }
                else
                {
                    txtTargetForChangingColor.ForeColor = Color.Red;
                }
            }
        }
    }
}
