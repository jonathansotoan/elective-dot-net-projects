using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class Form1 : Form
    {
        private IceCream currentIceCream;

        public Form1()
        {
            InitializeComponent();
            currentIceCream = new IceCream();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            this.ShowTotal();
        }

        private void cmbFlavor_Leave(object sender, EventArgs e)
        {
            this.ShowTotal();
        }

        private void cmbFlavor_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowTotal();
        }

        private void ShowTotal()
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(cmbFlavor.Text))
            {
                return;
            }

            currentIceCream.Name = cmbFlavor.Text;
            txtTotal.Text = (currentIceCream.Price * int.Parse(txtQuantity.Text)) + "";
        }
    }
}
