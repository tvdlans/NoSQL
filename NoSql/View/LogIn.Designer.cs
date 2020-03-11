namespace View
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkremember = new System.Windows.Forms.CheckBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lnkforgotpswd = new System.Windows.Forms.LinkLabel();
            this.pnlforgotpswd = new System.Windows.Forms.Panel();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlforgotpswd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(21)))));
            this.panelBorder.Controls.Add(this.lblTitle);
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Location = new System.Drawing.Point(2, 1);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(793, 65);
            this.panelBorder.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(134, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 39);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "The Garden Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Garden Group";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(359, 225);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtPassword.Location = new System.Drawing.Point(359, 263);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 21);
            this.txtPassword.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(301, 225);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 20);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Email";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWachtwoord.Location = new System.Drawing.Point(273, 263);
            this.lblWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(78, 20);
            this.lblWachtwoord.TabIndex = 10;
            this.lblWachtwoord.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(359, 337);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 34);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkremember
            // 
            this.chkremember.AutoSize = true;
            this.chkremember.Location = new System.Drawing.Point(359, 302);
            this.chkremember.Name = "chkremember";
            this.chkremember.Size = new System.Drawing.Size(94, 17);
            this.chkremember.TabIndex = 12;
            this.chkremember.Text = "Remember me";
            this.chkremember.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(49)))));
            this.panelMenu.Location = new System.Drawing.Point(1, 66);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(135, 385);
            this.panelMenu.TabIndex = 5;
            // 
            // lnkforgotpswd
            // 
            this.lnkforgotpswd.AutoSize = true;
            this.lnkforgotpswd.Font = new System.Drawing.Font("Lato Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkforgotpswd.Location = new System.Drawing.Point(359, 386);
            this.lnkforgotpswd.Name = "lnkforgotpswd";
            this.lnkforgotpswd.Size = new System.Drawing.Size(113, 14);
            this.lnkforgotpswd.TabIndex = 13;
            this.lnkforgotpswd.TabStop = true;
            this.lnkforgotpswd.Text = "Forgot your password?";
            this.lnkforgotpswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkforgotpswd_LinkClicked);
            // 
            // pnlforgotpswd
            // 
            this.pnlforgotpswd.Controls.Add(this.btnSendMail);
            this.pnlforgotpswd.Location = new System.Drawing.Point(141, 71);
            this.pnlforgotpswd.Name = "pnlforgotpswd";
            this.pnlforgotpswd.Size = new System.Drawing.Size(654, 380);
            this.pnlforgotpswd.TabIndex = 14;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(221, 181);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "button1";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.pnlforgotpswd);
            this.Controls.Add(this.lnkforgotpswd);
            this.Controls.Add(this.chkremember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBorder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlforgotpswd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkremember;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.LinkLabel lnkforgotpswd;
        private System.Windows.Forms.Panel pnlforgotpswd;
        private System.Windows.Forms.Button btnSendMail;
    }
}