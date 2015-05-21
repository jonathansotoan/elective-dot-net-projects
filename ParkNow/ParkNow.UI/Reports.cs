using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParkNow.Application;
using ParkNow.DataAccess;

namespace ParkNow.UI
{
    public partial class Reports : Form
    {
        private readonly ParkingService _parkingService;

        public Reports()
        {
            InitializeComponent();
            _parkingService = new ParkingService();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            _parkingService.OpenReportBetween(dtStartingDate.Value, dtEndDate.Value);
        }
    }
}
