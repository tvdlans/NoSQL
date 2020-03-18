﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        public void CloseAllPanelsExcept(Panel panel)
        {
            panelDash.Hide();
            panelIncident.Hide();
            panelUser.Hide();
            panel.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ConDashboard conDashboard = new ConDashboard();
            UnresolvedIncidents(conDashboard);
            IncidentsPastDeadline(conDashboard);
            TypeOfIncidents(conDashboard);
            MostCommonWords(conDashboard);
            IncidentsSolvedByYou(conDashboard);
            CloseAllPanelsExcept(panelDash);
        }

        private void btnIncident_Click(object sender, EventArgs e)
        {
            panelIncident.BringToFront();
            CloseAllPanelsExcept(panelIncident);
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
            CloseAllPanelsExcept(panelUser);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDash.BringToFront();
            ConSession session = new ConSession();
            string name = session.GetUsername();
            lblUser.Text = name;

            ConDashboard conDashboard = new ConDashboard();
            UnresolvedIncidents(conDashboard);
            IncidentsPastDeadline(conDashboard);
            TypeOfIncidents(conDashboard);
            MostCommonWords(conDashboard);
            IncidentsSolvedByYou(conDashboard);
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

        private void UnresolvedIncidents(ConDashboard conDashboard)
        {
            ChartUnresInc.Series["s1"].Points.Clear();
            int[] incidentDataFinished = conDashboard.CalculateUsersFinishedIncidents();
            double solvedIncidentPercentage = (double)incidentDataFinished[1] / (double)incidentDataFinished[0];
            ChartUnresInc.Series["s1"].Points.AddXY("", solvedIncidentPercentage);
            ChartUnresInc.Series["s1"].Points.AddXY("", 1 - solvedIncidentPercentage);
            ChartUnresInc.Series["s1"].Points[0].Color = ColorTranslator.FromHtml("#b7f842");
            ChartUnresInc.Series["s1"].Points[1].Color = ColorTranslator.FromHtml("#e2e2e2");
            ChartUnresInc.Series["s1"].IsVisibleInLegend = false;
            lblUnresInc.Text = incidentDataFinished[1] + "/" + incidentDataFinished[0];
        }

        private void IncidentsPastDeadline(ConDashboard conDashboard)
        {
            int[] incidentDataExpired = conDashboard.CalculateIncidentsPastDeadline();

            double incidentExpiredPercentage = 0;
            if (incidentDataExpired[0] != 0)
                incidentExpiredPercentage = (double)incidentDataExpired[1] / (double)incidentDataExpired[0];

            ChartUnresIncExp.Series["s1"].Points.Clear();
            ChartUnresIncExp.Series["s1"].Points.AddXY("", incidentExpiredPercentage);
            ChartUnresIncExp.Series["s1"].Points.AddXY("", 1 - incidentExpiredPercentage);
            ChartUnresIncExp.Series["s1"].Points[0].Color = ColorTranslator.FromHtml("#7cf461");
            ChartUnresIncExp.Series["s1"].Points[1].Color = ColorTranslator.FromHtml("#e2e2e2");
            ChartUnresIncExp.Series["s1"].IsVisibleInLegend = false;
            lblUnresIncExp.Text = incidentDataExpired[1] + "/" + incidentDataExpired[0];
        }

        private void TypeOfIncidents(ConDashboard conDashboard)
        {
            int[] incidentTypeOfInc = conDashboard.CalculateTypeOfIncidents();
            ChartTypeOfInc.Series["s1"].Points.Clear();
            ChartTypeOfInc.Series["s1"].Points.AddXY("Software: " + incidentTypeOfInc[0], incidentTypeOfInc[0]);
            ChartTypeOfInc.Series["s1"].Points.AddXY("Hardware: " + incidentTypeOfInc[1], incidentTypeOfInc[1]);
            ChartTypeOfInc.Series["s1"].Points.AddXY("Service: " + incidentTypeOfInc[2], incidentTypeOfInc[2]);
            ChartTypeOfInc.Series["s1"].Points[0].Color = ColorTranslator.FromHtml("#b7f842");
            ChartTypeOfInc.Series["s1"].Points[1].Color = ColorTranslator.FromHtml("#8efe6b");
            ChartTypeOfInc.Series["s1"].Points[2].Color = ColorTranslator.FromHtml("#28da6a");
            ChartTypeOfInc.Series["s1"].IsVisibleInLegend = false;
        }

        private void MostCommonWords(ConDashboard conDashboard)
        {
            Dictionary<string, int> wordList = conDashboard.CalculateMostOccWords();

            lblWordList.Text = "";

            int loopCounter = 0;
            foreach (KeyValuePair<string, int> word in wordList.OrderByDescending(key => key.Value))
            {
                if (loopCounter == 10)
                    break;

                lblWordList.Text += word.Key + " = " + word.Value + "\n";
                loopCounter++;
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
        private void IncidentsSolvedByYou(ConDashboard conDashboard)
        {
            int[] incidentsByYou = conDashboard.CalculateYourIncidents();

            double incidentsByYouPercentage = 0;
            if (incidentsByYou[0] != 0)
                incidentsByYouPercentage = (double)incidentsByYou[1] / (double)incidentsByYou[0];
            ChartIncSolvedByYou.Series["s1"].Points.Clear();
            ChartIncSolvedByYou.Series["s1"].Points.AddXY("", incidentsByYouPercentage);
            ChartIncSolvedByYou.Series["s1"].Points.AddXY("", 1 - incidentsByYouPercentage);
            ChartIncSolvedByYou.Series["s1"].Points[0].Color = ColorTranslator.FromHtml("#28da6a");
            ChartIncSolvedByYou.Series["s1"].Points[1].Color = ColorTranslator.FromHtml("#e2e2e2");
            ChartIncSolvedByYou.Series["s1"].IsVisibleInLegend = false;
            lblIncSolvedByYou.Text = incidentsByYou[1] + "/" + incidentsByYou[0];

        }
    }
}
