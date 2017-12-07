using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Use_Parameters_to_Filter_Data_in_a_Report
{
    public partial class Form03 : Form
    {
        public Form03()
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
