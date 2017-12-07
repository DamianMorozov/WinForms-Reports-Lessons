using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Provide_Navigation_to_Report
{
    public partial class Form04 : Form
    {
        public Form04()
        {
            InitializeComponent();
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            var report = new XtraReport1();
            report.ShowPreview();
        }
    }
}
