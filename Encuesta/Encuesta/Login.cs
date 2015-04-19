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
    public partial class Login : Form
    {
        const string USERNAME = "Albert";
        const string PASSWORD = "mypass";

        public Login(Form mdiParent)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == USERNAME && txtPassword.Text == PASSWORD)
            {
                Program.Forward(new FrmBasicInfo(this.MdiParent));
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contraseña son incorrectos",
                    "Mensaje de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
