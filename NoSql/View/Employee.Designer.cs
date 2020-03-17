namespace View
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.DashDgInc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfIncident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FillInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resolved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Background = new System.Windows.Forms.Panel();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.pnlDashPopup = new System.Windows.Forms.Panel();
            this.pnlDashTitle = new System.Windows.Forms.Panel();
            this.LblDashPopUpInformation = new System.Windows.Forms.Label();
            this.DashLblTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDgInc)).BeginInit();
            this.PanelDashboard.SuspendLayout();
            this.pnlDashPopup.SuspendLayout();
            this.pnlDashTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.panelMenu.Controls.Add(this.btnLogOff);
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnDash);
            this.panelMenu.Location = new System.Drawing.Point(0, 86);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 947);
            this.panelMenu.TabIndex = 6;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(0, 201);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(180, 60);
            this.btnLogOff.TabIndex = 4;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 112);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(180, 60);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Support";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnDash.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(0, 23);
            this.btnDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(180, 60);
            this.btnDash.TabIndex = 0;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(21)))));
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.lblUser);
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1926, 86);
            this.panelBorder.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lato Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 54);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "The Garden Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 86);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1844, 60);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label3";
            // 
            // DashDgInc
            // 
            this.DashDgInc.AllowUserToAddRows = false;
            this.DashDgInc.AllowUserToDeleteRows = false;
            this.DashDgInc.BackgroundColor = System.Drawing.Color.White;
            this.DashDgInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashDgInc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Subject,
            this.TypeOfIncident,
            this.FillInDate,
            this.Deadline,
            this.Status,
            this.Resolved});
            this.DashDgInc.Location = new System.Drawing.Point(154, 199);
            this.DashDgInc.Margin = new System.Windows.Forms.Padding(10);
            this.DashDgInc.MinimumSize = new System.Drawing.Size(0, 50);
            this.DashDgInc.Name = "DashDgInc";
            this.DashDgInc.ReadOnly = true;
            this.DashDgInc.RowHeadersWidth = 80;
            this.DashDgInc.RowTemplate.Height = 24;
            this.DashDgInc.Size = new System.Drawing.Size(1515, 495);
            this.DashDgInc.TabIndex = 9;
            //this.DashDgInc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashDgInc_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 125;
            // 
            // TypeOfIncident
            // 
            this.TypeOfIncident.HeaderText = "Type Of Incident";
            this.TypeOfIncident.MinimumWidth = 6;
            this.TypeOfIncident.Name = "TypeOfIncident";
            this.TypeOfIncident.ReadOnly = true;
            this.TypeOfIncident.Width = 125;
            // 
            // FillInDate
            // 
            this.FillInDate.HeaderText = "Fill In Date";
            this.FillInDate.MinimumWidth = 6;
            this.FillInDate.Name = "FillInDate";
            this.FillInDate.ReadOnly = true;
            this.FillInDate.Width = 125;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Resolved
            // 
            this.Resolved.HeaderText = "Resolved";
            this.Resolved.MinimumWidth = 6;
            this.Resolved.Name = "Resolved";
            this.Resolved.ReadOnly = true;
            this.Resolved.Width = 125;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.White;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1920, 1080);
            this.Background.TabIndex = 8;
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.BackColor = System.Drawing.Color.White;
            this.PanelDashboard.Controls.Add(this.pnlDashPopup);
            this.PanelDashboard.Controls.Add(this.DashLblTitle);
            this.PanelDashboard.Controls.Add(this.DashDgInc);
            this.PanelDashboard.Location = new System.Drawing.Point(182, 88);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(1744, 945);
            this.PanelDashboard.TabIndex = 0;
            // 
            // pnlDashPopup
            // 
            this.pnlDashPopup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDashPopup.Controls.Add(this.pnlDashTitle);
            this.pnlDashPopup.Location = new System.Drawing.Point(351, 129);
            this.pnlDashPopup.Name = "pnlDashPopup";
            this.pnlDashPopup.Size = new System.Drawing.Size(713, 527);
            this.pnlDashPopup.TabIndex = 10;
            this.pnlDashPopup.Visible = false;
            // 
            // pnlDashTitle
            // 
            this.pnlDashTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.pnlDashTitle.Controls.Add(this.LblDashPopUpInformation);
            this.pnlDashTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlDashTitle.Name = "pnlDashTitle";
            this.pnlDashTitle.Size = new System.Drawing.Size(713, 102);
            this.pnlDashTitle.TabIndex = 0;
            // 
            // LblDashPopUpInformation
            // 
            this.LblDashPopUpInformation.AutoSize = true;
            this.LblDashPopUpInformation.Font = new System.Drawing.Font("Lato Light", 24F);
            this.LblDashPopUpInformation.ForeColor = System.Drawing.Color.White;
            this.LblDashPopUpInformation.Location = new System.Drawing.Point(3, 30);
            this.LblDashPopUpInformation.Name = "LblDashPopUpInformation";
            this.LblDashPopUpInformation.Size = new System.Drawing.Size(366, 49);
            this.LblDashPopUpInformation.TabIndex = 0;
            this.LblDashPopUpInformation.Text = "IncidentInformation";
            this.LblDashPopUpInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashLblTitle
            // 
            this.DashLblTitle.AutoSize = true;
            this.DashLblTitle.Font = new System.Drawing.Font("Lato Light", 30F);
            this.DashLblTitle.Location = new System.Drawing.Point(743, 47);
            this.DashLblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashLblTitle.Name = "DashLblTitle";
            this.DashLblTitle.Size = new System.Drawing.Size(263, 61);
            this.DashLblTitle.TabIndex = 8;
            this.DashLblTitle.Text = "Dashboard";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.Background);
            this.Name = "Employee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDgInc)).EndInit();
            this.PanelDashboard.ResumeLayout(false);
            this.PanelDashboard.PerformLayout();
            this.pnlDashPopup.ResumeLayout(false);
            this.pnlDashTitle.ResumeLayout(false);
            this.pnlDashTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.DataGridView DashDgInc;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.Label DashLblTitle;
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn FillInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolved;
        private System.Windows.Forms.Panel pnlDashPopup;
        private System.Windows.Forms.Panel pnlDashTitle;
        private System.Windows.Forms.Label LblDashPopUpInformation;
    }
}