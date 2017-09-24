namespace HikvisionPasswordResetHelper
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.label1 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nudPort = new System.Windows.Forms.NumericUpDown();
			this.cbHttps = new System.Windows.Forms.CheckBox();
			this.lbUsers = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGetUserList = new System.Windows.Forms.Button();
			this.txtNewPW = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSetPassword = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSelectedUser = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Camera IP Address:";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(118, 6);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(135, 20);
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "192.168.0.1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Http(s) port:";
			// 
			// nudPort
			// 
			this.nudPort.Location = new System.Drawing.Point(118, 32);
			this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudPort.Name = "nudPort";
			this.nudPort.Size = new System.Drawing.Size(135, 20);
			this.nudPort.TabIndex = 3;
			this.nudPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			// 
			// cbHttps
			// 
			this.cbHttps.Location = new System.Drawing.Point(118, 58);
			this.cbHttps.Name = "cbHttps";
			this.cbHttps.Size = new System.Drawing.Size(135, 36);
			this.cbHttps.TabIndex = 4;
			this.cbHttps.Text = "Camera requires https (SSL) connection";
			this.cbHttps.UseVisualStyleBackColor = true;
			// 
			// lbUsers
			// 
			this.lbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbUsers.FormattingEnabled = true;
			this.lbUsers.Location = new System.Drawing.Point(12, 147);
			this.lbUsers.Name = "lbUsers";
			this.lbUsers.Size = new System.Drawing.Size(116, 147);
			this.lbUsers.TabIndex = 6;
			this.lbUsers.SelectedValueChanged += new System.EventHandler(this.lbUsers_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Users:";
			// 
			// btnGetUserList
			// 
			this.btnGetUserList.Location = new System.Drawing.Point(259, 6);
			this.btnGetUserList.Name = "btnGetUserList";
			this.btnGetUserList.Size = new System.Drawing.Size(102, 88);
			this.btnGetUserList.TabIndex = 5;
			this.btnGetUserList.Text = "Get User List";
			this.btnGetUserList.UseVisualStyleBackColor = true;
			this.btnGetUserList.Click += new System.EventHandler(this.btnGetUserList_Click);
			// 
			// txtNewPW
			// 
			this.txtNewPW.Location = new System.Drawing.Point(221, 147);
			this.txtNewPW.Name = "txtNewPW";
			this.txtNewPW.Size = new System.Drawing.Size(137, 20);
			this.txtNewPW.TabIndex = 7;
			this.txtNewPW.Text = "12345abc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(134, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "New Password:";
			// 
			// btnSetPassword
			// 
			this.btnSetPassword.Location = new System.Drawing.Point(134, 245);
			this.btnSetPassword.Name = "btnSetPassword";
			this.btnSetPassword.Size = new System.Drawing.Size(227, 49);
			this.btnSetPassword.TabIndex = 9;
			this.btnSetPassword.Text = "Set password for selected user";
			this.btnSetPassword.UseVisualStyleBackColor = true;
			this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(134, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Selected User:";
			// 
			// lblSelectedUser
			// 
			this.lblSelectedUser.AutoSize = true;
			this.lblSelectedUser.Location = new System.Drawing.Point(218, 131);
			this.lblSelectedUser.Name = "lblSelectedUser";
			this.lblSelectedUser.Size = new System.Drawing.Size(27, 13);
			this.lblSelectedUser.TabIndex = 11;
			this.lblSelectedUser.Text = "N/A";
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(12, 97);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(349, 34);
			this.lblStatus.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Enabled = false;
			this.label6.Location = new System.Drawing.Point(134, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(227, 60);
			this.label6.TabIndex = 13;
			this.label6.Text = "Newer firmwares require a password length of 8-16 characters including at least t" +
    "wo of: \r\n[number, lowercase, uppercase, special character].";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 306);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblSelectedUser);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSetPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNewPW);
			this.Controls.Add(this.btnGetUserList);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbUsers);
			this.Controls.Add(this.cbHttps);
			this.Controls.Add(this.nudPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Hikvision Password Reset";
			((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudPort;
		private System.Windows.Forms.CheckBox cbHttps;
		private System.Windows.Forms.ListBox lbUsers;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGetUserList;
		private System.Windows.Forms.TextBox txtNewPW;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSetPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSelectedUser;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label label6;
	}
}

