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
    public partial class Employee : Form
    {
        ConEmployeeDashboard conEmployeeDashboard = new ConEmployeeDashboard();
        ConSession conSession = new ConSession();


        public Employee()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        //a method for closing all open panels expect the given panel
        public void CloseAllPanelsExcept(Panel panel)
        {
            PanelDashboard.Hide();
            PnlSupport.Hide();
            panel.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            CloseAllPanelsExcept(PanelDashboard);
            Dashboard();
            lblUser.Text = conSession.GetUsername();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            CloseAllPanelsExcept(PanelDashboard);
            Dashboard();
        }
        //if the support button is pressed, give a small list of opening hours
        private void btnSupport_Click(object sender, EventArgs e)
        {
            CloseAllPanelsExcept(PnlSupport);
            lblSupportTime.Text = "Opening Hours: \n" +
                "Mondag:    5:00 - 23:00 \n" +
                "Tuesday:   5:00 - 23:00 \n" +
                "Wednesday: 5:00 - 23:00 \n" +
                "Thursday:  5:00 - 23:00 \n" +
                "Friday:    5:00 - 23:00 \n" +
                "Saturday:  5:00 - 23:00 \n" +
                "Sunday:    5:00 - 23:00 \n";
        }

        //method for loading the dashboard
        private void Dashboard()
        {
            ConIncident conIncident = new ConIncident();

            //get the list from the controller layer with incidents
            List<ModIncident> incidents = conIncident.getIncidents();

            //clear comboBox before filling it
            DashDgInc.Rows.Clear();
            //give it a pretty font
            DashDgInc.Font = new Font("Lato Light", 12, FontStyle.Regular);
            DashDgInc.RowTemplate.Height = 30;

            //get the Id of the logged in user
            ObjectId userId = conSession.GetId();

            //foreach incident, check if the incident was reported by the currently logged in employee
            foreach (ModIncident item in incidents)
            {
                if (item.EmployeeID == userId) 
                {
                    DashDgInc.Rows.Add(item.Id.ToString(), item.Subject, item.TypeOfIncident, item.Date.ToString("yyyy/MM/dd"), item.Deadline.ToString("yyyy/MM/dd"), item.Status + "%");

                } 
            }

            //foreach row, look if the status is 100% --> make it Green
            //else if the incident has expired, make it red
            //else if the incident deadline is in 3 days, make it orange
            //else, leave it blank
            foreach (DataGridViewRow row in DashDgInc.Rows)
            {
                if (row.Cells[5].Value.ToString() == "100%")
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5eff7e");
                else if (Convert.ToDateTime(row.Cells[4].Value) < DateTime.Now)
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e34040");
                else if ((Convert.ToDateTime(row.Cells[4].Value) - DateTime.Now).Days < 3)
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#eba834");
                else
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
        }

        //if one of the buttons is pressed open a popup menu
        private void DashDgInc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //check which button is pressed
            if (e.ColumnIndex == DashDgInc.Columns["ID"].Index && e.RowIndex >= 0)
            {
                pnlDashPopup.Visible = true;

                //get the information from the pressed button and get that incident
                string information = DashDgInc.Rows[e.RowIndex].Cells[0].Value + "";
                ModIncident incident = conEmployeeDashboard.GetIncidentById(ObjectId.Parse(information));

                //fill in the cells with the information
                LblDashPopUpInformation.Text = "Informatie over: " + incident.Subject;
                lblDashPopupSubject.Text = "Subject: " + incident.Subject;
                lblDashPopupStatus.Text = "Status: " + incident.Status;

                FillCells(incident.Id);
            }
        }

        //method for filling in the cells
        private void FillCells(ObjectId incidentId)
        {
            //make a list and fill it with comments beloning to the incident
            List<ModComment> comments = conEmployeeDashboard.GetCommentByIncidentID(incidentId);
            DGDashPopup.Rows.Clear();
            //foreach comment, display what is said
            foreach (ModComment item in comments)
            {
                DGDashPopup.Rows.Add(item.Comment);
            }
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            pnlDashPopup.Visible = false;
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }
    }
}
