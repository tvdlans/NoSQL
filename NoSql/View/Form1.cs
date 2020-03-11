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
            ChartUnresInc.Series["s1"].IsValueShownAsLabel = true;

            //ChartUnresInc.ChartAreas["s1"].Area3DStyle.Rotation = -90;
            ChartUnresInc.Series["s1"].IsVisibleInLegend = false;
            ChartUnresInc.Series["s1"].Points.AddXY("1", "30");
            ChartUnresInc.Series["s1"].Points.AddXY("2", "70");
            //ChartUnresInc.
        }
    }
}
