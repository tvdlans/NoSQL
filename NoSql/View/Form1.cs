using System;
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
        
        List<ModUser> userItems = new List<ModUser>();
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
            CloseAllPanelsExcept(panelIncident);
            pnlCreateIncident.Hide();
            pnlUpgrade.Hide();
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
                ListViewItem list = new ListViewItem(new [] { id.ToString(), item.Subject, item.Name,item.Date.Date.ToString("d"), item.Deadline.Date.ToString("d"), item.Status.ToString(),item.TypeOfIncident,item.Description,item.Id.ToString() });
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
            pnlCreateUser.Hide();
            GetAllUsers();
        }

        private void GetAllUsers()
        {
            listUsers.Items.Clear();
            ConUser ConUserObject = new ConUser();
            List<ModUser> users = ConUserObject.GetAllUsers();
            int id = 1;
            foreach (ModUser user in users)
            {
                ListViewItem lvItem = new ListViewItem(new [] { id.ToString(), user.Email, user.FirstName, user.LastName, user.NrOfTickets.ToString() });
                ModUser modUser = new ModUser { Id = id, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, NrOfTickets = user.NrOfTickets };
                userItems.Add(modUser);
                listUsers.Items.Add(lvItem);
                id++;
            }
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
            double solvedIncidentPercentage = 0;
            if (incidentDataFinished[0] != 0)
            solvedIncidentPercentage = (double)incidentDataFinished[1] / (double)incidentDataFinished[0];
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
            searchIncidentData(txtFilter.Text);
        }
        
        private void searchIncidentData(string text)
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
                pnlUpgrade.Show();
                lblUpDate.Text = listIncidents.SelectedItems[0].SubItems[3].Text;
                lblUpDeadline.Text = listIncidents.SelectedItems[0].SubItems[4].Text;
                lblUpSubject.Text = listIncidents.SelectedItems[0].SubItems[1].Text;
                lblUpUser.Text = listIncidents.SelectedItems[0].SubItems[2].Text;
                lblUpType.Text = listIncidents.SelectedItems[0].SubItems[6].Text;
                lblUpDescription.Text = listIncidents.SelectedItems[0].SubItems[7].Text;
                UpDownStatus.Value = decimal.Parse(listIncidents.SelectedItems[0].SubItems[5].Text);
                lblUpID.Text = listIncidents.SelectedItems[0].SubItems[8].Text;
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

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            pnlCreateUser.Show();
        }

        private void buttonCancelCreateUser_Click(object sender, EventArgs e)
        {
            pnlCreateUser.Hide();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            ConUser userObject = new ConUser();
            //check if all the fields are filled
            bool check = userObject.checkFields(textBoxUserFirstName.Text, textBoxUserLastName.Text, comboBoxTypeOfUser.Text, textBoxUserEmail.Text, textBoxUserPhoneNumber.Text, comboBoxUserLocation.Text);
            if (check == false)
            {
                lblCreateUserError.Text = "Please fill in all the information";
            }
            else
            {
                //insert incident into database
                string createUserFeedback = userObject.InsertUser(textBoxUserFirstName.Text, textBoxUserLastName.Text, comboBoxTypeOfUser.Text, textBoxUserEmail.Text, textBoxUserPhoneNumber.Text, comboBoxUserLocation.Text, checkBoxUserSendPassword.Checked);
                if (createUserFeedback == "Account created succesfully!")
                {
                    lblCreateUserError.Text = "";
                    pnlCreateUser.Hide();
                    lblCreateUserSucces.Text = createUserFeedback;
                }
                else
                {
                    lblCreateUserError.Text = createUserFeedback;
                }
                

            }
        }

        private void txtUserFilter_TextChanged(object sender, EventArgs e)
        {
            SearchUserData(txtUserFilter.Text);
        }

        private void SearchUserData(string text)
        {
            //clear the listview
            listUsers.Items.Clear();
            foreach (ModUser user in userItems)
            {
                //check if the list containts the searched text
                if (user.Id.ToString().ToLower().Contains(text.ToLower()) || user.FirstName.ToLower().Contains(text.ToLower()) || user.LastName.ToLower().Contains(text.ToLower()) || user.Email.ToString().ToLower().Contains(text.ToLower()) || user.NrOfTickets.ToString().ToLower().Contains(text.ToLower()))
                {
                    //make new listview for items that contain the search
                    ListViewItem list = new ListViewItem(new[] { user.Id.ToString(), user.Email, user.FirstName, user.LastName, user.NrOfTickets.ToString() });
                    listUsers.Items.Add(list);
                }
            }
        }

        private void btnUpgradeCancel_Click(object sender, EventArgs e)
        {
            pnlUpgrade.Hide();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            ConIncident Incident = new ConIncident();
            //check if the comment is filled
            if(string.IsNullOrWhiteSpace(txtUpComment.Text))
            {
                lblNoComment.Text = "Please enter a comment";
            }
            else
            {
                //upgrade the status
                Incident.UpgradeStatus(int.Parse(UpDownStatus.Value.ToString()),lblUpID.Text);
                //add comment into database
                Incident.SetComment("Comments",txtUpComment.Text, lblUpID.Text);
                pnlUpgrade.Hide();
                getAllIncidents();
              }
        }
    }
}
