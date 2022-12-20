/*
 * Student number:219143943   Name:Nobantu      Surname:Ndlovu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BLL;
using DAL;

namespace ONT2000_PROJECT_2020
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
		public static DataTable dtlog = null;
		BusinessLogicLayer bll = new BusinessLogicLayer();
        DataAccessLayer dal = new DataAccessLayer();
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		private void btnSignIn_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtUserID.Text))
			{
				errorUsernameLogin.SetError(txtUserID, "Please do not leave field empty.");
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
			{
				errorUsernameLogin.SetError(txtPassword, "Please do not leave field empty.");
			}
			DataTable dt = bll.GetLogin(txtUserID.Text, txtPassword.Text);
			if (dt.Rows.Count > 0)
			{

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if (dt.Rows[i]["Role"].ToString() == "Administrator")
					{
						DashBoard admin = new DashBoard(dt.Rows[0]["Name"].ToString() + "," + dt.Rows[0]["Surname"].ToString() + "(" + dt.Rows[0]["Role"].ToString() + ")");
						admin.Show();
						this.Hide();
					}
					else
					if (dt.Rows[i]["Role"].ToString() == "Lecturer")
					{
						frmLecturer lecturer = new frmLecturer(dt.Rows[0]["Name"].ToString() + "," + dt.Rows[0]["Surname"].ToString() + "(" + dt.Rows[0]["Role"].ToString() + ")");
						lecturer.Show();
						this.Hide();
					}
					else
					if (dt.Rows[i]["Role"].ToString() == "Student")
					{
						frmStudent student = new frmStudent(dt.Rows[0]["Name"].ToString() + "," + dt.Rows[0]["Surname"].ToString() + "(" + dt.Rows[0]["Role"].ToString() + ")");
						student.Show();
						this.Hide();
					}
				}

			}
			else
			{
				MessageBox.Show("Incorrect Login details.Or this user is In-Active from this server. Try again");

			}
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
			this.Close();
		}
    }
}
