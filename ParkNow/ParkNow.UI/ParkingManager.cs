using System.Collections.Generic;
using ParkNow.Application;
using ParkNow.DataAccess;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
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

        private void btnSaveParking_Click(object sender, System.EventArgs e)
        {
            errorProvider.Clear();

            if (txtVehiclePlate.Text.Length != 6)
            {
                errorProvider.SetError(txtVehiclePlate, "The plate must have a length of 6");
                return;
            }

            var newParking = new Parking
            {
                InDate = DateTime.Now,
                Vehicle = new Vehicle {Plate = txtVehiclePlate.Text}
            };

            _parkingService.InsertParking(newParking);
            _sessionParkings.Add(newParking);
            dtgrLastParkings.DataSource = _sessionParkings;
        }

        private void AddSessionParkings
    }
}
