using ParkNow.Application;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
    public partial class Login : Form
    {
        private readonly UserService _userService;

        public Login(Form mdiParent)
        {
            _userService = new UserService();
            InitializeComponent();
            MdiParent = mdiParent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (_userService.DoesUserExist(txtUsername.Text, txtPassword.Text))
            {
                Close();
                new ParkingManager(MdiParent).Show();
            }
            else
            {
                errorProvider.SetError(btnLogin, "Your username/password pair is not right");
            }
        }
    }
}
