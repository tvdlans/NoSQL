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
            pnlCreateIncident.Hide();
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

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            pnlCreateIncident.Show();
            getIncidentUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCreateIncident.Hide();
        }

        private void getIncidentUser()
        {
            //clear comboBox before filling it
            cmbUser.Items.Clear();
            ConIncident Incident = new ConIncident();
            //get the users
            List<String> users = Incident.getUsers();
            foreach (string item in users)
            {
                //fill the comboBox
                cmbUser.Items.Add(item);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConIncident Incident = new ConIncident();
            bool check = Incident.checkFields(cmbDateTime.Text, txtSubject.Text, cmbType.Text, cmbUser.Text, cmbPriority.Text, cmbDeadline.Text, txtDescription.Text);
            if (check == false)
            {
                lblFalse.Text = "Please fill in al the information";
            }
            else
            {
                Incident.insertIncident(cmbDateTime.Text, txtSubject.Text, cmbType.Text, cmbUser.Text, cmbPriority.Text, cmbDeadline.Text, txtDescription.Text);
            }
        }
    }
}
