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
        public string email;
        public int code;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(); 
            email = txtEmail.Text;
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

                if (true)
                {

                }

                this.Hide();

                //Employee employee = new Employee();
                //employee.Show();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Email and Password combination is not valid");
            }
        }
           
        private void LogIn_Load(object sender, EventArgs e)
        {
            pnlforgotpswd.Hide();
            pnlCode.Hide();
            pnlNewPswd.Hide();

            Login login = new Login();
            login.connect();
            if (Properties.Settings.Default.Name != string.Empty)
            {
                chkremember.Checked = true;
                txtEmail.Text = Properties.Settings.Default.Name;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void lnkforgotpswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlforgotpswd.Show();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            email = txtEmailForgotPswd.Text;

            Login login = new Login();
            var user = login.CheckUserExists(email);

            if (user == null)
            {
                MessageBox.Show("This is not a known email address");
            }
            else
            {
                ConSendMail conSendMail = new ConSendMail();
                Random random = new Random();
                code = random.Next(1000, 10000);

                string name = user.GetElement("FirstName").Value.ToString();
                bool sent = conSendMail.SendMail(email, name, code);
                if (sent)
                {
                    MessageBox.Show("an email has been sent");
                    pnlforgotpswd.Hide();
                    pnlCode.Show();
                }
                else
                {
                    MessageBox.Show("There was an error sending a email");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userCode = int.Parse(txtCode.Text);
            if (userCode == code)
            {
                pnlCode.Hide();
                pnlNewPswd.Show();
            }
            else
            {
                MessageBox.Show("This code is wrong");
                txtCode.Text = "";
            }
        }

        private void btnSubmitNewPswd_Click(object sender, EventArgs e)
        {
            string password = txtNewPswd.Text;
            string rptPassword = txtRepeatPswd.Text;

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rptPassword))
            {
                MessageBox.Show("Fields can't be empty");
            }
            else if (password != rptPassword)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                Login login = new Login();
                login.ConUpdatePassword(email, password);
                pnlforgotpswd.Hide();
                pnlCode.Hide();
                pnlNewPswd.Hide();
                MessageBox.Show("Password updated");
            }
        }
    }
}
