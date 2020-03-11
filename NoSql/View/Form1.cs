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

            //method to show the donout graphs on Dashboard
            ShowDashboardCharts();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void ShowDashboardCharts()
        {
            ConDashboard dashboard = new ConDashboard();
            double completedTotal = dashboard.CalculateFinishedIncidents();
            ChartUnresInc.ChartAreas[0].Area3DStyle.Rotation = -90;
            ChartUnresInc.ChartAreas[0].Area3DStyle.Enable3D = true;
            ChartUnresInc.Series["s1"].IsValueShownAsLabel = true;
            ChartUnresInc.Series["s1"].IsVisibleInLegend = false;
            ChartUnresInc.Series["s1"].Points.AddXY("1", completedTotal.ToString());
            ChartUnresInc.Series["s1"].Points.AddXY("2", (100 - completedTotal).ToString());
        }
    }
}
