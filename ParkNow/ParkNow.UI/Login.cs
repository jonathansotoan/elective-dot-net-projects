using ParkNow.Application;
using ParkNow.DataAccess;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
    /// <summary>
    /// The start point of the application for the user. Here, the user must log in to access the core features
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
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
                Role loggedUseRole = _userService.LogIn(txtUsername.Text, txtPassword.Text);

                if (loggedUseRole == Role.Employee)
                {
                    new ParkingManager(_parent).Show();
                    Close();
                }
                else if (loggedUseRole == Role.Administrator)
                {
                    new EmployeesManager(_parent).Show();
                    Close();
                }
            }
            catch (Exception exception)
            {
                errorProvider.SetError(btnLogin, exception.Message);
            }
        }
    }
}
