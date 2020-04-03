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
using Model;
using MongoDB.Bson;

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
            ConUser conUser = new ConUser();
            email = txtEmail.Text;
            string password = txtPassword.Text;
            string hashedpswd = conUser.HashPassword(password);
            BsonDocument user =  login.CheckUser(email, password);

            if (user != null)
            {
                if (user.GetElement("Password").Value.ToString() == hashedpswd)
                {
                    // makes the remember me function work
                    if (chkremember.Checked == true)
                    {
                        Properties.Settings.Default.Name = txtEmail.Text;
                        Properties.Settings.Default.Password = password;
                        Properties.Settings.Default.Save();
                    }
                    if (chkremember.Checked == false)
                    {
                        Properties.Settings.Default.Name = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Save();
                    }

                    // add a "session" of the user that is logged in, that way you can access his or her information in the main program
                    ConSession session = new ConSession();
                    session.AddSession(user.GetElement("FirstName").Value.ToString(), user.GetElement("Email").Value.ToString(), ObjectId.Parse(user.GetElement("_id").Value.ToString()));

                    this.Hide();

                    // checks if the user is a service desk employee or a employee
                    if (int.Parse(user.GetElement("Role").Value.ToString()) == 0)
                    {
                        Employee employee = new Employee();
                        employee.Show();
                    }
                    else
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Email and Password combination is not valid");
                }
            }
            else
            {
                MessageBox.Show("This user doesn't exist");
            }
        }
           
        private void LogIn_Load(object sender, EventArgs e)
        {
            pnlforgotpswd.Hide();
            pnlCode.Hide();
            pnlNewPswd.Hide();

            Login login = new Login();
            login.connect();

            // fill the email and password textbox if the user checked the remember me box
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
                // create a random code that will be send to the user
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

        // check if the code is correct
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

            //check if the new password is valid
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
                //update password
                Login login = new Login();
                ConUser conUser = new ConUser();
                string hashedpswd = conUser.HashPassword(password);
                login.ConUpdatePassword(email, hashedpswd);
                pnlforgotpswd.Hide();
                pnlCode.Hide();
                pnlNewPswd.Hide();
                MessageBox.Show("Password updated");
            }
        }
    }
}
