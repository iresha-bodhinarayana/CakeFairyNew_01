using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CakeFairy
{
    public partial class FormProductReport : Form
    {
        public FormProductReport()
        {
            InitializeComponent();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            ReportDocument crystalreport = new ReportDocument();
            crystalreport.Load(@"C:\Users\Iresha Bodhinarayana\Desktop\COSC 32533\PRACTICALGUIDS\CakeFairyNew\CakeFairy\ProductReport.rpt");
            crystalReportViewer1.ReportSource = crystalreport;
            crystalReportViewer1.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
