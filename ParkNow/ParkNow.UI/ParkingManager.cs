﻿using ParkNow.Application;
using ParkNow.DataAccess;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
    public partial class ParkingManager : Form
    {
        private readonly ParkingService _parkingService;

        public ParkingManager(Form mdiParent)
        {
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

            _parkingService.InsertParking(new Parking {
                InDate = DateTime.Now,
                Vehicle = new Vehicle { Plate = txtVehiclePlate.Text }
            });
        }
    }
}
