using ParkNow.Application;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
    /// <summary>
    /// The form where the administrator users can take reports of the parkings between two given dates
    /// </summary>
    /// <!-- Author: Jonathan Soto<theja29@hotmail.com>. For licensing, e-mail me -->
    public partial class Reports : Form
    {
        private readonly ParkingService _parkingService;

        public Reports(Form mdiParent)
        {
            InitializeComponent();
            _parkingService = new ParkingService();
            MdiParent = mdiParent;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            _parkingService.OpenReportBetween(dtStartingDate.Value, dtEndDate.Value);
        }
    }
}
