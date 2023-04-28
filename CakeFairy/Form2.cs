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
    public partial class FormOrderManagement : Form
    {
        public FormOrderManagement()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Dispose();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Boolean validToSubmit = validate();
        }

        private Boolean validate()
        {
            if ((txtOrderid.TextLength == 0) || (txtProductid.TextLength == 0) || (txtCustomerid.TextLength == 0) || (txtCustomername.TextLength == 0) || (txtCustomerphone.TextLength == 0) || (cmbSize.SelectedIndex == (-1) )) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
