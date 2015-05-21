namespace ParkNow.UI
{
    using DataAccess;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Application;

    public partial class EmployeesManager : Form
    {
        private readonly List<User> _employees;
        private readonly UserService _userService;

        public EmployeesManager(Form mdiParent)
        {
            InitializeComponent();
            MdiParent = mdiParent;
            _employees = new List<User>();
            _userService = new UserService();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var insertedEmployee = _userService.InsertUser(
            new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = Role.Employee
            });

            _employees.Add(insertedEmployee);
            dtgrEmployees.DataSource = null;
            dtgrEmployees.DataSource = _employees;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var userToDelete = (User) dtgrEmployees.SelectedRows[0].DataBoundItem;
            _userService.DeleteUser(userToDelete.NationalId);
            _employees.Remove(userToDelete);
        }
    }
}
