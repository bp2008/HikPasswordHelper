using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace HikvisionPasswordResetHelper
{
	public partial class Main : Form
	{
		private const string BackdoorAuthArg = "auth=YWRtaW46MTEK";
		private Dictionary<string, string> userIds = new Dictionary<string, string>();

		public Main()
		{
			InitializeComponent();
			this.Text = "Hikvision Password Reset " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			txtIP.Focus();
		}

		private void btnGetUserList_Click(object sender, EventArgs e)
		{
			userIds.Clear();
			lbUsers.Items.Clear();
			lblStatus.Text = "Loading user list...";
			lblStatus.ForeColor = Color.Orange;
			WebClient wc = new WebClient();
			wc.DownloadStringCompleted += (object client, DownloadStringCompletedEventArgs response) =>
			{
				if (response.Cancelled)
				{
					lblStatus.Text = "Canceled.";
					lblStatus.ForeColor = Color.Black;
					return;
				}
				if (response.Error != null)
				{
					lblStatus.Text = "An error occurred";
					lblStatus.ForeColor = Color.Red;
					MessageBox.Show(response.Error.Message);
					return;
				}
				XmlDocument doc = new XmlDocument();
				doc.LoadXml(response.Result);
				XmlNodeList Users = doc.GetElementsByTagName("User");
				foreach (XmlNode user in Users)
				{
					userIds[user["userName"].InnerText] = user["id"].InnerText;
					lbUsers.Items.Add(user["userName"].InnerText);
				}
				if (lbUsers.Items.Count > 0)
				{
					lbUsers.SelectedIndex = 0;
					txtNewPW.Focus();
				}
				lblStatus.Text = "Loaded " + lbUsers.Items.Count + " user" + (lbUsers.Items.Count == 1 ? "" : "s") + ".  Ready to set passwords.";
				lblStatus.ForeColor = Color.Green;
			};
			wc.DownloadStringAsync(new Uri(GetURLBase() + "Security/users?" + BackdoorAuthArg));
		}

		private void btnSetPassword_Click(object sender, EventArgs e)
		{
			if (lbUsers.SelectedItem == null)
			{
				lblStatus.Text = "No user is selected";
				lblStatus.ForeColor = Color.Red;
				return;
			}
			if (string.IsNullOrWhiteSpace(txtNewPW.Text))
			{
				lblStatus.Text = "Enter a password";
				lblStatus.ForeColor = Color.Red;
				return;
			}
			string userName = lbUsers.SelectedItem.ToString();
			string userId = userIds[userName];
			if (string.IsNullOrWhiteSpace(userId))
			{
				lblStatus.Text = "Could not find user ID for user with name \"" + userName + "\"";
				lblStatus.ForeColor = Color.Red;
				return;
			}
			lblStatus.Text = "Assigning password \"" + txtNewPW.Text + "\" to user \"" + userName + "\"";
			lblStatus.ForeColor = Color.Orange;
			WebClient wc = new WebClient();
			wc.UploadStringCompleted += (object client, UploadStringCompletedEventArgs response) =>
			{
				if (response.Cancelled)
				{
					lblStatus.Text = "Canceled.";
					lblStatus.ForeColor = Color.Black;
					return;
				}
				if (response.Error != null)
				{
					lblStatus.Text = "An error occurred";
					lblStatus.ForeColor = Color.Red;
					MessageBox.Show(response.Error.Message);
					return;
				}
				if (response.Result.Contains("<statusString>OK</statusString>"))
				{
					lblStatus.Text = "Successfully assigned password \"" + txtNewPW.Text + "\" to user \"" + userName + "\"";
					lblStatus.ForeColor = Color.Green;
				}
				else
				{
					lblStatus.Text = "An error occurred";
					lblStatus.ForeColor = Color.Red;
					MessageBox.Show(response.Result);
				}
			};
			string userXml =
@"<User version=""1.0"" xmlns=""http://www.hikvision.com/ver10/XMLSchema"">
	<id>" + userId + @"</id>
	<userName>" + userName + @"</userName>
	<password>" + txtNewPW.Text + @"</password>
</User>";
			wc.UploadStringAsync(new Uri(GetURLBase() + "Security/users/" + userId + "?" + BackdoorAuthArg), "PUT", userXml);
		}


		private void lbUsers_SelectedValueChanged(object sender, EventArgs e)
		{
			lblSelectedUser.Text = lbUsers.SelectedItem == null ? "" : lbUsers.SelectedItem.ToString();
		}
		private string GetURLBase()
		{
			return "http" + (cbHttps.Checked ? "s" : "") + "://" + txtIP.Text + ":" + (int)nudPort.Value + "/";
		}
	}
}
