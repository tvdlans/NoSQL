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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleIndicent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlCreateIncident = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTypeIncident = new System.Windows.Forms.Label();
            this.lblReported = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbDateTime = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbDeadline = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelIncident.SuspendLayout();
            this.pnlCreateIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(21)))));
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.lblUser);
            this.panelBorder.Location = new System.Drawing.Point(2, 2);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1340, 100);
            this.panelBorder.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lato Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(201, 28);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1276, 65);
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
            this.panelMenu.Location = new System.Drawing.Point(2, 105);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(202, 768);
            this.panelMenu.TabIndex = 4;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOff.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(0, 358);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(202, 75);
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
            this.btnUser.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 246);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnDash.Location = new System.Drawing.Point(0, 29);
            this.btnDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncident.Name = "btnIncident";
            this.btnIncident.Size = new System.Drawing.Size(202, 75);
            this.btnIncident.TabIndex = 1;
            this.btnIncident.Text = "Incident Mangement";
            this.btnIncident.UseVisualStyleBackColor = false;
            this.btnIncident.Click += new System.EventHandler(this.btnIncident_Click);
            // 
            // panelDash
            // 
            this.panelDash.Location = new System.Drawing.Point(261, 169);
            this.panelDash.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelDash.Name = "panelDash";
            this.panelDash.Size = new System.Drawing.Size(1054, 658);
            this.panelDash.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.Location = new System.Drawing.Point(261, 169);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1054, 658);
            this.panelUser.TabIndex = 5;
            // 
            // panelIncident
            // 
            this.panelIncident.Controls.Add(this.pnlCreateIncident);
            this.panelIncident.Controls.Add(this.listBox1);
            this.panelIncident.Controls.Add(this.btnCreateIncident);
            this.panelIncident.Controls.Add(this.textBox1);
            this.panelIncident.Controls.Add(this.label1);
            this.panelIncident.Controls.Add(this.lblTitleIndicent);
            this.panelIncident.Location = new System.Drawing.Point(254, 162);
            this.panelIncident.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelIncident.Name = "panelIncident";
            this.panelIncident.Size = new System.Drawing.Size(1076, 678);
            this.panelIncident.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets";
            // 
            // lblTitleIndicent
            // 
            this.lblTitleIndicent.AutoSize = true;
            this.lblTitleIndicent.Font = new System.Drawing.Font("Lato Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIndicent.Location = new System.Drawing.Point(351, 26);
            this.lblTitleIndicent.Name = "lblTitleIndicent";
            this.lblTitleIndicent.Size = new System.Drawing.Size(410, 54);
            this.lblTitleIndicent.TabIndex = 0;
            this.lblTitleIndicent.Text = "Incident Mangement";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.Font = new System.Drawing.Font("Lato Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.ForeColor = System.Drawing.Color.White;
            this.btnCreateIncident.Location = new System.Drawing.Point(844, 130);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(178, 47);
            this.btnCreateIncident.TabIndex = 2;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(61, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(961, 404);
            this.listBox1.TabIndex = 3;
            // 
            // pnlCreateIncident
            // 
            this.pnlCreateIncident.Controls.Add(this.btnCancel);
            this.pnlCreateIncident.Controls.Add(this.btnConfirm);
            this.pnlCreateIncident.Controls.Add(this.txtDescription);
            this.pnlCreateIncident.Controls.Add(this.cmbDeadline);
            this.pnlCreateIncident.Controls.Add(this.cmbPriority);
            this.pnlCreateIncident.Controls.Add(this.cmbUser);
            this.pnlCreateIncident.Controls.Add(this.cmbType);
            this.pnlCreateIncident.Controls.Add(this.txtSubject);
            this.pnlCreateIncident.Controls.Add(this.cmbDateTime);
            this.pnlCreateIncident.Controls.Add(this.lblDescription);
            this.pnlCreateIncident.Controls.Add(this.lblDeadline);
            this.pnlCreateIncident.Controls.Add(this.lblPriority);
            this.pnlCreateIncident.Controls.Add(this.lblReported);
            this.pnlCreateIncident.Controls.Add(this.lblTypeIncident);
            this.pnlCreateIncident.Controls.Add(this.lblSubject);
            this.pnlCreateIncident.Controls.Add(this.lblDateTime);
            this.pnlCreateIncident.Controls.Add(this.label2);
            this.pnlCreateIncident.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateIncident.Name = "pnlCreateIncident";
            this.pnlCreateIncident.Size = new System.Drawing.Size(1075, 678);
            this.pnlCreateIncident.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Incident";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(268, 107);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(144, 20);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "Date/time reported";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(268, 157);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(136, 20);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject of incident";
            // 
            // lblTypeIncident
            // 
            this.lblTypeIncident.AutoSize = true;
            this.lblTypeIncident.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeIncident.Location = new System.Drawing.Point(268, 198);
            this.lblTypeIncident.Name = "lblTypeIncident";
            this.lblTypeIncident.Size = new System.Drawing.Size(118, 20);
            this.lblTypeIncident.TabIndex = 3;
            this.lblTypeIncident.Text = "Type of incident";
            // 
            // lblReported
            // 
            this.lblReported.AutoSize = true;
            this.lblReported.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReported.Location = new System.Drawing.Point(268, 244);
            this.lblReported.Name = "lblReported";
            this.lblReported.Size = new System.Drawing.Size(131, 20);
            this.lblReported.TabIndex = 4;
            this.lblReported.Text = "Reported By User";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(268, 294);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(62, 20);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(268, 342);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(71, 20);
            this.lblDeadline.TabIndex = 6;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(268, 390);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // cmbDateTime
            // 
            this.cmbDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateTime.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateTime.FormattingEnabled = true;
            this.cmbDateTime.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cmbDateTime.Location = new System.Drawing.Point(428, 107);
            this.cmbDateTime.Name = "cmbDateTime";
            this.cmbDateTime.Size = new System.Drawing.Size(265, 28);
            this.cmbDateTime.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(428, 157);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(265, 27);
            this.txtSubject.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.cmbType.Location = new System.Drawing.Point(428, 198);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(265, 28);
            this.cmbType.TabIndex = 10;
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(428, 244);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(265, 28);
            this.cmbUser.TabIndex = 11;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Normal",
            "Low",
            "High"});
            this.cmbPriority.Location = new System.Drawing.Point(428, 294);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(265, 28);
            this.cmbPriority.TabIndex = 12;
            // 
            // cmbDeadline
            // 
            this.cmbDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeadline.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeadline.FormattingEnabled = true;
            this.cmbDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.cmbDeadline.Location = new System.Drawing.Point(428, 342);
            this.cmbDeadline.Name = "cmbDeadline";
            this.cmbDeadline.Size = new System.Drawing.Size(265, 28);
            this.cmbDeadline.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(428, 390);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 166);
            this.txtDescription.TabIndex = 14;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(567, 591);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 60);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Add Incident";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lato Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(428, 591);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 60);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 869);
            this.Controls.Add(this.panelIncident);
            this.Controls.Add(this.panelDash);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelIncident.ResumeLayout(false);
            this.panelIncident.PerformLayout();
            this.pnlCreateIncident.ResumeLayout(false);
            this.pnlCreateIncident.PerformLayout();
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
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnlCreateIncident;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbDeadline;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cmbDateTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblReported;
        private System.Windows.Forms.Label lblTypeIncident;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDateTime;
    }
}

