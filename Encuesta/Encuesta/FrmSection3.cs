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
    public partial class FrmSection3 : Form
    {
        public FrmSection3(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Program.Back();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Program.Results.TalkToThePastMe = txtTalkToThePastMe.Text;
            Program.Forward(new FrmSection4(this.MdiParent));
        }
    }
}
