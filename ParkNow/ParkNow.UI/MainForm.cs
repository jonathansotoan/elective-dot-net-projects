using ParkNow.Application;
using System.Linq;
using System.Windows.Forms;
using ParkNow.DataAccess;

namespace ParkNow.UI
{
    public partial class MainForm : Form
    {
        private Login _loginForm;
        private ParkingManager _parkingManager;
        private EmployeesManager _employeesManager;
        private Reports _reports;

        private readonly UserService _userService;

        public MainForm()
        {
            InitializeComponent();

            _loginForm = new Login(this);
            _loginForm.Show();
            _loginForm.Closed += (obj, eventArgs) => _loginForm = null;

            _userService = DependenciesContainer.UserService;
        }

        private void logInToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_loginForm != null)
            {
                return;
            }

            MdiChildren.ToList().ForEach(child => child.Close());

            _loginForm = new Login(this);
            _loginForm.Show();
            _loginForm.Closed += (obj, eventArgs) => _loginForm = null;
        }

        private void parkingManagerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_parkingManager != null)
            {
                return;
            }

            if (_userService.GetLoggedUser() == null)
            {
                MessageBox.Show("You are not logged in");
                return;
            }

            _parkingManager = new ParkingManager(this);
            _parkingManager.Show();
            _parkingManager.Closed += (obj, eventArgs) => _parkingManager = null;
        }

        private void employeesManagerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_employeesManager != null)
            {
                return;
            }

            if (_userService.GetLoggedUser() == null)
            {
                MessageBox.Show("You are not logged in");
                return;
            }

            if (_userService.GetLoggedUser().Role != Role.Administrator)
            {
                MessageBox.Show("You have to be an Administrator in order to open this form");
                return;
            }

            _employeesManager = new EmployeesManager(this);
            _employeesManager.Show();
            _employeesManager.Closed += (obj, eventArgs) => _employeesManager = null;
        }

        private void reportsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_reports != null)
            {
                return;
            }

            if (_userService.GetLoggedUser() == null)
            {
                MessageBox.Show("You are not logged in");
                return;
            }

            if (_userService.GetLoggedUser().Role != Role.Administrator)
            {
                MessageBox.Show("You have to be an Administrator in order to open this form");
                return;
            }

            _reports = new Reports(this);
            _reports.Show();
            _reports.Closed += (obj, eventArgs) => _reports = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_userService.GetLoggedUser() == null)
            {
                MessageBox.Show("You are already logged out");
                return;
            }

            _userService.LogOut();
            MdiChildren.ToList().ForEach(child => child.Close());
            MessageBox.Show("You have successfully logged out");
        }
    }
}
