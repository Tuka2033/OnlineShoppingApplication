using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Membership;
namespace WarehouseApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void OnSignIn(object sender, EventArgs e)
        {
            //MessageBox.Show("Button is Clicked....");

            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status = false;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User , Please try again");

            }

        }

    }
}
