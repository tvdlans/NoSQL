namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnIncident = new System.Windows.Forms.Button();
            this.panelDash = new System.Windows.Forms.Panel();
            this.chartRight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartUnresInc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUnresInc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(21)))));
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.lblUser);
            this.panelBorder.Location = new System.Drawing.Point(1, 1);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1191, 80);
            this.panelBorder.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(179, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 52);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "The Garden Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1135, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label3";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.panelMenu.Controls.Add(this.btnLogOff);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnDash);
            this.panelMenu.Controls.Add(this.btnIncident);
            this.panelMenu.Location = new System.Drawing.Point(1, 84);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 614);
            this.panelMenu.TabIndex = 4;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(0, 287);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(180, 60);
            this.btnLogOff.TabIndex = 4;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 197);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 60);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User Mangement";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnDash.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(0, 23);
            this.btnDash.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(180, 60);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnIncident
            // 
            this.btnIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnIncident.FlatAppearance.BorderSize = 0;
            this.btnIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncident.ForeColor = System.Drawing.Color.White;
            this.btnIncident.Location = new System.Drawing.Point(0, 111);
            this.btnIncident.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(180, 60);
            this.btnIncident.TabIndex = 1;
            this.btnIncident.Text = "Incident Mangement";
            this.btnIncident.UseVisualStyleBackColor = false;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // panelDash
            // 
            this.panelDash.Controls.Add(this.chartRight);
            this.panelDash.Controls.Add(this.ChartUnresInc);
            this.panelDash.Controls.Add(this.lblDashboardTitle);
            this.panelDash.Location = new System.Drawing.Point(232, 135);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(937, 527);
            this.panelDash.TabIndex = 1;
            // 
            // chartRight
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRight.Legends.Add(legend1);
            this.chartRight.Location = new System.Drawing.Point(571, 87);
            this.chartRight.Name = "chartRight";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRight.Series.Add(series1);
            this.chartRight.Size = new System.Drawing.Size(300, 300);
            this.chartRight.TabIndex = 2;
            this.chartRight.Text = "chartRight";
            // 
            // ChartUnresInc
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartUnresInc.ChartAreas.Add(chartArea2);
            this.ChartUnresInc.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.ChartUnresInc.Legends.Add(legend2);
            this.ChartUnresInc.Location = new System.Drawing.Point(92, 87);
            this.ChartUnresInc.Name = "ChartUnresInc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.CustomProperties = "DoughnutRadius=40";
            series2.Font = new System.Drawing.Font("Lato Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.ChartUnresInc.Series.Add(series2);
            this.ChartUnresInc.Size = new System.Drawing.Size(300, 300);
            this.ChartUnresInc.TabIndex = 1;
            this.ChartUnresInc.Text = "chart1";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Lato Light", 30F);
            this.lblDashboardTitle.Location = new System.Drawing.Point(341, 0);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(263, 61);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // panelUser
            // 
            this.panelUser.Location = new System.Drawing.Point(232, 135);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(937, 527);
            this.panelUser.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 695);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorder);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDash.ResumeLayout(false);
            this.panelDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUnresInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnIncident;
        private System.Windows.Forms.Panel panelDash;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartUnresInc;
    }
}

