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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnDash_Click(object sender, EventArgs e)
        {
            panelDash.BringToFront();
        }

        private void btnIncident_Click(object sender, EventArgs e)
        {
            panelIncident.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            panelUser.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDash.BringToFront();
            Login login = new Login();
            string name = login.GetUsername();
            lblUser.Text = name;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }
    }
}
