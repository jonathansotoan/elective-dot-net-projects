using System.Windows.Forms;

namespace ParkNow.UI
{
    public partial class MainForm : Form
    {
        private Login _loginForm;

        public MainForm()
        {
            InitializeComponent();
            _loginForm = new Login(this);
            _loginForm.Show();
            _loginForm.Closed += (obj, eventArgs) => _loginForm = null;
        }

        private void logInToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_loginForm == null)
            {
                _loginForm = new Login(this);
                _loginForm.Show();
            }
        }
    }
}
