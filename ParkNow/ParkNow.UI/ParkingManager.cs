using System.Windows.Forms;

namespace ParkNow.UI
{
    public partial class ParkingManager : Form
    {
        public ParkingManager(Form mdiParent)
        {
            InitializeComponent();
            MdiParent = mdiParent;
        }
    }
}
