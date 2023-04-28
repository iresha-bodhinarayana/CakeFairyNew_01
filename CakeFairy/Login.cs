using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CakeFairy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection conectionHome = new SqlConnection(@"Data Source=DESKTOP-IOTABSS;Initial Catalog=LOGIN;Integrated Security=True");
            if (sqlDataAdapter1 != null)
                {
                this.Hide();
                FormHome home = new FormHome();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please check your UserName and the Password","Warning Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.sqlDataAdapter1.Update(this.newLoginDataSet1);

        }

        private void loginBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.sqlDataAdapter1.Update(this.newLoginDataSet1);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.Login' table. You can move, or remove it, as needed.
            this.sqlDataAdapter1.Fill(this.newLoginDataSet1.Login);
            // TODO: This line of code loads data into the 'loginDataSet.Login' table. You can move, or remove it, as needed.
            this.sqlDataAdapter1.Fill(this.newLoginDataSet1.Login);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration formRegistration = new Registration();
            formRegistration.Show();
        }
    }
}
