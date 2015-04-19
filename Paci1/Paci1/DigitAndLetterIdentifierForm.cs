using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paci1
{
    public partial class DigitAndLetterIdentifierForm : Form
    {
        public DigitAndLetterIdentifierForm()
        {
            InitializeComponent();
        }

        private void txtCharInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Back
                && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right
                && e.KeyCode != Keys.End && e.KeyCode != Keys.Home
                && e.KeyCode != Keys.Delete
                && e.KeyCode != Keys.Shift
                && e.KeyCode != Keys.Escape)
            {
                if (txtCharInput.Text.Length == 0)
                {
                    MessageBox.Show("No ingresaste nada");
                }
                else
                {
                    char charInput = txtCharInput.Text[txtCharInput.Text.Length - 1];

                    if (char.IsDigit(charInput))
                    {
                        MessageBox.Show("\"" + charInput + "\" es un número");
                    }
                    else if (char.IsLetter(charInput))
                    {
                        MessageBox.Show("\"" + charInput + "\" es una letra");
                    }
                    else
                    {
                        MessageBox.Show("\"" + charInput + "\" no es ni número, ni letra");
                    }
                }
            }
            /*char charInput = txtCharInput.Text[txtCharInput.;

            if (char.IsDigit(charInput))
            {
                MessageBox.Show("\"" + charInput + "\" es un número");
            }
            else if (char.IsLetter(charInput))
            {
                MessageBox.Show("\"" + charInput + "\" es una letra");
            }
            else
            {
                MessageBox.Show("No es ni número, ni letra");
            }*/
        }
    }
}
