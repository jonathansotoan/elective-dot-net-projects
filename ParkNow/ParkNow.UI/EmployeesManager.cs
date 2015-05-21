using System.Linq;

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
            _employees = _userService.GetUsers().ToList();
            RefreshDatagrid();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (IsThereAWrongInput())
            {
                return;
            }

            if (_userService.GetById(int.Parse(txtNationalId.Text)) != null)
            {
                errorProvider.SetError(txtNationalId, "There is already an employee with this national identification");
                return;
            }

            var insertedEmployee = _userService.InsertUser(
            new User
            {
                NationalId = int.Parse(txtNationalId.Text),
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = Role.Employee
            });

            _employees.Add(insertedEmployee);
            RefreshDatagrid();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            errorProvider.Clear();
            var userToDelete = (User) dtgrEmployees.SelectedCells[0].OwningRow.DataBoundItem;

            if (userToDelete.Role == Role.Administrator)
            {
                errorProvider.SetError(btnDelete, "You cannot delete an administrator");
                return;
            }

            _userService.DeleteUser(userToDelete.NationalId);
            _employees.Remove(userToDelete);
            RefreshDatagrid();
        }

        private void RefreshDatagrid()
        {
            dtgrEmployees.DataSource = null;
            dtgrEmployees.DataSource = _employees;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (IsThereAWrongInput())
            {
                return;
            }

            User employeeToUpdate = _employees.Find(employee => employee.NationalId == int.Parse(txtNationalId.Text));
            employeeToUpdate.Username = txtUsername.Text;
            employeeToUpdate.Password = txtPassword.Text;
            _userService.UpdateUser(employeeToUpdate);
            RefreshDatagrid();
        }

        private bool IsThereAWrongInput()
        {
            errorProvider.Clear();

            bool errorRaised = false;
            int nationalIdForNewUser;

            if (!int.TryParse(txtNationalId.Text, out nationalIdForNewUser))
            {
                errorProvider.SetError(txtNationalId, "The provided national id is not a number");
                errorRaised = true;
            }

            if (txtNationalId.Text == string.Empty)
            {
                errorProvider.SetError(txtNationalId, "A national id must be provided");
                errorRaised = true;
            }

            if (txtUsername.Text == string.Empty)
            {
                errorProvider.SetError(txtUsername, "An username must be provided");
                errorRaised = true;
            }

            if (txtPassword.Text == string.Empty)
            {
                errorProvider.SetError(txtPassword, "A password must be provided");
                errorRaised = true;
            }

            if (txtPassword.Text != txtPasswordConfirmation.Text)
            {
                const string message = "The passwords are not equal";
                errorProvider.SetError(txtPassword, message);
                errorProvider.SetError(txtPasswordConfirmation, message);
                errorRaised = true;
            }

            if (_userService.GetUsers().Any(user => user.Username == txtUsername.Text))
            {
                errorProvider.SetError(btnAdd, "An user with the specified username already exists");
                errorRaised = true;
            }

            return errorRaised;
        }
    }
}
