using ParkNow.Application;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
    public partial class Login : Form
    {
        private readonly UserService _userService;
        private readonly Form _parent;

        public Login(Form mdiParent)
        {
            _userService = DependenciesContainer.UserService;
            InitializeComponent();
            MdiParent = _parent = mdiParent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                _userService.LogIn(txtUsername.Text, txtPassword.Text);
                new ParkingManager(_parent).Show();
                Close();
            }
            catch (Exception exception)
            {
                errorProvider.SetError(btnLogin, exception.Message);
            }
        }
    }
}
