using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(); 
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Boolean passwordIsTrue =  login.CheckUser(email, password);

            if (passwordIsTrue)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Email and Password combination is not valid");
            }
        }
    }
}
