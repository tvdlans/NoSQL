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
                if (chkremember.Checked == true)
                {
                    Properties.Settings.Default.Name = txtEmail.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                if (chkremember.Checked == false)
                {
                    Properties.Settings.Default.Name = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Email and Password combination is not valid");
            }
        }

        private void chkremember_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Name != string.Empty)
            {
                chkremember.Checked = true;
                txtEmail.Text = Properties.Settings.Default.Name;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
    }
}
