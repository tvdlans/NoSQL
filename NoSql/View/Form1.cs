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

namespace View
{
    public partial class Form1 : Form
    {
        private List<ModIncident> incidentsList = new List<ModIncident>();
        private static bool selected;

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
            getAllIncidents();
        }

        private void getAllIncidents()
        {
            //First clear the listview
            listIncidents.Items.Clear();
            ConIncident incident = new ConIncident();
            //Get all the incidents
            List<ModIncident> incidents = incident.getIncidents();
            int id = 1;
            foreach (ModIncident item in incidents)
            {
                ModIncident mod = new ModIncident { ID = id,Subject = item.Subject, Name = item.Name, Date = item.Date, Deadline= item.Deadline, Status= item.Status, TypeOfIncident= item.TypeOfIncident, Description = item.Description };
                ListViewItem list = new ListViewItem(new [] { id.ToString(), item.Subject, item.Name,item.Date.Date.ToString("d"), item.Deadline.Date.ToString("d"), item.Status.ToString(),item.TypeOfIncident,item.Description });
                //Fill the Masterlist
                incidentsList.Add(mod);
                //Fill the listview
                listIncidents.Items.Add(list);
                id++;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            panelUser.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDash.BringToFront();
            ConSession session = new ConSession();
            string name = session.GetUsername();
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
            //check if all the fields are filled
            bool check = Incident.checkFields(cmbDateTime.Text, txtSubject.Text, cmbType.Text, cmbUser.Text, cmbPriority.Text, cmbDeadline.Text, txtDescription.Text);
            if (check == false)
            {
                lblFalse.Text = "Please fill in al the information";
            }
            else
            {
                //insert incident into database
                Incident.insertIncident(cmbDateTime.Text, txtSubject.Text, cmbType.Text, cmbUser.Text, cmbPriority.Text, cmbDeadline.Text, txtDescription.Text);
                pnlCreateIncident.Hide();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            searchData(txtFilter.Text);
        }
        
        private void searchData(string text)
        {
            //clear the listview
            listIncidents.Items.Clear();
            foreach (ModIncident row in incidentsList)
            {
                //check if the list containts the searched text
                if (row.Description.ToString().ToLower().Contains(text.ToLower()) || row.ID.ToString().ToLower().Contains(text.ToLower()) || row.Name.ToLower().Contains(text.ToLower()) || row.Subject.ToLower().Contains(text.ToLower()) || row.Status.ToString().ToLower().Contains(text.ToLower()) || row.TypeOfIncident.ToLower().Contains(text.ToLower()) || row.Date.ToString().ToLower().Contains(text.ToLower()) || row.Deadline.ToString().ToLower().Contains(text.ToLower()))
                {
                    //make new listview
                    ListViewItem list = new ListViewItem(new[] { row.ID.ToString(), row.Subject, row.Name, row.Date.Date.ToString("d"), row.Deadline.Date.ToString("d"), row.Status.ToString(), row.TypeOfIncident,row.Description });
                    listIncidents.Items.Add(list);
                }
            }
        }

        private void listIncidents_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (e.IsSelected)
            {
                MessageBox.Show("Subject: " + listIncidents.SelectedItems[0].SubItems[1].Text + "\n" +
                    "User: " + listIncidents.SelectedItems[0].SubItems[2].Text + "\n" +
                    "Date: " + listIncidents.SelectedItems[0].SubItems[3].Text + "\n" +
                    "EndDate: " + listIncidents.SelectedItems[0].SubItems[4].Text + "\n" +
                    "Status: " + listIncidents.SelectedItems[0].SubItems[5].Text+"%" + "\n" +
                    "Type of Incident: " + listIncidents.SelectedItems[0].SubItems[6].Text + "\n" +
                    "Description: " + listIncidents.SelectedItems[0].SubItems[7].Text);
                selected = true;
            }
            else
            {
                selected = false;
            }
        }
    }
}
