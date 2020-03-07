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
            login.CheckUser(email, password);


            //this.Hide();
            //Form1 form1 = new Form1();
            //form1.Show();
        }
    }
}
