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
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelIncident = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleIndicent = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(21)))));
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.lblUser);
            this.panelBorder.Location = new System.Drawing.Point(2, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1189, 100);
            this.panelBorder.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lato Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(201, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 64);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "The Garden Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 97);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1030, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 20);
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
            this.panelMenu.Location = new System.Drawing.Point(2, 102);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(202, 592);
            this.panelMenu.TabIndex = 4;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(0, 357);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(202, 75);
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
            this.btnUser.Location = new System.Drawing.Point(0, 246);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(202, 75);
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
            this.btnDash.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(0, 30);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(202, 75);
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
            this.btnIncident.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncident.ForeColor = System.Drawing.Color.White;
            this.btnIncident.Location = new System.Drawing.Point(0, 138);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(202, 75);
            this.btnIncident.TabIndex = 1;
            this.btnIncident.Text = "Incident Mangement";
            this.btnIncident.UseVisualStyleBackColor = false;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // panelDash
            // 
            this.panelDash.Location = new System.Drawing.Point(226, 132);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(956, 542);
            this.panelDash.TabIndex = 5;
            // 
            // panelUser
            // 
            this.panelUser.Location = new System.Drawing.Point(226, 132);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(956, 542);
            this.panelUser.TabIndex = 6;
            // 
            // panelIncident
            // 
            this.panelIncident.Controls.Add(this.listBox1);
            this.panelIncident.Controls.Add(this.btnCreateIncident);
            this.panelIncident.Controls.Add(this.txtFilter);
            this.panelIncident.Controls.Add(this.label1);
            this.panelIncident.Controls.Add(this.lblTitleIndicent);
            this.panelIncident.Location = new System.Drawing.Point(226, 129);
            this.panelIncident.Name = "panelIncident";
            this.panelIncident.Size = new System.Drawing.Size(956, 542);
            this.panelIncident.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(144, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(651, 284);
            this.listBox1.TabIndex = 4;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.Font = new System.Drawing.Font("Lato Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.ForeColor = System.Drawing.Color.White;
            this.btnCreateIncident.Location = new System.Drawing.Point(600, 124);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(195, 48);
            this.btnCreateIncident.TabIndex = 3;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(144, 138);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(177, 26);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "Filter by Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            // 
            // lblTitleIndicent
            // 
            this.lblTitleIndicent.AutoSize = true;
            this.lblTitleIndicent.Font = new System.Drawing.Font("Lato Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIndicent.Location = new System.Drawing.Point(271, 24);
            this.lblTitleIndicent.Name = "lblTitleIndicent";
            this.lblTitleIndicent.Size = new System.Drawing.Size(410, 54);
            this.lblTitleIndicent.TabIndex = 0;
            this.lblTitleIndicent.Text = "Incident Mangement";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 696);
            this.Controls.Add(this.panelIncident);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelIncident.ResumeLayout(false);
            this.panelIncident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Panel panelIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleIndicent;
        private System.Windows.Forms.TextBox txtFilter;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.ListBox listBox1;
    }
}

