using ParkNow.Application;
using System;
using System.Windows.Forms;

namespace ParkNow.UI
{
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
