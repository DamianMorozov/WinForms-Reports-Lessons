using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Create_Static_Report
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void buttonRunReport_Click(object sender, System.EventArgs e)
        {
            var report = new XtraReport1();
            report.ShowPreview();
        }
    }
}
