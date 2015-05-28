using System.Linq;
using ParkNow.Application;
using ParkNow.DataAccess;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ParkNow.UI
{
    /// <summary>
    /// The main view. Here, the employees can insert plates and they are going to be operated
    /// (according whether the vehicle is inside or outside the parking)
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public partial class ParkingManager : Form
    {
        private readonly ParkingService _parkingService;
        private readonly List<Parking> _sessionParkings;

        public ParkingManager(Form mdiParent)
        {
            _parkingService = new ParkingService();
            _sessionParkings = new List<Parking>();

            InitializeComponent();
            MdiParent = mdiParent;
        }

        private void btnSaveParking_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (txtVehiclePlate.Text.Length != 6)
            {
                errorProvider.SetError(txtVehiclePlate, "The plate must have a length of 6");
                return;
            }

            if (!(Regex.IsMatch(txtVehiclePlate.Text, "[A-Z]{3}[0-9]{3}") ||
                  Regex.IsMatch(txtVehiclePlate.Text, "[A-Z]{3}[0-9]{2}[A-D]")))
            {
                errorProvider.SetError(txtVehiclePlate, "The plate must have either 3 letters and 3 numbers without spaces or 3 letters, 2 numbers and a letter between A and D");
                return;
            }

            var newParking = _parkingService.OperateParking(txtVehiclePlate.Text);

            if (!_sessionParkings.Any(
                    parking => parking.VehiclePlate == newParking.VehiclePlate && parking.OutDate != null))
            {
                _sessionParkings.Add(newParking);
            }

            dtgrLastParkings.DataSource = null;
            dtgrLastParkings.DataSource = _sessionParkings;
        }
    }
}