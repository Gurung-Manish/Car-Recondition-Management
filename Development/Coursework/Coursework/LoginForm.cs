using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "admin" && passwordTB.Text == "admin")
            {
                userNameTB.Text = "";
                passwordTB.Text = "";
                new AdminForm().Show();
            }

            else
            {
                MessageBox.Show("The Username or password is incorrect.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTB.Text="";
                passwordTB.Text = "";
            }
        }

        private void customerFeedbackLbl_Click(object sender, EventArgs e)
        {
            CustomerFeedbackForm obj = new CustomerFeedbackForm();
            obj.ShowDialog();
        }
    }
}
