using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeFairy
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderManagement formOrderManagement = new FormOrderManagement();
            formOrderManagement.ShowDialog();
            this.Dispose();

        }

        private void orderManagementToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderManagement formOrderManagement = new FormOrderManagement();
            formOrderManagement.ShowDialog();
            this.Dispose();

        }

        private void productManagementToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductManagement formProductManagement = new FormProductManagement();
            formProductManagement.ShowDialog();
            this.Dispose();

        }

        private void productReportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductReport formProductReport = new FormProductReport();
            formProductReport.ShowDialog();
            this.Dispose();
        }

        private void exitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
