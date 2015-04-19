using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveCiclicForms
{
    public partial class OpenerForm : Form
    {
        private byte id;

        public OpenerForm(string welcomeMessage, byte id)
        {
            if(welcomeMessage != "")
                MessageBox.Show(this, welcomeMessage);

            InitializeComponent();
            this.id = id;
            Text = "Form number " + id;
        }

        public OpenerForm(byte id):this("", id)
        {
        }

        private void openerFormButton_Click(object sender, EventArgs e)
        {
            new OpenerForm(welcomeMessage.Text, (byte) (id + 1)).ShowDialog();
        }
    }
}
