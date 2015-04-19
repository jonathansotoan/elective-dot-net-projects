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
    public partial class FrmSection1 : Form
    {
        public FrmSection1(Form mdiParent)
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
            Program.Forward(new FrmSection2(this.MdiParent));
        }

        private void schedule_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Program.Results.ScheduleForStudying = new AnsweredQuestion
                {
                    Question = lblSchedule.Text,
                    Answer = ((RadioButton)sender).Text
                };
            }
        }

        private void classmatesQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Program.Results.QuantityOfClassmates = new AnsweredQuestion
                {
                    Question = lblClassmatesQuantity.Text,
                    Answer = ((RadioButton)sender).Text
                };
            }
        }

        private void favoriteColor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Program.Results.FavoriteColor = new AnsweredQuestion
                {
                    Question = lblFavoriteColor.Text,
                    Answer = ((RadioButton)sender).Text
                };
            }
        }

        private void favoriteFood_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Program.Results.FavoriteFood = new AnsweredQuestion
                {
                    Question = lblFavoriteFood.Text,
                    Answer = ((RadioButton)sender).Text
                };
            }
        }
    }
}
