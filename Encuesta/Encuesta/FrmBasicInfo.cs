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
    public partial class FrmBasicInfo : Form
    {
        public FrmBasicInfo(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            new FrmSection1(this.MdiParent).Show(this);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Program.Results.Names = txtNames.Text;
            Program.Results.LastNames = txtLastNames.Text;
            Program.Results.BirthDate = dtBirthDate.Value;
            Program.Results.City = cmbBirthCity.SelectedText;
            Program.Results.Age = Convert.ToInt32(txtAge.Text);
            Program.Results.City = cmbBirthCity.Text;
            Program.Results.Undergraduates =
                new string[checkedListBoxUndergraduates.CheckedItems.Count];
            foreach (object undergraduate in checkedListBoxUndergraduates.CheckedItems)
            {
                Program.Results.Undergraduates
                    [checkedListBoxUndergraduates.CheckedItems.IndexOf(undergraduate)] = undergraduate.ToString();
            }
            Program.Forward(new FrmSection1(this.MdiParent));
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Program.Back();
        }

        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtBirthDate.Value.Year) + "";
        }
    }
}
