using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuesta
{
    public partial class FrmGeneral : Form
    {
        public FrmGeneral()
        {
            InitializeComponent();
        }

        private void informaciónBásicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login(this).Show();
        }
    }
}
