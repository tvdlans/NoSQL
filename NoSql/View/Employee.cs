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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        public void CloseAllPanelsExcept(Panel panel)
        {
            PanelDashboard.Hide();
            panel.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void Dashboard()
        {
            ConEmployeeDashboard conEmployeeDashboard = new ConEmployeeDashboard();
            ConIncident conIncident = new ConIncident();
            CloseAllPanelsExcept(PanelDashboard);

            List<ModIncident> incidents = conIncident.getIncidents();

            //clear comboBox before filling it
            //DashDgInc.Items.Clear();
            DashDgInc.Rows.Clear();
            DashDgInc.Font = new Font("Lato Light", 12, FontStyle.Regular);
            DashDgInc.RowTemplate.Height = 30;

            foreach (ModIncident item in incidents)
            {
                DashDgInc.Rows.Add(item.Id.ToString(), item.Subject, item.TypeOfIncident, item.Date.ToString("yyyy/MM/dd"), item.Deadline.ToString("yyyy/MM/dd"), item.Status + "%", item.Resolved);
            }

            foreach (DataGridViewRow row in DashDgInc.Rows)
            {
                if (row.Cells[6].Value.ToString() == "True")
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5eff7e");
                else if (Convert.ToDateTime(row.Cells[4].Value) < DateTime.Now)
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e34040");
                else if ((Convert.ToDateTime(row.Cells[4].Value) - DateTime.Now).Days < 3)
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#eba834");
                else
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffffff");
            }
        }

        private void DashDgInc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Ignore clicks that are not in the thing
            if (e.ColumnIndex == DashDgInc.Columns["ID"].Index && e.RowIndex >= 0)
            {
                pnlDashPopup.Visible = true;

                DAL.LoadRecordById

                string information = DashDgInc.Rows[e.RowIndex].Cells[1].Value + ""; ;

                LblDashPopUpInformation.Text = "Informatie over: " + information;
            }
        }
    }
}
