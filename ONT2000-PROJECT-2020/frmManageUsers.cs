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
using BLL;
using DAL;


namespace ONT2000_PROJECT_2020
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }
		BusinessLogicLayer bll = new BusinessLogicLayer();
		DataAccessLayer dll = new DataAccessLayer();
		private void btnAdd_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtName.Text))
			{
				errorName.SetError(txtName, "Please do not leave field empty. Enter your Name.");
			}
			else if (string.IsNullOrEmpty(txtSurname.Text))
			{
				errorSurname.SetError(txtSurname, "Please do not leave field empty.Enter your Surname.");
			}
			else if (string.IsNullOrEmpty(txtEmail.Text))
			{
				errorEmailAddress.SetError(txtEmail, "Please do not leave field empty.Enter your Email Address.");
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				errorPassword.SetError(txtPassword, "Please do not leave field empty.Enter your Password.");
			}
			else
			{
				User user = new User(txtName.Text, txtSurname.Text, cmbTitle.Text, cmbRole.Text, txtEmail.Text, txtPassword.Text, cmbUserStatus.Text);
				int x = bll.InsertUser(user);
				if (x > 0)
				{
					MessageBox.Show("User was not Added");

				}
				else
				{
					MessageBox.Show("User was Added!!!");
					if (cmbRole.Text == "Administrator")
					{
						bll.AddAdministrator();
					}
					else if (cmbRole.Text == "Student")
					{
						bll.InsertStudent();
					}
					else if (cmbRole.Text == "Lecturer")
					{
						bll.InsertLecturer();
					}
				}

			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			User user = new User();
			user.Name = txtName.Text;
			user.Surname = txtSurname.Text;
			user.Title = cmbTitle.Text;
			user.Role = cmbRole.Text;
			user.Email = txtEmail.Text;
			user.Password = txtPassword.Text;
			user.UserStatus = cmbUserStatus.Text;
			if (bll.UpdateUser(user) < 0)
			{
				MessageBox.Show("You have updated this users details");
				dgvDisplay.DataSource = bll.GetUser();
			}
			else
			{

				MessageBox.Show("Please select a user if you want to update");
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			User users = new User();
			users.UserID = int.Parse(dgvDisplay.SelectedRows[0].Cells["UserID"].Value.ToString());
			users.UserStatus = "In-Active";
			bll.DeleteUser(users);
			dgvDisplay.DataSource = bll.GetUser();
		}

        private void btnList_Click(object sender, EventArgs e)
        {
			dgvDisplay.DataSource = bll.GetUser();
		}

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
			dgvDisplay.DataSource = bll.GetUser();
			cmbRole.Items.Add("Student");
			cmbRole.Items.Add("Lecturer");
			cmbRole.Items.Add("Administrator");

			cmbUserStatus.Items.Add("In-Active");
			cmbUserStatus.Items.Add("Active");

			cmbTitle.Items.Add("Mr");
			cmbTitle.Items.Add("Mrs");
			cmbTitle.Items.Add("Miss");
			cmbTitle.Items.Add("Ms");
			cmbTitle.Items.Add("Professor");
			cmbTitle.Items.Add("Director");
			cmbTitle.Items.Add("Doctor");
			cmbTitle.Items.Add("Other");
		}

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgvDisplay.Rows.Count > 0)
			{
				txtName.Text = dgvDisplay.SelectedRows[0].Cells[1].Value.ToString();
				txtSurname.Text = dgvDisplay.SelectedRows[0].Cells[2].Value.ToString();
				cmbTitle.SelectedItem = dgvDisplay.SelectedRows[0].Cells[3].Value.ToString();
				cmbRole.SelectedItem = dgvDisplay.SelectedRows[0].Cells[4].Value.ToString();
				txtEmail.Text = dgvDisplay.SelectedRows[0].Cells[5].Value.ToString();
				txtPassword.Text = dgvDisplay.SelectedRows[0].Cells[6].Value.ToString();
				cmbUserStatus.SelectedItem = dgvDisplay.SelectedRows[0].Cells[7].Value.ToString();
			}
		}
    }
}
